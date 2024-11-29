using SmartHub.Domain;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface IUserService
{
    User Login(string username, string password);
    Guid AddAccount(User newUser);
    bool DeleteAccount(User user, Role role);
    void UpdateAccount(User user);
    User GetById(string userId);
    List<UserHomeResponse> GetHomes(User user);
    UserResponse ChangeProfilePhoto(User user, string photo);
    List<string> GetEmails(Role role);
}
