using SmartHub.Domain;
using SmartHub.Model.Request;

namespace SmartHub.BussinesLogic;
public interface ICompanyOwnerService
{
    User CreateCompanyOwnerAccount(CompanyOwnerRequest newAccount);
}
