using ModeloValidador.Abstracciones;
using SmartHub.BussinesLogic.deviceImporter;
using SmartHub.BussinesLogic.ModelValidator;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public class DeviceService : IDeviceService
{
    private readonly IRepository<Device> _deviceRepository;
    private readonly IRepository<Company> _companyRepository;
    private readonly IRepository<Hardware> _hardwareRepository;
    private readonly IDeviceImporterFactory _importerFactory;
    private readonly IDeviceModelValidator _modelValidator;

    public DeviceService(
        IRepository<Device> deviceRepository,
        IRepository<Company> companyRepository,
        IRepository<Hardware> hardwareRepository,
        IDeviceImporterFactory importerFactory,
        IDeviceModelValidator modelValidator)
    {
        _deviceRepository = deviceRepository;
        _companyRepository = companyRepository;
        _hardwareRepository = hardwareRepository;
        _importerFactory = importerFactory;
        _modelValidator = modelValidator;
    }

    public PaginatedResult<DeviceResponse> GetDevices(DeviceFilterRequest filter)
    {
        var query = _deviceRepository.GetAll(null, d => d.Company)
            .Where(d =>
                (string.IsNullOrEmpty(filter.Name) || d.Name.ToLower().Contains(filter.Name.ToLower())) &&
                (string.IsNullOrEmpty(filter.Model) || d.Model.ToLower().Contains(filter.Model.ToLower())) &&
                (string.IsNullOrEmpty(filter.CompanyName) || d.Company.Name.ToLower().Contains(filter.CompanyName.ToLower())) &&
                (!filter.DeviceType.HasValue || d.Type == filter.DeviceType.Value));

        var totalItems = query.Count();

        var items = query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .ToList();

        var deviceInfos = items.Select(device => new DeviceResponse(device, device.Company)).ToList();

        return new PaginatedResult<DeviceResponse>(
            deviceInfos,
            totalItems,
            filter.PageNumber,
            filter.PageSize);
    }

    public List<string> GetDeviceTypes()
    {
        return Enum.GetNames(typeof(DeviceType)).ToList();
    }

    public void AddDevice(Device device, User user)
    {
        var company = _companyRepository.Get(c => c.OwnerId == user.Id, null);
        device.Company = company;
        device.CompanyId = company.Id;

        if (company.Validator != string.Empty)
        {
            IModeloValidador validator = _modelValidator.GetValidator(device.Company.Validator);
            var esValido = validator.EsValido(new Modelo(device.Model));
            if (!esValido)
            {
                throw new InvalidValueException("Model", device.Model, new { Validator = company.Validator });
            }
        }

        _deviceRepository.Add(device);
    }

    public Hardware GetHardwareById(Guid hardwareId)
    {
        var hardware = _hardwareRepository.Get(
            h => h.Id == hardwareId,
            h => h.Device, h => h.Device.Company);

        return hardware;
    }

    public Guid UpdateHardware(Hardware hardware)
    {
        _hardwareRepository.Update(hardware);
        return hardware.Id;
    }

    public ImportDevicesResponse ImportDevices(ImportDevicesRequest request, User user)
    {
        IDeviceImporter importer = _importerFactory.GetImporter(request.Type);

        var devices = importer.ImportDevices(request.Source);

        var deviceInfos = devices.Select(device =>
        {
            var company = _companyRepository.Get(c => c.OwnerId == user.Id, null);
            device.Company = company;
            device.CompanyId = company.Id;
            _deviceRepository.Add(device);
            return new DeviceResponse(device, device.Company);
        }).ToList();

        var result = new ImportDevicesResponse(devices.Count, deviceInfos);

        return result;
    }

    public List<string> GetRegisteredImporters()
    {
        return _importerFactory.GetRegisteredImporters();
    }

    public string SelectDeviceValidator(string validator, User user)
    {
        IModeloValidador importer = _modelValidator.GetValidator(validator);
        var company = _companyRepository.Get(c => c.OwnerId == user.Id, null);
        company.Validator = validator;
        _companyRepository.Update(company);
        return $"Validator {validator} selected successfully";
    }

    public List<string> GetRegisteredValidators()
    {
        return _modelValidator.GetRegisteredValidators();
    }

    public void HardwareTurnOff(string hardwareId, User user)
    {
        var hardware = GetHardwareById(Guid.Parse(hardwareId));
        if (hardware.Online == false)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId, "Already Off");
        }

        hardware.Online = false;
        _hardwareRepository.Update(hardware);
    }

    public void HardwareTurnOn(string hardwareId, User user)
    {
        var hardware = GetHardwareById(Guid.Parse(hardwareId));
        if (hardware.Online == true)
        {
            throw new HardwareFeatureNotSupportedException(hardwareId, "Already On");
        }

        hardware.Online = true;
        _hardwareRepository.Update(hardware);
    }
}
