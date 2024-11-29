using SmartHub.Domain;

namespace SmartHub.Webapi.Test.Domain;

[TestClass]
public class SessionUserTests
{
    [TestMethod]
    public void Token_SetAndGet_ShouldReturnExpectedValue()
    {
        var sessionUser = new SessionUser
        {
            Token = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            User = new User { Id = Guid.NewGuid(), Name = "John Doe" }
        };

        var expectedToken = Guid.NewGuid();
        sessionUser.Token = expectedToken;
        Assert.AreEqual(expectedToken, sessionUser.Token);
    }

    [TestMethod]
    public void UserId_SetAndGet_ShouldReturnExpectedValue()
    {
        var sessionUser = new SessionUser
        {
            Token = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            User = new User { Id = Guid.NewGuid(), Name = "John Doe" }
        };

        var expectedUserId = Guid.NewGuid();
        sessionUser.UserId = expectedUserId;
        Assert.AreEqual(expectedUserId, sessionUser.UserId);
    }

    [TestMethod]
    public void User_SetAndGet_ShouldReturnExpectedValue()
    {
        var sessionUser = new SessionUser
        {
            Token = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            User = new User { Id = Guid.NewGuid(), Name = "John Doe" }
        };

        var expectedUser = new User { Id = Guid.NewGuid(), Name = "Jane Doe" };
        sessionUser.User = expectedUser;
        Assert.AreEqual(expectedUser, sessionUser.User);
    }

    [TestMethod]
    public void CreatedAt_ShouldReturnDefaultValue()
    {
        var sessionUser = new SessionUser
        {
            Token = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            User = new User { Id = Guid.NewGuid(), Name = "John Doe" }
        };

        Assert.IsTrue((DateTime.UtcNow - sessionUser.CreatedAt).TotalSeconds < 1, "CreatedAt should be initialized to current UTC time.");
    }

    [TestMethod]
    public void CreatedAt_SetAndGet_ShouldReturnExpectedValue()
    {
        var sessionUser = new SessionUser
        {
            Token = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            User = new User { Id = Guid.NewGuid(), Name = "John Doe" }
        };

        var expectedDate = DateTime.UtcNow.AddHours(-1);
        sessionUser.CreatedAt = expectedDate;
        Assert.AreEqual(expectedDate, sessionUser.CreatedAt);
    }
}
