using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;
public interface IHomeOwnerService
{
    User CreateHomeOwnerAccount(HomeOwnerRequest newHomeOwner);
    void AddPermissionToUser(User user);
    List<string> GetUserEmails();
}
