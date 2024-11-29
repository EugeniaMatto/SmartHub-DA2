using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public interface ICompanyService
{
    Guid CreateCompany(CompanyRequest request, User user);
    PaginatedResult<CompanyNoDevicesResponse> GetAllCompanies(CompanyFilterRequest filter);
    CompanyResponse GetCompany(User user);
}
