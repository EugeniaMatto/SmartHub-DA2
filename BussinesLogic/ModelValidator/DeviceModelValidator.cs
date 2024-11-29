using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using ModeloValidador.Abstracciones;
using SmartHub.Exceptions;

namespace SmartHub.BussinesLogic.ModelValidator;
[ExcludeFromCodeCoverage]
public class DeviceModelValidator : IDeviceModelValidator
{
    private static readonly Dictionary<string, Type> _validators = [];
    private static readonly string _folderPath = Path.GetFullPath(
        Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "dlls", "deviceModelValidators"));

    public IModeloValidador GetValidator(string validatorType)
    {
        LoadValidatorsFromFolder();
        var lowerCaseType = validatorType.ToLower();

        if (_validators.TryGetValue(lowerCaseType, out var type))
        {
            return (IModeloValidador)Activator.CreateInstance(type);
        }

        throw new InvalidValueException("ValidatorType", validatorType, new { AvailableValidators = _validators.Keys });
    }

    private void LoadValidatorsFromFolder()
    {
        if (!Directory.Exists(_folderPath))
        {
            throw new NotFoundException("Directory", _folderPath, new { Reason = "The specified folder path does not exist" });
        }

        var dllFiles = Directory.GetFiles(_folderPath, "*.dll");

        foreach (var file in dllFiles)
        {
            try
            {
                var assembly = Assembly.LoadFrom(file);
                var types = assembly.GetTypes()
                    .Where(t => typeof(IModeloValidador).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

                foreach (var type in types)
                {
                    var validatorName = type.Name.ToLower();
                    if (!_validators.ContainsKey(validatorName))
                    {
                        _validators[validatorName] = type;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading assembly from file '{file}': {ex.Message}");
            }
        }
    }

    public List<string> GetRegisteredValidators()
    {
        LoadValidatorsFromFolder();
        return _validators.Keys.ToList();
    }
}
