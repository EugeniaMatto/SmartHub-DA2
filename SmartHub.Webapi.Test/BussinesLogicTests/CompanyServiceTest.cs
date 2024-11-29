using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.Webapi.Test.BussinesLogicTests;

[TestClass]
public class CompanyServiceTest
{
    private CompanyService? _companyService;
    private Mock<IRepository<Company>>? _mockCompanyRepository;

    [TestInitialize]
    public void Setup()
    {
        _mockCompanyRepository = new Mock<IRepository<Company>>();
        _companyService = new CompanyService(_mockCompanyRepository.Object);
    }

    [TestMethod]
    public void CreateCompany_ShouldCreateCompany_WhenDataIsValid()
    {
        var request = new CompanyRequest
        {
            Name = "Test Company",
            LogoUrl = "http://example.com/logo.png",
            Rut = "12345678-9"
        };

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "securepassword",
            Roles = [Role.CompanyOwner],
        };

        Company createdCompany = null;

        _mockCompanyRepository.Setup(repo => repo.Add(It.IsAny<Company>()))
            .Callback<Company>(company => createdCompany = company);

        var result = _companyService.CreateCompany(request, user);

        Assert.IsNotNull(createdCompany);
        Assert.AreEqual(request.Name, createdCompany.Name);
        Assert.AreEqual(request.LogoUrl, createdCompany.LogoURL);
        Assert.AreEqual(request.Rut, createdCompany.Rut);
        Assert.AreEqual(user, createdCompany.Owner);
        Assert.AreNotEqual(Guid.Empty, result);
    }

    [TestMethod]
    public void CreateCompany_ShouldThrowException_WhenOwnerAlreadyExists()
    {
        var request = new CompanyRequest
        {
            Name = "Test Company",
            LogoUrl = "http://example.com/logo.png",
            Rut = "12345678-9"
        };

        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com",
            Password = "securepassword",
            Roles = [Role.CompanyOwner],
        };

        _mockCompanyRepository.Setup(repo => repo.Add(It.IsAny<Company>()))
            .Throws(new Exception("Already the owner of a company"));

        Assert.ThrowsException<Exception>(() => _companyService.CreateCompany(request, user));
    }

    [TestMethod]
    public void GetAllCompanies_ShouldReturnPaginatedResults_WhenNoFiltersAreApplied()
    {
        var companies = new List<Company>
    {
        new Company("Test Company 1", "http://example.com/logo1.png", new User { Name = "John", Surname = "Doe", Email = "john.doe@example.com" }, "12345678-1"),
        new Company("Test Company 2", "http://example.com/logo2.png", new User { Name = "Jane", Surname = "Smith", Email = "jane.doe@example.com" }, "12345678-2")
    };

        var filter = new CompanyFilterRequest
        {
            CompanyName = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 2
        };

        _mockCompanyRepository.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Company, object>>[]>())).Returns(companies.AsQueryable());

        var result = _companyService.GetAllCompanies(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Items.Count);
        Assert.AreEqual(2, result.TotalCount);
        Assert.AreEqual(1, result.PageNumber);
        Assert.AreEqual(2, result.PageSize);
    }

    [TestMethod]
    public void GetAllCompanies_ShouldFilterByCompanyName_WhenProvided()
    {
        var companies = new List<Company>
    {
        new Company("Test Company 1", "http://example.com/logo1.png", new User { Name = "John", Surname = "Doe", Email = "john.doe@example.com" }, "12345678-1"),
        new Company("Sample Company", "http://example.com/logo2.png", new User { Name = "Jane", Surname = "Smith", Email = "jane.doe@example.com" }, "12345678-2"),
        new Company("Company Test", "http://example.com/logo3.png", new User { Name = "Alice", Surname = "Johnson", Email = "alice.johnson@example.com" }, "12345678-3")
    };

        var filter = new CompanyFilterRequest
        {
            CompanyName = "Test",
            FullName = null,
            PageNumber = 1,
            PageSize = 2
        };

        _mockCompanyRepository.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Company, object>>[]>())).Returns(companies.AsQueryable());

        var result = _companyService.GetAllCompanies(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Items.Count);
        Assert.AreEqual(2, result.TotalCount);
        Assert.IsTrue(result.Items.Any(c => c.Name.Contains("Test Company 1")));
        Assert.IsTrue(result.Items.Any(c => c.Name.Contains("Company Test")));
    }

    [TestMethod]
    public void GetAllCompanies_ShouldFilterByFullName_WhenProvided()
    {
        var user1 = new User { Name = "John", Surname = "Doe", Email = "john.doe@example.com" };
        var user2 = new User { Name = "Jane", Surname = "Smith", Email = "jane.doe@example.com" };
        var companies = new List<Company>
    {
        new Company("Company A", "http://example.com/logoA.png", user1, "12345678-1"),
        new Company("Company B", "http://example.com/logoB.png", user2, "12345678-2")
    };

        var filter = new CompanyFilterRequest
        {
            CompanyName = null,
            FullName = "Jane Smith",
            PageNumber = 1,
            PageSize = 2
        };

        _mockCompanyRepository.Setup(repo => repo.GetAll(null, It.IsAny<Expression<Func<Company, object>>[]>())).Returns(companies.AsQueryable());

        var result = _companyService.GetAllCompanies(filter);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Items.Count);
        Assert.AreEqual("Company B", result.Items[0].Name);
    }

    [TestMethod]
    public void GetCompany_ShouldReturnCompanyResponse_WhenCompanyExists()
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = "John",
            Surname = "Doe",
            Email = "john.doe@example.com"
        };

        var device = new Device
        {
            Id = Guid.NewGuid(),
            Name = "Light Bulb",
            Model = "LB-100",
            Type = DeviceType.MotionSensor,
            Description = "A smart light bulb that can be controlled remotely.",
            Photos = ["photo1", "photo2"],
            Company = new Company()
            { Name = "AB" }
        };

        var devices = new List<Device>
    {
        device,
        device
    };

        var company = new Company
        {
            Id = Guid.NewGuid(),
            Name = "Test Company",
            LogoURL = "http://example.com/logo.png",
            Rut = "12345678-9",
            Owner = user,
            OwnerId = user.Id,
            Devices = devices
        };

        _mockCompanyRepository.Setup(repo => repo.Get(It.IsAny<Expression<Func<Company, bool>>>(), It.IsAny<Expression<Func<Company, object>>[]>()))
                              .Returns(company);

        var result = _companyService.GetCompany(user);

        Assert.IsNotNull(result);
        Assert.AreEqual(company.Name, result.Name);
        Assert.AreEqual(company.LogoURL, result.LogoURL);
        Assert.AreEqual(company.Rut, result.Rut);
        Assert.AreEqual(company.Devices.Count, result.Devices.Count);
        Assert.AreEqual(new DeviceResponse(devices[0], devices[0].Company).ToString(), result.Devices[0].ToString());
    }
}
