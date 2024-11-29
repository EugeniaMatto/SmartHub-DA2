using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface IAccountService
{
    PaginatedResult<AccountResponse> GetAll(AccountFilterRequest filter);
}
