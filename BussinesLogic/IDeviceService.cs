using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public interface IDeviceService
{
    PaginatedResult<DeviceResponse> GetDevices(DeviceFilterRequest filter);
    List<string> GetDeviceTypes();
    void AddDevice(Device device, User user);
    Hardware GetHardwareById(Guid hardwareId);
    Guid UpdateHardware(Hardware hardware);
    ImportDevicesResponse ImportDevices(ImportDevicesRequest request, User user);
    List<string> GetRegisteredImporters();
    string SelectDeviceValidator(string validator, User user);
    List<string> GetRegisteredValidators();
    void HardwareTurnOff(string hardwareId, User user);
    void HardwareTurnOn(string hardwareId, User user);
}
