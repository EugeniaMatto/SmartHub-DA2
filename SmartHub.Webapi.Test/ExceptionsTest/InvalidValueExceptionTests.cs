using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class InvalidValueExceptionTests
{
    private const string FieldName = "TestField";
    private const string ProvidedValue = "InvalidValue";
    private InvalidValueException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new InvalidValueException(FieldName, ProvidedValue);
    }

    [TestMethod]
    public void FieldName_Should_Return_CorrectValue()
    {
        var actualFieldName = _exception?.FieldName;

        Assert.IsNotNull(actualFieldName);
        Assert.AreEqual(FieldName, actualFieldName);
    }

    [TestMethod]
    public void ProvidedValue_Should_Return_CorrectValue()
    {
        var actualProvidedValue = _exception?.ProvidedValue;

        Assert.IsNotNull(actualProvidedValue);
        Assert.AreEqual(ProvidedValue, actualProvidedValue);
    }

    [TestMethod]
    public void ProvidedValue_Should_Handle_Null()
    {
        var exception = new InvalidValueException(FieldName, null);
        var actualProvidedValue = exception.ProvidedValue;
        Assert.IsNull(actualProvidedValue);
    }

    [TestMethod]
    public void ExceptionMessage_Should_Include_FieldName_And_ProvidedValue()
    {
        var actualMessage = _exception?.Message;
        Assert.IsNotNull(actualMessage);
        Assert.IsTrue(actualMessage.Contains(FieldName));
        Assert.IsTrue(actualMessage.Contains(ProvidedValue));
    }
}
