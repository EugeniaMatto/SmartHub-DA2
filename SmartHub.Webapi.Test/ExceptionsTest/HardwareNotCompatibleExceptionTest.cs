using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class HardwareNotCompatibleExceptionTests
{
    private const string HardwareId = "HW98765";
    private const string ExpectedType = "Sensor";
    private HardwareNotCompatibleException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new HardwareNotCompatibleException(HardwareId, ExpectedType);
    }

    [TestMethod]
    public void HardwareId_Should_Return_CorrectValue()
    {
        var actualHardwareId = _exception?.HardwareId;

        Assert.IsNotNull(actualHardwareId);
        Assert.AreEqual(HardwareId, actualHardwareId);
    }

    [TestMethod]
    public void ExceptionMessage_Should_Include_HardwareId_And_ExpectedType()
    {
        var actualMessage = _exception?.Message;

        Assert.IsNotNull(actualMessage);
        Assert.IsTrue(actualMessage.Contains(HardwareId));
        Assert.IsTrue(actualMessage.Contains(ExpectedType));
    }
}
