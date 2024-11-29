using AlphanumericModelValidator;
using ModeloValidador.Abstracciones;

namespace SmartHub.Webapi.Test.DeviceModelValidatorTest;
[TestClass]
public class AlphanumericValidatorTests
{
    private AlphanumericValidator? _validator;

    [TestInitialize]
    public void Setup()
    {
        _validator = new AlphanumericValidator();
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenValueLengthIsNotSix()
    {
        var modelo = new Modelo { Value = "ABC12" };
        var result = _validator.EsValido(modelo);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenFirstThreeCharactersAreNotLetters()
    {
        var modelo = new Modelo { Value = "A1C123" };
        var result = _validator.EsValido(modelo);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnFalse_WhenLastThreeCharactersAreNotDigits()
    {
        var modelo = new Modelo { Value = "ABC12E" };
        var result = _validator.EsValido(modelo);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void EsValido_ShouldReturnTrue_WhenValueIsValidAlphanumeric()
    {
        var modelo = new Modelo { Value = "ABC123" };
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
}
