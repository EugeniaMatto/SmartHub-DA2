using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IRepository<UserHomePermission> _userHomePermissionRepository;
    private readonly IHomeService _homeService;

    public UserService(IRepository<User> userRepository, IRepository<UserHomePermission> userHomePermissionRepository, IHomeService homeService)
    {
        _userRepository = userRepository;
        _userHomePermissionRepository = userHomePermissionRepository;
        _homeService = homeService;
    }

    public User Login(string username, string password)
    {
        try
        {
            var user = _userRepository.Get(user => user.Email == username && user.Password == password);
            return user;
        }
        catch (InvalidOperationException)
        {
            throw new InvalidValueException("Authentication", "Username or Password", new { Reason = "Invalid username or password" });
        }
    }

    public Guid AddAccount(User newUser)
    {
        if (_userRepository.Exist(user => user.Email == newUser.Email))
        {
            throw new AlreadyExistsException($"User with email '{newUser.Email}' already exists.", new { newUser.Email });
        }

        _userRepository.Add(newUser);
        return newUser.Id;
    }

    public bool DeleteAccount(User user, Role role)
    {
        if (user.Roles.Count > 1)
        {
            user.Roles.Remove(role);
            _userRepository.Update(user);
        }
        else
        {
            _userRepository.Remove(user);
        }

        return true;
    }

    public User GetById(string userId)
    {
        if (Guid.TryParse(userId, out Guid userGuid))
        {
            return _userRepository.Get(user => user.Id == userGuid);
        }
        else
        {
            throw new InvalidValueException("UserId", null, new { Reason = "Invalid user ID format" });
        }
    }

    public List<UserHomeResponse> GetHomes(User user)
    {
        var userWithHomesAndPermissions = _userRepository.Get(
            u => u.Id == user.Id,
            u => u.OwnedHomes,
            u => u.HomePermissions);

        var response = new List<UserHomeResponse>();
        var allPermissions = GetAllPermissions();
        foreach (var ownedHome in userWithHomesAndPermissions.OwnedHomes)
        {
            response.Add(new UserHomeResponse(
            _homeService.GetHomeResponseById(ownedHome.Id),
            "Owner",
            allPermissions));
        }

        if (userWithHomesAndPermissions?.HomePermissions != null)
        {
            foreach (var homePermission in userWithHomesAndPermissions.HomePermissions)
            {
                var userHomePermission = _userHomePermissionRepository.Get(
                    uhp => uhp.Id == homePermission.Id,
                    uhp => uhp.Home);

                if (userHomePermission != null)
                {
                    var permissionsList = userHomePermission.Permissions;

                    if (permissionsList != null)
                    {
                        var permissionsNames = permissionsList
                            .Select(p => p.ToString())
                            .ToList();

                        response.Add(new UserHomeResponse(
                              _homeService.GetHomeResponseById(userHomePermission.HomeId),
                              "Member",
                              permissionsNames));
                    }
                }
            }
        }

        return response;
    }

    private List<string> GetAllPermissions()
    {
        return Enum.GetValues(typeof(HomePermission))
                   .Cast<HomePermission>()
                   .Select(p => p.ToString())
                   .ToList();
    }

    public void UpdateAccount(User user)
    {
        _userRepository.Update(user);
    }

    public UserResponse ChangeProfilePhoto(User user, string photo)
    {
        user.ProfilePhoto = photo;
        _userRepository.Update(user);
        return new UserResponse(
            user.Id,
            user.Name,
            user.Surname,
            user.Email,
            user.ProfilePhoto,
            user.CreatedAt,
            user.Roles.ConvertAll(r => r.ToString()));
    }

    public List<string> GetEmails(Role role)
    {
        var usersWithRole = _userRepository.GetAll(u => u.Roles.Contains(role));
        return usersWithRole.Select(u => u.Email).ToList();
    }
}
