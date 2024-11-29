using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;

public interface IAdministratorService
{
    User CreateAdminAccount(AdministratorRequest newAdmin);
    void DeleteAdminAccount(Guid accountId);
}
