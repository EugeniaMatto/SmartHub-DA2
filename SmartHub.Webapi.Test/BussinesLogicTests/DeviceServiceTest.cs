using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.BussinesLogic.deviceImporter;
using SmartHub.BussinesLogic.ModelValidator;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class DeviceServiceTest
{
    private DeviceService? _deviceService;
    private Mock<IRepository<Device>>? _deviceRepositoryMock;
    private Mock<IRepository<Company>>? _companyRepositoryMock;
    private Mock<IRepository<Hardware>>? _hardwareRepositoryMock;
    private Mock<IDeviceImporterFactory>? _importerFactoryMock;
    private Mock<IDeviceModelValidator>? _validatorMock;

    [TestInitialize]
    public void Setup()
    {
        _deviceRepositoryMock = new Mock<IRepository<Device>>();
        _companyRepositoryMock = new Mock<IRepository<Company>>();
        _hardwareRepositoryMock = new Mock<IRepository<Hardware>>();
        _importerFactoryMock = new Mock<IDeviceImporterFactory>();
        _validatorMock = new Mock<IDeviceModelValidator>();

        _deviceService = new DeviceService(
            _deviceRepositoryMock.Object,
            _companyRepositoryMock.Object,
            _hardwareRepositoryMock.Object,
            _importerFactoryMock.Object,
            _validatorMock.Object);
    }

    [TestMethod]
    public void GetDevices_ShouldReturnPaginatedResult()
    {
        var device1 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device A",
            Model = "Model 1",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device2 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device B",
            Model = "Model 2",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device3 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var devices = new List<Device> { device1, device2, device3 };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());

        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = null,
            DeviceType = null,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(2, result.Items.Count);
        Assert.AreEqual(3, result.TotalCount);
        Assert.AreEqual(1, result.PageNumber);
        Assert.AreEqual(2, result.PageSize);
    }

    [TestMethod]
    public void GetDevices_ShouldReturnEmptyResult_WhenNoDevices()
    {
        var devices = new List<Device>();

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());

        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = null,
            DeviceType = null,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(0, result.Items.Count);
        Assert.AreEqual(0, result.TotalCount);
        Assert.AreEqual(1, result.PageNumber);
        Assert.AreEqual(2, result.PageSize);
    }

    [TestMethod]
    public void GetDevices_ShouldReturnCorrectPage_WhenPageNumberIsGreaterThanTotalPages()
    {
        var devices = new List<Device>
        {
            new Device { Id = Guid.NewGuid(), Name = "Device 1", Model = "Model 1" },
            new Device { Id = Guid.NewGuid(), Name = "Device 2", Model = "Model 2" },
            new Device { Id = Guid.NewGuid(), Name = "Device 3", Model = "Model 3" }
        };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());

        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = null,
            DeviceType = null,
            PageNumber = 5,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(0, result.Items.Count);
        Assert.AreEqual(3, result.TotalCount);
        Assert.AreEqual(5, result.PageNumber);
        Assert.AreEqual(2, result.PageSize);
    }

    [TestMethod]
    public void GetDeviceTypes_ShouldReturnAllDeviceTypes()
    {
        var result = _deviceService.GetDeviceTypes();
        var expectedTypes = Enum.GetNames(typeof(DeviceType)).ToList();

        CollectionAssert.AreEquivalent(expectedTypes, result);
    }

    [TestMethod]
    public void AddDevice_ShouldAddDevice_WhenUserIsCompanyOwner()
    {
        var device = new Device { Id = Guid.NewGuid(), Name = "Device 1", Model = "Model 1" };
        var user = new User { Id = Guid.NewGuid(), Roles = [Role.CompanyOwner] };
        var company = new Company { OwnerId = user.Id };

        _companyRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Company, bool>>>(), null))
            .Returns(company);
        _deviceRepositoryMock.Setup(repo => repo.Add(It.IsAny<Device>()));

        _deviceService.AddDevice(device, user);

        _deviceRepositoryMock.Verify(repo => repo.Add(device), Times.Once);
        Assert.AreEqual(company, device.Company);
    }

    [TestMethod]
    public void GetHardwareById_ShouldReturnHardware_WhenHardwareExists()
    {
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Id = hardwareId, Device = new Device() };

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
            .Returns(hardware);

        var result = _deviceService.GetHardwareById(hardwareId);

        Assert.AreEqual(hardware, result);
    }

    [TestMethod]
    public void HardwareTurnOff_ShouldThrowInvalidOperationException_WhenHardwareIsAlreadyOff()
    {
        var hardwareId = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.NewGuid() };
        var hardware = new Hardware { Id = Guid.Parse(hardwareId), Online = false };

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
    .Returns(hardware);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _deviceService.HardwareTurnOff(hardwareId, user));
    }

    [TestMethod]
    public void HardwareTurnOff_ShouldUpdateHardwareStatus_WhenHardwareIsOnline()
    {
        var hardwareId = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.NewGuid() };
        var hardware = new Hardware { Id = Guid.Parse(hardwareId), Online = true };

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
    .Returns(hardware);

        _deviceService.HardwareTurnOff(hardwareId, user);

        Assert.IsFalse(hardware.Online);
        _hardwareRepositoryMock.Verify(repo => repo.Update(hardware), Times.Once);
    }

    [TestMethod]
    public void HardwareTurnOn_ShouldThrowInvalidOperationException_WhenHardwareIsAlreadyOn()
    {
        var hardwareId = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.NewGuid() };
        var hardware = new Hardware { Id = Guid.Parse(hardwareId), Online = true };

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
    .Returns(hardware);

        var exception = Assert.ThrowsException<HardwareFeatureNotSupportedException>(() => _deviceService.HardwareTurnOn(hardwareId, user));
    }

    [TestMethod]
    public void HardwareTurnOn_ShouldUpdateHardwareStatus_WhenHardwareIsOffline()
    {
        var hardwareId = Guid.NewGuid().ToString();
        var user = new User { Id = Guid.NewGuid() };
        var hardware = new Hardware { Id = Guid.Parse(hardwareId), Online = false };

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
    .Returns(hardware);

        _deviceService.HardwareTurnOn(hardwareId, user);

        Assert.IsTrue(hardware.Online);
        _hardwareRepositoryMock.Verify(repo => repo.Update(hardware), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException), "Hardware not found")]
    public void GetHardwareById_ShouldThrowException_WhenHardwareDoesNotExist()
    {
        var hardwareId = Guid.NewGuid();

        _hardwareRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Hardware, bool>>>(), It.IsAny<Expression<Func<Hardware, object>>[]>()))
            .Throws(new InvalidOperationException("Hardware not found"));

        _deviceService.GetHardwareById(hardwareId);
    }

    [TestMethod]
    public void GetDevices_ShouldFilterByName_WhenNameIsProvided()
    {
        var device1 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device A",
            Model = "Model 1",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device2 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device B",
            Model = "Model 2",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device3 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };
        var devices = new List<Device> { device1, device2, device3 };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());

        var filter = new DeviceFilterRequest
        {
            Name = "Device A",
            Model = null,
            CompanyName = null,
            DeviceType = null,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(1, result.Items.Count);
    }

    [TestMethod]
    public void GetDevices_ShouldFilterByModel_WhenModelIsProvided()
    {
        var device1 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device A",
            Model = "Model 1",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device2 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device B",
            Model = "Model 2",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var device3 = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Device C",
            Model = "Model 3",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var devices = new List<Device> { device1, device2, device3 };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());
        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = "Model 2",
            CompanyName = null,
            DeviceType = null,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(1, result.Items.Count);
    }

    [TestMethod]
    public void GetDevices_ShouldFilterByCompanyName_WhenCompanyNameIsProvided()
    {
        var company = new Company { Name = "Company A" };
        var devices = new List<Device>
    {
        new Device { Id = Guid.NewGuid(), Name = "Device A", Model = "Model 1", Company = company },
        new Device { Id = Guid.NewGuid(), Name = "Device B", Model = "Model 2", Company = new Company { Name = "Company B" } },
        new Device { Id = Guid.NewGuid(), Name = "Device C", Model = "Model 3", Company = company }
    };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());
        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = "Company A",
            DeviceType = null,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(2, result.Items.Count);
    }

    [TestMethod]
    public void GetDevices_ShouldFilterByDeviceType_WhenDeviceTypeIsProvided()
    {
        var deviceWindowSensor = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.WindowSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var deviceOther = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var devices = new List<Device> { deviceWindowSensor, deviceWindowSensor, deviceOther };

        _deviceRepositoryMock.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Device, object>>[]>())).Returns(devices.AsQueryable());

        var filter = new DeviceFilterRequest
        {
            Name = null,
            Model = null,
            CompanyName = null,
            DeviceType = DeviceType.WindowSensor,
            PageNumber = 1,
            PageSize = 2
        };

        var result = _deviceService.GetDevices(filter);

        Assert.AreEqual(2, result.Items.Count);
    }

    [TestMethod]
    public void UpdateHardware_ShouldUpdateHardwareAndReturnId()
    {
        var hardwareId = Guid.NewGuid();
        var hardware = new Hardware { Id = hardwareId };

        _hardwareRepositoryMock.Setup(repo => repo.Update(hardware));

        var result = _deviceService.UpdateHardware(hardware);

        Assert.AreEqual(hardwareId, result);
        _hardwareRepositoryMock.Verify(repo => repo.Update(hardware), Times.Once);
    }

    [TestMethod]
    public void DeviceService_ImportDevices_ReturnsCorrectImportDevicesResponse()
    {
        var request = new ImportDevicesRequest
        {
            Source = "test.json",
            Type = "json"
        };

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = "Test User",
            Roles = [Role.CompanyOwner]
        };

        var mockDevices = new List<Device>
        {
            new Device
            {
                Id = Guid.NewGuid(),
                Name = "Device1",
                Model = "ModelA",
                Type = DeviceType.WindowSensor,
                Photos = ["photo1.jpg", "photo2.jpg"],
                Description = "A window sensor device",
                CompanyId = Guid.NewGuid(),
                Company = new Company { Id = Guid.NewGuid(), Name = "CompanyA" }
            },
            new Device
            {
                Id = Guid.NewGuid(),
                Name = "Device2",
                Model = "ModelB",
                Type = DeviceType.MotionSensor,
                Photos = ["photo3.jpg", "photo4.jpg"],
                Description = "A motion sensor device",
                CompanyId = Guid.NewGuid(),
                Company = new Company { Id = Guid.NewGuid(), Name = "CompanyB" }
            }
        };

        var company = new Company { Id = Guid.NewGuid(), Name = "CompanyB" };

        _companyRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Company, bool>>>(), null))
            .Returns(company);

        var mock = new Mock<IDeviceImporter>();
        _importerFactoryMock.Setup(importer => importer.GetImporter("json")).Returns(mock.Object);

        mock.Setup(importer => importer.ImportDevices(request.Source)).Returns(mockDevices);

        var result = _deviceService!.ImportDevices(request, user);

        Assert.IsNotNull(result);
        Assert.AreEqual(mockDevices.Count, result.Total);
        Assert.AreEqual(mockDevices.Count, result.Devices.Count);
    }

    [TestMethod]
    public void SelectDeviceValidator_ShouldUpdateCompanyValidatorAndReturnSuccessMessage()
    {
        var validator = "ValidatorName";
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        var company = new Company { Id = Guid.NewGuid(), OwnerId = user.Id, Validator = null };

        _companyRepositoryMock.Setup(repo => repo.Get(It.IsAny<Expression<Func<Company, bool>>>(), null))
            .Returns(company);
        _companyRepositoryMock.Setup(repo => repo.Update(company));

        var result = _deviceService.SelectDeviceValidator(validator, user);

        Assert.AreEqual($"Validator {validator} selected successfully", result);
        Assert.AreEqual(validator, company.Validator);
        _companyRepositoryMock.Verify(repo => repo.Update(company), Times.Once);
    }

    [TestMethod]
    public void GetRegisteredValidators_ShouldReturnListOfValidators()
    {
        var expectedValidators = new List<string> { "Validator1", "Validator2" };
        _validatorMock.Setup(validator => validator.GetRegisteredValidators())
            .Returns(expectedValidators);

        var result = _deviceService.GetRegisteredValidators();

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedValidators.Count, result.Count);
        CollectionAssert.AreEquivalent(expectedValidators, result);
    }
}
