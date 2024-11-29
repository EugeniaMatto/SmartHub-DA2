using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class CompanyTest
{
    [TestMethod]
    public void ShouldSetPropertiesCorrectly()
    {
        var user = new User { Id = Guid.NewGuid(), Email = "owner@example.com" };
        var company = new Company("Test Company", "http://example.com/logo.png", user, "12345678-9");

        Assert.AreEqual("Test Company", company.Name);
        Assert.AreEqual("http://example.com/logo.png", company.LogoURL);
        Assert.AreEqual("12345678-9", company.Rut);
        Assert.AreEqual(user.Email, company.Owner.Email);
        Assert.AreEqual(user.Id, company.OwnerId);
    }

    [TestMethod]
    public void GetSetDevices()
    {
        var user = new User { Id = Guid.NewGuid(), Email = "owner@example.com" };
        var company = new Company("Test Company", "http://example.com/logo.png", user, "12345678-9");
        company.Devices = [new Device(), new Device()];

        Assert.AreEqual(company.Devices.Count, 2);
    }
}
