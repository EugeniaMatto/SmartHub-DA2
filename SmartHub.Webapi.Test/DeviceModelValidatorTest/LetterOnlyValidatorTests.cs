using LetterOnlyModelValidator;
using ModeloValidador.Abstracciones;

namespace SmartHub.Webapi.Test.DeviceModelValidatorTest;
[TestClass]
public class LetterOnlyValidatorTests
{
    private LetterOnlyValidator? _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new LetterOnlyValidator();
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenValueLengthIsNotSix()
    {
        var modelo = new Modelo { Value = "ABCDE" };

        var result = _validator.EsValido(modelo);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenValueContainsNonLetterCharacters()
    {
        var modelo = new Modelo { Value = "ABCD1E" };

        var result = _validator.EsValido(modelo);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnTrue_WhenValueContainsOnlyLettersAndLengthIsSix()
    {
        var modelo = new Modelo { Value = "ABCDEF" };

        var result = _validator.EsValido(modelo);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenValueIsEmpty()
    {
        var modelo = new Modelo { Value = string.Empty };

        var result = _validator.EsValido(modelo);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenValueContainsSpecialCharacters()
    {
        var modelo = new Modelo { Value = "ABC@EF" };

        var result = _validator.EsValido(modelo);

        Assert.IsFalse(result);
    }
}
