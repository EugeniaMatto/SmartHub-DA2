namespace SmartHub.BussinesLogic.deviceImporter;
public interface IDeviceImporterFactory
{
    IDeviceImporter GetImporter(string importerType);
    List<string> GetRegisteredImporters();
}
