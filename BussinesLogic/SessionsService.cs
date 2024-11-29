using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public sealed class SessionsService : ISessionsService
{
    private readonly IRepository<SessionUser> _sessionsRepository;

    public SessionsService(
        IRepository<SessionUser> sessionsRepository)
    {
        _sessionsRepository = sessionsRepository;
    }

    public User GetUserByToken(string token)
    {
        var tokenGuid = Guid.Parse(token);
        var session = _sessionsRepository.Get(
            s => s.Token == tokenGuid,
            s => s.User);

        return session == null ? throw new NotFoundException("Session", token) : session.User ?? throw new NotFoundException("User", token);
    }

    public SessionResponse AddSession(User user)
    {
        var session = new SessionUser { User = user, UserId = user.Id };
        _sessionsRepository.Add(session);
        session.User.Password = string.Empty;
        return ToSessionUserResponse(session);
    }

    private static SessionResponse ToSessionUserResponse(SessionUser session)
    {
        return new SessionResponse(
            session.UserId,
            session.Token,
            session.User.Roles.ConvertAll(r => r.ToString()),
            session.User.Name,
            session.User.Surname,
            session.User.Email,
            session.User.ProfilePhoto,
            session.CreatedAt);
    }

    public bool ExpiredSession(string token)
    {
        var tokenGuid = Guid.Parse(token);
        var session = _sessionsRepository.GetOrDefault(s => s.Token == tokenGuid);
        return session == null || DateTime.UtcNow > session.CreatedAt.AddHours(2);
    }
}
