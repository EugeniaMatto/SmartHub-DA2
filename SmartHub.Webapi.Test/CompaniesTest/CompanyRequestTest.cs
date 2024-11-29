using SmartHub.Model.Request;

namespace SmartHub.Webapi.Test.CompaniesTest;
[TestClass]
public class CompanyRequestTests
{
    [TestMethod]
    public void ShouldSetPropertiesCorrectly()
    {
        var request = new CompanyRequest
        {
            Name = "Test Company",
            LogoUrl = "http://example.com/logo.png",
            Rut = "12345678-9"
        };

        Assert.AreEqual("Test Company", request.Name);
        Assert.AreEqual("http://example.com/logo.png", request.LogoUrl);
        Assert.AreEqual("12345678-9", request.Rut);
    }
}
