using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using SmartHub.Exceptions;

namespace SmartHub.BussinesLogic.deviceImporter;

[ExcludeFromCodeCoverage]
public class DeviceImporterFactory : IDeviceImporterFactory
{
    private static readonly Dictionary<string, Type> _importers = [];
    private static readonly string _folderPath = Path.GetFullPath(
        Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "dlls", "deviceImporters"));

    public IDeviceImporter GetImporter(string importerType)
    {
        LoadImportersFromFolder();
        var lowerCaseType = importerType.ToLower();

        if (_importers.TryGetValue(lowerCaseType, out var type))
        {
            return (IDeviceImporter)Activator.CreateInstance(type);
        }

        throw new InvalidValueException(
            "ImporterType",
            importerType,
            new { AvailableTypes = _importers.Keys });
    }

    private void LoadImportersFromFolder()
    {
        if (!Directory.Exists(_folderPath))
        {
            throw new NotFoundException("Directory", _folderPath, new { Path = _folderPath });
        }

        var dllFiles = Directory.GetFiles(_folderPath, "*.dll");

        foreach (var file in dllFiles)
        {
            try
            {
                var assembly = Assembly.LoadFrom(file);
                var types = assembly.GetTypes()
                    .Where(t => typeof(IDeviceImporter).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                foreach (var type in types)
                {
                    var extension = type.Name
                        .Replace("DeviceImporter", string.Empty)
                        .Replace("Importer", string.Empty)
                        .ToLower();

                    if (!_importers.ContainsKey(extension))
                    {
                        _importers[extension] = type;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading assembly from file '{file}': {ex.Message}");
            }
        }
    }

    public List<string> GetRegisteredImporters()
    {
        LoadImportersFromFolder();
        return _importers.Keys.ToList();
    }
}
