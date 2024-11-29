using SmartHub.Domain;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface ISessionsService
{
    User GetUserByToken(string token);
    SessionResponse AddSession(User user);
    bool ExpiredSession(string token);
}
