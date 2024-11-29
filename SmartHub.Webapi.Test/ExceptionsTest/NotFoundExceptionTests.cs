using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class NotFoundExceptionTests
{
    private const string ResourceName = "TestResource";
    private const int ResourceKey = 123;
    private NotFoundException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new NotFoundException(ResourceName, ResourceKey);
    }

    [TestMethod]
    public void ResourceName_Should_Return_CorrectValue()
    {
        var actualResourceName = _exception?.ResourceName;

        Assert.IsNotNull(actualResourceName);
        Assert.AreEqual(ResourceName, actualResourceName);
    }

    [TestMethod]
    public void ResourceKey_Should_Return_CorrectValue()
    {
        var actualResourceKey = _exception?.ResourceKey;

        Assert.IsNotNull(actualResourceKey);
        Assert.AreEqual(ResourceKey, actualResourceKey);
    }

    [TestMethod]
    public void ResourceKey_Should_Handle_Null()
    {
        var exception = new NotFoundException(ResourceName, null);
        var actualResourceKey = exception.ResourceKey;

        Assert.IsNull(actualResourceKey);
    }

    [TestMethod]
    public void ExceptionMessage_Should_Include_ResourceName_And_ResourceKey()
    {
        var actualMessage = _exception?.Message;

        Assert.IsNotNull(actualMessage);
        Assert.IsTrue(actualMessage.Contains(ResourceName));
        Assert.IsTrue(actualMessage.Contains(ResourceKey.ToString()));
    }
}
