using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class UbicationGeoTests
{
    [TestMethod]
    public void ShouldInitializeLatAndLon()
    {
        var ubicationGeo = new UbicationGeo(34, 56);
        Assert.AreEqual(34, ubicationGeo.Lat);
        Assert.AreEqual(56, ubicationGeo.Lon);
    }

    [TestMethod]
    public void ShouldAllowNullableLatAndLon()
    {
        var ubicationGeo = new UbicationGeo(34, 56);
        ubicationGeo.Lat = null;
        ubicationGeo.Lon = null;
        Assert.IsNull(ubicationGeo.Lat);
        Assert.IsNull(ubicationGeo.Lon);
    }

    [TestMethod]
    public void EmptyConstructor_ShouldInitializeLatAndLonToZero()
    {
        var ubicationGeo = new UbicationGeo();
        Assert.AreEqual(0, ubicationGeo.Lat);
        Assert.AreEqual(0, ubicationGeo.Lon);
    }
}
