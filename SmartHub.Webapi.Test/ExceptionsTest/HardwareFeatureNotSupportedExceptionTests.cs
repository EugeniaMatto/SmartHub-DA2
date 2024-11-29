using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class HardwareFeatureNotSupportedExceptionTests
{
    private const string HardwareId = "HW12345";
    private const string Feature = "UnsupportedFeature";
    private HardwareFeatureNotSupportedException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new HardwareFeatureNotSupportedException(HardwareId, Feature);
    }

    [TestMethod]
    public void HardwareId_Should_Return_CorrectValue()
    {
        var actualHardwareId = _exception?.HardwareId;

        Assert.IsNotNull(actualHardwareId);
        Assert.AreEqual(HardwareId, actualHardwareId);
    }

    [TestMethod]
    public void Feature_Should_Return_CorrectValue()
    {
        var actualFeature = _exception?.Feature;

        Assert.IsNotNull(actualFeature);
        Assert.AreEqual(Feature, actualFeature);
    }

    [TestMethod]
    public void ExceptionMessage_Should_Include_HardwareId_And_Feature()
    {
        var actualMessage = _exception?.Message;

        Assert.IsNotNull(actualMessage);
        Assert.IsTrue(actualMessage.Contains(HardwareId));
        Assert.IsTrue(actualMessage.Contains(Feature));
    }
}
