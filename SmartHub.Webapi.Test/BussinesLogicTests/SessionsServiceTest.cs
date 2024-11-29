using System.Linq.Expressions;
using Moq;
using SmartHub.BussinesLogic;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;

namespace SmartHub.Webapi.Test.BussinesLogicTests;
[TestClass]
public sealed class SessionsServiceTest
{
    private SessionsService? _sessionsService;
    private Mock<IRepository<SessionUser>>? _sessionsRepositoryMock;

    [TestInitialize]
    public void Setup()
    {
        _sessionsRepositoryMock = new Mock<IRepository<SessionUser>>();
        _sessionsService = new SessionsService(_sessionsRepositoryMock.Object);
    }

    [TestMethod]
    public void GetUserByToken_ShouldReturnUser_WhenSessionExists()
    {
        var token = Guid.NewGuid().ToString();
        var tokenGuid = Guid.Parse(token);
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        var session = new SessionUser { Token = tokenGuid, User = user };

        _sessionsRepositoryMock.Setup(repo => repo.Get(
            It.IsAny<Expression<Func<SessionUser, bool>>>(),
            It.IsAny<Expression<Func<SessionUser, object>>[]>()))
            .Returns(session);

        var result = _sessionsService.GetUserByToken(token);

        Assert.AreEqual(user, result);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void GetUserByToken_ShouldThrowException_WhenSessionDoesNotExist()
    {
        var token = Guid.NewGuid().ToString();

        _sessionsRepositoryMock.Setup(repo => repo.Get(
            It.IsAny<Expression<Func<SessionUser, bool>>>(),
            It.IsAny<Expression<Func<SessionUser, object>>[]>()))
            .Returns((SessionUser)null);

        _sessionsService.GetUserByToken(token);
    }

    [TestMethod]
    [ExpectedException(typeof(NotFoundException))]
    public void GetUserByToken_ShouldThrowException_WhenUserDoesNotExist()
    {
        var token = Guid.NewGuid().ToString();
        var tokenGuid = Guid.Parse(token);
        var session = new SessionUser { Token = tokenGuid, User = null };

        _sessionsRepositoryMock.Setup(repo => repo.Get(
            It.IsAny<Expression<Func<SessionUser, bool>>>(),
            It.IsAny<Expression<Func<SessionUser, object>>[]>()))
            .Returns(session);

        _sessionsService.GetUserByToken(token);
    }

    [TestMethod]
    public void AddSession_ShouldAddSessionAndReturnToken()
    {
        var user = new User { Id = Guid.NewGuid(), Name = "Test User" };
        var sessionToken = Guid.NewGuid();

        var session = new SessionUser { User = user, UserId = user.Id, Token = sessionToken };

        _sessionsRepositoryMock.Setup(repo => repo.Add(It.IsAny<SessionUser>()));

        var result = _sessionsService.AddSession(user);

        _sessionsRepositoryMock.Verify(repo => repo.Add(It.IsAny<SessionUser>()), Times.Once);
    }

    [TestMethod]
    public void ExpiredSession_ShouldThrowException_WhenSessionDoesNotExist()
    {
        var token = Guid.NewGuid().ToString();
        var tokenGuid = Guid.Parse(token);

        _sessionsRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<SessionUser, bool>>>()))
            .Returns((SessionUser)null);

        var res = _sessionsService.ExpiredSession(token);
        Assert.IsTrue(res);
    }

    [TestMethod]
    public void ExpiredSession_ShouldReturnTrue_WhenSessionIsExpired()
    {
        var token = Guid.NewGuid().ToString();
        var tokenGuid = Guid.Parse(token);
        var user = new User();
        var session = new SessionUser { Token = tokenGuid, CreatedAt = DateTime.UtcNow.AddHours(-3), User = user };

        _sessionsRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<SessionUser, bool>>>()))
            .Returns(session);

        var result = _sessionsService.ExpiredSession(token);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ExpiredSession_ShouldReturnFalse_WhenSessionIsNotExpired()
    {
        var token = Guid.NewGuid().ToString();
        var tokenGuid = Guid.Parse(token);
        var user = new User();
        var session = new SessionUser { Token = tokenGuid, CreatedAt = DateTime.UtcNow.AddHours(-1), User = user };

        _sessionsRepositoryMock.Setup(repo => repo.GetOrDefault(It.IsAny<Expression<Func<SessionUser, bool>>>()))
            .Returns(session);

        var result = _sessionsService.ExpiredSession(token);

        Assert.IsFalse(result);
    }
}
