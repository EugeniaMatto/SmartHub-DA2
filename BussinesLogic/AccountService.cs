using System.Data;
using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class AccountService : IAccountService
{
    private readonly IRepository<User> _userRepository;

    public AccountService(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    public PaginatedResult<AccountResponse> GetAll(AccountFilterRequest filter)
    {
        Role? roleEnum = null;

        if (!string.IsNullOrEmpty(filter.Role))
        {
            if (!Enum.TryParse(filter.Role, true, out Role parsedRole))
            {
                throw new InvalidValueException(filter.Role, new { ProvidedRole = filter.Role });
            }

            roleEnum = parsedRole;
        }

        var query = _userRepository.GetAll()
            .Where(u =>
                (!roleEnum.HasValue || u.Roles.Any(r => r == roleEnum)) &&
                (string.IsNullOrEmpty(filter.FullName) ||
                 (u.Name + " " + u.Surname).Contains(filter.FullName)));

        var totalAccounts = query.Count();

        var accounts = query
            .Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .Select(u => new AccountResponse(
                u.Id,
                u.Name,
                u.Surname,
                $"{u.Name} {u.Surname}",
                u.Roles.Select(r => r.ToString()).ToList(),
                u.CreatedAt,
                u.Email))
            .ToList();

        return new PaginatedResult<AccountResponse>(
            accounts,
            totalAccounts,
            filter.PageNumber,
            filter.PageSize);
    }
}
