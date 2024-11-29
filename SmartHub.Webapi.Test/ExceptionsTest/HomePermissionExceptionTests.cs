using SmartHub.Exceptions;

namespace SmartHub.WebApi.Test.ExceptionsTest;

[TestClass]
public class HomePermissionExceptionTests
{
    private readonly Guid _userId = Guid.NewGuid();
    private const string Permission = "ACCESS_HOME";
    private readonly Guid _homeId = Guid.NewGuid();
    private HomePermissionException? _exception;

    [TestInitialize]
    public void Setup()
    {
        _exception = new HomePermissionException(_userId, Permission, _homeId);
    }

    [TestMethod]
    public void UserId_Should_Return_CorrectValue()
    {
        var actualUserId = _exception?.UserId;

        Assert.IsNotNull(actualUserId);
        Assert.AreEqual(_userId, actualUserId);
    }

    [TestMethod]
    public void Permission_Should_Return_CorrectValue()
    {
        var actualPermission = _exception?.Permission;

        Assert.IsNotNull(actualPermission);
        Assert.AreEqual(Permission, actualPermission);
    }

    [TestMethod]
    public void HomeId_Should_Return_CorrectValue()
    {
        var actualHomeId = _exception?.HomeId;

        Assert.IsNotNull(actualHomeId);
        Assert.AreEqual(_homeId, actualHomeId);
    }

    [TestMethod]
    public void ExceptionMessage_Should_Include_UserId_Permission_And_HomeId()
    {
        var actualMessage = _exception?.Message;

        Assert.IsNotNull(actualMessage);
        Assert.IsTrue(actualMessage.Contains(_userId.ToString()));
        Assert.IsTrue(actualMessage.Contains(Permission));
        Assert.IsTrue(actualMessage.Contains(_homeId.ToString()));
    }
}
