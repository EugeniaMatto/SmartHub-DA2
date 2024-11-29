using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class SmartHubBaseExceptionTests
{
    private const string Message = "Test exception message.";
    private const string ErrorCode = "TEST_ERROR_CODE";
    private readonly object? additionalData = new { Key = "Value" };
    private readonly Exception? innerException = new InvalidOperationException("Inner exception message");
    private SmartHubBaseException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new TestSmartHubBaseException(Message, ErrorCode, additionalData, innerException);
    }

    [TestMethod]
    public void ErrorCode_Should_Return_CorrectValue()
    {
        var actualErrorCode = _exception?.ErrorCode;
        Assert.IsNotNull(actualErrorCode);
        Assert.AreEqual(ErrorCode, actualErrorCode);
    }

    [TestMethod]
    public void AdditionalData_Should_Return_CorrectValue()
    {
        var actualAdditionalData = _exception?.AdditionalData;
        Assert.IsNotNull(actualAdditionalData);
        Assert.AreEqual(additionalData, actualAdditionalData);
    }

    [TestMethod]
    public void Message_Should_Return_CorrectValue()
    {
        var actualMessage = _exception?.Message;
        Assert.IsNotNull(actualMessage);
        Assert.AreEqual(Message, actualMessage);
    }

    [TestMethod]
    public void InnerException_Should_Return_CorrectValue()
    {
        var actualInnerException = _exception?.InnerException;
        Assert.IsNotNull(actualInnerException);
        Assert.AreEqual(innerException, actualInnerException);
    }
}

public class TestSmartHubBaseException : SmartHubBaseException
{
    public TestSmartHubBaseException(string message, string errorCode, object? additionalData = null, Exception? innerException = null)
        : base(message, errorCode, additionalData, innerException)
    {
    }
}
