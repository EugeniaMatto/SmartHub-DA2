using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
using SmartHub.WebApi.Controllers;

namespace SmartHub.Webapi.Test.ControllersTests;
[TestClass]
public class AccountsControllerTests
{
    private Mock<IAccountService>? _mockAccountService;
    private AccountsController? _accountsController;

    [TestInitialize]
    public void Setup()
    {
        _mockAccountService = new Mock<IAccountService>();
        _accountsController = new AccountsController(_mockAccountService.Object);
    }

    [TestMethod]
    public void GetAccounts_ShouldReturnOk_WithPaginatedAccounts()
    {
        var accountsList = new List<AccountResponse>
    {
        new AccountResponse(Guid.NewGuid(), "John", "Doe", "John Doe", ["Administrator"], DateTime.Now, "john.doe@example.com"),
        new AccountResponse(Guid.NewGuid(), "Jane", "Smith", "Jane Smith", ["User"], DateTime.Now, "jane.smith@example.com")
    };

        var paginatedResult = new PaginatedResult<AccountResponse>(
            accountsList,
            2,
            1,
            10);

        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockAccountService.Setup(service => service.GetAll(filter))
            .Returns(paginatedResult);

        var result = _accountsController.GetAccounts(filter) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.IsInstanceOfType(result.Value, typeof(PaginatedResult<AccountResponse>));
        var returnedResult = (PaginatedResult<AccountResponse>)result.Value;
        Assert.AreEqual(2, returnedResult.Items.Count);
        Assert.AreEqual(1, returnedResult.PageNumber);
        Assert.AreEqual(10, returnedResult.PageSize);
        Assert.AreEqual(2, returnedResult.TotalCount);
    }

    [TestMethod]
    public void GetAccounts_ShouldReturnOk_WithAccounts()
    {
        var paginatedResult = new PaginatedResult<AccountResponse>(
            [],
            2,
            1,
            10);

        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockAccountService.Setup(service => service.GetAll(filter))
            .Returns(paginatedResult);

        var result = _accountsController.GetAccounts(filter) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(paginatedResult, result.Value);
    }

    [TestMethod]
    public void GetAccounts_ShouldReturnOk_WithFilteredAccountsByRole()
    {
        var accoutnId = Guid.NewGuid();
        var accountModel = new AccountResponse(
            id: accoutnId,
            name: "Jane",
            surname: "Smith",
            fullName: "Jane Smith",
            roles: ["Admin"],
            createdAt: DateTime.Now,
            email: "jane.smith@example.com");
        var paginatedResult = new PaginatedResult<AccountResponse>(
            [accountModel],
            2,
            1,
            10);

        var filter = new AccountFilterRequest
        {
            Role = "Admin",
            FullName = null,
            PageNumber = 1,
            PageSize = 10
        };

        _mockAccountService.Setup(service => service.GetAll(filter))
            .Returns(paginatedResult);

        var result = _accountsController.GetAccounts(filter) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Smith", accountModel.Surname);
        Assert.IsTrue(DateTime.Now > accountModel.CreatedAt);
        Assert.AreEqual(paginatedResult, result.Value);
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual("Smith", accountModel.Surname);
        Assert.AreEqual("Jane Smith", accountModel.FullName);
        Assert.AreEqual("jane.smith@example.com", accountModel.Email);
        Assert.AreEqual("Jane", accountModel.Name);
        Assert.AreEqual(accoutnId, accountModel.Id);
        Assert.IsTrue(accountModel.Roles.Contains("Admin"));
        Assert.IsTrue(DateTime.Now > accountModel.CreatedAt);
        Assert.AreEqual(paginatedResult, result.Value);
    }

    [TestMethod]
    public void GetAccounts_ShouldReturnOk_WithFilteredAccountsByFullName()
    {
        var paginatedResult = new PaginatedResult<AccountResponse>(
            [
                new AccountResponse(Guid.NewGuid(), "John", "Doe", "John Doe", ["User"], DateTime.Now, "john.doe@example.com")
            ],
            1,
            1,
            10);

        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = "John Doe",
            PageNumber = 1,
            PageSize = 10
        };

        _mockAccountService.Setup(service => service.GetAll(filter))
            .Returns(paginatedResult);

        var result = _accountsController.GetAccounts(filter) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(paginatedResult, result.Value);
    }

    [TestMethod]
    public void GetAccounts_ShouldReturnOk_WithPagination()
    {
        var paginatedResult = new PaginatedResult<AccountResponse>(
            [new AccountResponse(Guid.NewGuid(), "John", "Doe", "John Doe", ["User"], DateTime.Now, "john.doe@example.com"), new AccountResponse(Guid.NewGuid(), "Jane", "Smith", "Jane Smith", ["Admin"], DateTime.Now, "jane.smith@example.com")],
            2,
            2,
            1);

        var filter = new AccountFilterRequest
        {
            Role = null,
            FullName = null,
            PageNumber = 1,
            PageSize = 2
        };

        _mockAccountService.Setup(service => service.GetAll(filter))
            .Returns(paginatedResult);

        var result = _accountsController.GetAccounts(filter) as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
        Assert.AreEqual(paginatedResult, result.Value);
    }
}
