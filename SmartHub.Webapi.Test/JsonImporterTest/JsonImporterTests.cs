using JsonDeviceImporter;
using SmartHub.Domain;

namespace SmartHub.Webapi.Test.JsonImporterTest;

[TestClass]
public class HardwareFeatureNotSupportedExceptionTests
{
    private JsonImporter? _jsonImporter;

    [TestInitialize]
    public void Setup()
    {
        _jsonImporter = new JsonImporter();
    }

    [TestMethod]
    public void JsonImporter_ImportDevices_ReturnsAllDeviceTypes()
    {
        var jsonContent = @"
        {
            ""dispositivos"": [
                {
                    ""id"": ""d290f1ee-6c54-4b01-90e6-d701748f0851"",
                    ""nombre"": ""Camera 1"",
                    ""modelo"": ""Model X"",
                    ""tipo"": ""camera"",
                    ""fotos"": [
                        { ""es_principal"": true, ""path"": ""photo1.jpg"" },
                        { ""es_principal"": false, ""path"": ""photo2.jpg"" }
                    ],
                    ""person_detection"": true,
                    ""movement_detection"": false
                },
                {
                    ""id"": ""d290f1ee-6c54-4b01-90e6-d701748f0852"",
                    ""nombre"": ""Sensor 1"",
                    ""modelo"": ""Model Y"",
                    ""tipo"": ""sensor-open-close"",
                    ""fotos"": [
                        { ""es_principal"": true, ""path"": ""photo3.jpg"" }
                    ]
                },
                {
                    ""id"": ""d290f1ee-6c54-4b01-90e6-d701748f0853"",
                    ""nombre"": ""Motion Sensor 1"",
                    ""modelo"": ""Model Z"",
                    ""tipo"": ""sensor-movement"",
                    ""fotos"": [
                        { ""es_principal"": true, ""path"": ""photo4.jpg"" }
                    ]
                },
                {
                    ""id"": ""d290f1ee-6c54-4b01-90e6-d701748f0854"",
                    ""nombre"": ""Smart Lamp 1"",
                    ""modelo"": ""Model L"",
                    ""tipo"": ""smartlamp"",
                    ""fotos"": [
                        { ""es_principal"": true, ""path"": ""photo5.jpg"" }
                    ]
                }
            ]
        }";

        var tempFilePath = Path.GetTempFileName();
        File.WriteAllText(tempFilePath, jsonContent);

        var devices = _jsonImporter.ImportDevices(tempFilePath);

        Assert.AreEqual(4, devices.Count);

        var securityCam = devices[0] as SecurityCam;
        Assert.IsNotNull(securityCam);
        Assert.AreEqual(Guid.Parse("d290f1ee-6c54-4b01-90e6-d701748f0851"), securityCam.Id);
        Assert.AreEqual("Camera 1", securityCam.Name);
        Assert.AreEqual("Model X", securityCam.Model);
        Assert.AreEqual(DeviceType.SecurityCam, securityCam.Type);
        Assert.AreEqual("photo1.jpg", securityCam.Photos[0]);
        Assert.IsTrue(securityCam.CamSupportedActions.Contains(CamSupportedActions.PersonDetection));
        Assert.IsFalse(securityCam.CamSupportedActions.Contains(CamSupportedActions.MotionDetection));

        var windowSensor = devices[1];
        Assert.AreEqual(Guid.Parse("d290f1ee-6c54-4b01-90e6-d701748f0852"), windowSensor.Id);
        Assert.AreEqual("Sensor 1", windowSensor.Name);
        Assert.AreEqual("Model Y", windowSensor.Model);
        Assert.AreEqual(DeviceType.WindowSensor, windowSensor.Type);
        Assert.AreEqual("photo3.jpg", windowSensor.Photos[0]);

        var motionSensor = devices[2];
        Assert.AreEqual(Guid.Parse("d290f1ee-6c54-4b01-90e6-d701748f0853"), motionSensor.Id);
        Assert.AreEqual("Motion Sensor 1", motionSensor.Name);
        Assert.AreEqual("Model Z", motionSensor.Model);
        Assert.AreEqual(DeviceType.MotionSensor, motionSensor.Type);
        Assert.AreEqual("photo4.jpg", motionSensor.Photos[0]);

        var smartLamp = devices[3];
        Assert.AreEqual(Guid.Parse("d290f1ee-6c54-4b01-90e6-d701748f0854"), smartLamp.Id);
        Assert.AreEqual("Smart Lamp 1", smartLamp.Name);
        Assert.AreEqual("Model L", smartLamp.Model);
        Assert.AreEqual(DeviceType.SmartLamp, smartLamp.Type);
        Assert.AreEqual("photo5.jpg", smartLamp.Photos[0]);

        File.Delete(tempFilePath);
    }
}
