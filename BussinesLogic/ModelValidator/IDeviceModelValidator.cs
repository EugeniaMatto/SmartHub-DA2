using ModeloValidador.Abstracciones;

namespace SmartHub.BussinesLogic.ModelValidator;
public interface IDeviceModelValidator
{
    IModeloValidador GetValidator(string validatorType);
    List<string> GetRegisteredValidators();
}
