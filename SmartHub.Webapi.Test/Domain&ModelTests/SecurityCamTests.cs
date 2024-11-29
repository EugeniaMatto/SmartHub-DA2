using System.Text.Json;
using SmartHub.Domain;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class SecurityCamTests
{
    [TestMethod]
    public void Get_UseTypes_ShouldReturnCorrectValues()
    {
        var securityCam = new SecurityCam();
        var useTypes = new List<UseType> { UseType.Indoor, UseType.Outdoor };
        securityCam.UseTypes = useTypes;

        var result = securityCam.UseTypes;

        Assert.AreEqual(2, result.Count);
        Assert.IsTrue(result.Contains(UseType.Indoor));
        Assert.IsTrue(result.Contains(UseType.Outdoor));
    }

    [TestMethod]
    public void ToDeviceHome_ShouldReturnCorrectObject()
    {
        var securityCam = new SecurityCam
        {
            Id = Guid.NewGuid(),
            Name = "Cam 1",
            Model = "Model X",
            Photos = ["photo1.jpg", "photo2.jpg"],
            Type = DeviceType.SecurityCam,
            Description = "Security Camera",
            Company = new Company { Name = "Company XYZ" },
            UseTypes = [UseType.Indoor],
            CamSupportedActions = [CamSupportedActions.MotionDetection]
        };

        var result = new DeviceResponse(securityCam, securityCam.Company);

        Assert.AreEqual(securityCam.Id, result.GetType().GetProperty("Id")?.GetValue(result));
        Assert.AreEqual(securityCam.Name, result.GetType().GetProperty("Name")?.GetValue(result));
        Assert.AreEqual(securityCam.Model, result.GetType().GetProperty("Model")?.GetValue(result));
        Assert.AreEqual(securityCam.Photos.FirstOrDefault(), result.GetType().GetProperty("MainPhoto")?.GetValue(result));

        CollectionAssert.AreEqual(securityCam.Photos, (List<string>)result.GetType().GetProperty("Photos")?.GetValue(result));
        Assert.AreEqual(securityCam.Type.ToString(), result.GetType().GetProperty("Type")?.GetValue(result));
        Assert.AreEqual(securityCam.Description, result.GetType().GetProperty("Description")?.GetValue(result));
        Assert.AreEqual(securityCam.Company.Name, result.GetType().GetProperty("CompanyName")?.GetValue(result));

        CollectionAssert.AreEqual(securityCam.UseTypes.Select(u => u.ToString()).ToList(), (List<string>)result.GetType().GetProperty("UseTypes")?.GetValue(result));
        CollectionAssert.AreEqual(securityCam.CamSupportedActions.Select(a => a.ToString()).ToList(), (List<string>)result.GetType().GetProperty("SupportedActions")?.GetValue(result));
    }

    [TestMethod]
    public void SecurityCam_ToDevice_ReturnsCorrectDeviceObject()
    {
        var company = new Company { Id = Guid.NewGuid(), Name = "Test Company" };
        var useTypes = new List<UseType> { UseType.Indoor, UseType.Outdoor };
        var supportedActions = new List<CamSupportedActions> { CamSupportedActions.PersonDetection, CamSupportedActions.MotionDetection };

        var securityCam = new SecurityCam
        {
            Id = Guid.NewGuid(),
            Name = "Test Camera",
            Model = "Model X",
            Type = DeviceType.SecurityCam,
            Description = "Test Description",
            Company = company,
            Photos = ["photo1.jpg", "photo2.jpg"],
            UseTypes = useTypes,
            CamSupportedActions = supportedActions
        };

        var expectedDeviceObject = new
        {
            Id = securityCam.Id,
            Name = "Test Camera",
            Model = "Model X",
            MainPhoto = "photo1.jpg",
            Photos = new List<string> { "photo1.jpg", "photo2.jpg" },
            Type = "SecurityCam",
            Description = "Test Description",
            CompanyName = "Test Company",
            UseTypes = new List<string> { "Indoor", "Outdoor" },
            SupportedActions = new List<string> { "PersonDetection", "MotionDetection" }
        };

        var deviceObject = new DeviceResponse(securityCam, securityCam.Company);

        Assert.AreEqual(
            JsonSerializer.Serialize(expectedDeviceObject),
            JsonSerializer.Serialize(deviceObject));
    }
}
