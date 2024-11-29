using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.Domain;
[TestClass]
public class RequestHomeUserTests
{
    [TestMethod]
    public void ShouldInitializeWithNullEmail()
    {
        var requestHomeUser = new HomeUserRequest();
        var email = requestHomeUser.Email;
        Assert.IsNull(email);
    }

    [TestMethod]
    public void ShouldSetEmailCorrectly()
    {
        var requestHomeUser = new HomeUserRequest();
        var expectedEmail = "test@example.com";
        requestHomeUser.Email = expectedEmail;
        Assert.AreEqual(expectedEmail, requestHomeUser.Email);
    }

    [TestMethod]
    public void ShouldAllowSettingEmailToNull()
    {
        var requestHomeUser = new HomeUserRequest
        {
            Email = "initial@example.com"
        };
        requestHomeUser.Email = null;
        Assert.IsNull(requestHomeUser.Email);
    }
}
