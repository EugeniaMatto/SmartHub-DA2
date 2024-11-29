using System.Data;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;
namespace SmartHub.BussinesLogic;
public class CompanyService : ICompanyService
{
    private readonly IRepository<Company> _companyRepository;

    public CompanyService(IRepository<Company> companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public Guid CreateCompany(CompanyRequest request, User user)
    {
        if (_companyRepository.GetOrDefault(c => c.OwnerId == user.Id) == null)
        {
            var company = new Company(request.Name, request.LogoUrl, user, request.Rut);
            _companyRepository.Add(company);
            return company.Id;
        }
        else
        {
            throw new AlreadyExistsException("The user is already the owner of a company.", new { UserId = user.Id, ExistingCompany = _companyRepository.GetOrDefault(c => c.OwnerId == user.Id) });
        }
    }

    public PaginatedResult<CompanyNoDevicesResponse> GetAllCompanies(CompanyFilterRequest filter)
    {
        var query = _companyRepository.GetAll(null, c => c.Owner)
            .Where(c =>
                (string.IsNullOrEmpty(filter.CompanyName) || c.Name.ToLower().Contains(filter.CompanyName.ToLower())) &&
                (string.IsNullOrEmpty(filter.FullName) ||
                 (c.Owner.Name + " " + c.Owner.Surname).ToLower().Contains(filter.FullName.ToLower())));

        var total = query.Count();

        var items = query.Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize)
            .Select(c => new CompanyNoDevicesResponse
            {
                Name = c.Name,
                Logo = c.LogoURL,
                Rut = c.Rut,
                Owner = c.Owner.Name + " " + c.Owner.Surname,
                OwnerEmail = c.Owner.Email,
                DeviceModelValidator = c.Validator
            }).ToList();

        return new PaginatedResult<CompanyNoDevicesResponse>(
            items,
            total,
            filter.PageNumber,
            filter.PageSize);
    }

    public CompanyResponse GetCompany(User user)
    {
        var company = _companyRepository.Get(
            c => c.OwnerId == user.Id,
            c => c.Devices);

        return new CompanyResponse(
            company.Name,
            company.LogoURL,
            company.Rut,
            company.Devices.Select(device => new DeviceResponse(device, company)).ToList(),
            company.Validator);
    }
}
