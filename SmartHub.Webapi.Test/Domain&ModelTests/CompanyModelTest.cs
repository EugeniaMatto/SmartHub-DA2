using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class CompanyModelTests
{
    [TestMethod]
    public void Name_SetAndGet_ShouldReturnExpectedValue()
    {
        var company = new CompanyNoDevicesResponse();
        company.Name = "My Company";
        Assert.AreEqual("My Company", company.Name);
    }

    [TestMethod]
    public void Logo_SetAndGet_ShouldReturnExpectedValue()
    {
        var company = new CompanyNoDevicesResponse();
        company.Logo = "logo.png";
        Assert.AreEqual("logo.png", company.Logo);
    }

    [TestMethod]
    public void Rut_SetAndGet_ShouldReturnExpectedValue()
    {
        var company = new CompanyNoDevicesResponse();
        company.Rut = "123456789";
        Assert.AreEqual("123456789", company.Rut);
    }

    [TestMethod]
    public void Owner_SetAndGet_ShouldReturnExpectedValue()
    {
        var company = new CompanyNoDevicesResponse();
        company.Owner = "John Doe";
        Assert.AreEqual("John Doe", company.Owner);
    }

    [TestMethod]
    public void OwnerEmail_SetAndGet_ShouldReturnExpectedValue()
    {
        var company = new CompanyNoDevicesResponse();
        company.OwnerEmail = "johndoe@example.com";
        Assert.AreEqual("johndoe@example.com", company.OwnerEmail);
    }
}
