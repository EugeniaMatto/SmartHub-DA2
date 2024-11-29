using SmartHub.DataAccess;
using SmartHub.Domain;
using SmartHub.Exceptions;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public class HomeService : IHomeService
{
    private readonly IRepository<Home> _homeRepository;
    private readonly IRepository<UserHomePermission> _userHomePermissionsRepository;
    private readonly IRepository<NotificationMember> _notificationMembersRepository;
    private readonly IRepository<User> _userRepository;
    private readonly IRepository<Device> _deviceRepository;
    private readonly IDeviceService _deviceService;

    public HomeService(
        IRepository<Home> homeRepository,
        IRepository<UserHomePermission> userHomePermissionsRepository,
        IRepository<NotificationMember> notificationMembersRepository,
        IRepository<User> userRepository,
        IRepository<Device> deviceRepository,
        IDeviceService deviceService)
    {
        _homeRepository = homeRepository;
        _userHomePermissionsRepository = userHomePermissionsRepository;
        _notificationMembersRepository = notificationMembersRepository;
        _userRepository = userRepository;
        _deviceRepository = deviceRepository;
        _deviceService = deviceService;
    }

    public string AddHome(HomeRequest newHome, User user)
    {
        var home = new Home(
            newHome.Name,
            newHome.Street,
            newHome.StreetNumber,
            new UbicationGeo(
                (int)newHome.Ubication!.Lat!,
                (int)newHome.Ubication!.Lon!),
            user!,
            newHome.MaxMembers!);

        if (newHome.Rooms != null)
        {
            home.Rooms = newHome.Rooms;
        }

        _homeRepository.Add(home);

        return home.Id.ToString();
    }

    public Guid AddHardware(string homeId, RequestHardware request, User user)
    {
        if (UserHasPermission(homeId, user.Id, HomePermission.AssociateDevices))
        {
            var newHardware = new Hardware() { HomeId = Guid.Parse(homeId), DeviceId = Guid.Parse(request.DeviceId) };
            if (request.Name != null)
            {
                newHardware.Name = request.Name;
            }

            newHardware.Room = request.Room;
            return AddHardware(newHardware);
        }
        else
        {
            throw new HomePermissionException(user.Id, HomePermission.AssociateDevices.ToString(), Guid.Parse(homeId));
        }
    }

    public void AddMember(string userEmail, string homeId, List<HomePermission> permissions)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId, h => h.Members);
        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        if (home.Members.Count == home.MaxMembers - 1)
        {
            throw new InvalidValueException("MaxMembers", home.MaxMembers, new { CurrentMembers = home.Members.Count });
        }

        var user = _userRepository.GetOrDefault(u => u.Email == userEmail);
        if (user == null)
        {
            throw new NotFoundException("User", userEmail);
        }

        if (!user.Roles.Contains(Role.HomeOwner))
        {
            throw new NotFoundException("HomeOwner", userEmail);
        }

        if (home.Members.FirstOrDefault(uhp => uhp.UserId == user.Id) != null)
        {
            throw new AlreadyExistsException($"User with email '{userEmail}' is already a member of the home.", new { UserId = user.Id, HomeId = home.Id });
        }

        var permission = new UserHomePermission
        {
            UserId = user.Id,
            HomeId = home.Id,
            Permissions = permissions
        };

        _userHomePermissionsRepository.Add(permission);
        user.HomePermissions.Add(permission);
        home.Members.Add(permission);
        _userRepository.Update(user);
        _homeRepository.Update(home);
    }

    public Guid AddHardware(Hardware hardware)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id == hardware.HomeId, h => h.Devices);
        if (home == null)
        {
            throw new NotFoundException("Home", hardware.HomeId);
        }

        var device = _deviceRepository.GetOrDefault(d => d.Id == hardware.DeviceId);
        if (device == null)
        {
            throw new NotFoundException("Device", hardware.DeviceId);
        }

        hardware = CreateHardwareInstance(device.Type, hardware);

        if (hardware.Name == null)
        {
            hardware.Name = device.Name;
        }

        if (hardware.Room != null && !home.Rooms.Contains(hardware.Room))
        {
            throw new NotFoundException("Room", hardware.Room, new { HomeId = home.Id });
        }

        home.Devices.Add(hardware);
        _homeRepository.Update(home);

        return hardware.Id;
    }

    private Hardware CreateHardwareInstance(DeviceType deviceType, Hardware baseHardware)
    {
        return deviceType switch
        {
            DeviceType.SmartLamp => new SmartLampHardware
            {
                Id = baseHardware.Id,
                Name = baseHardware.Name,
                HomeId = baseHardware.HomeId,
                DeviceId = baseHardware.DeviceId,
                Room = baseHardware.Room
            },
            DeviceType.WindowSensor => new WindowSensorHardware
            {
                Id = baseHardware.Id,
                Name = baseHardware.Name,
                HomeId = baseHardware.HomeId,
                DeviceId = baseHardware.DeviceId,
                Room = baseHardware.Room
            },
            _ => new Hardware
            {
                Id = baseHardware.Id,
                Name = baseHardware.Name,
                HomeId = baseHardware.HomeId,
                DeviceId = baseHardware.DeviceId,
                Room = baseHardware.Room
            },
        };
    }

    public Guid UpdateHardware(string homeId, PatchHardwareRequest request, User user)
    {
        if (UserHasPermission(homeId, user.Id, HomePermission.ChangeDeviceName))
        {
            if (!Guid.TryParse(request.HardwareId, out var hardwareId))
            {
                throw new InvalidValueException("HardwareId", request.HardwareId);
            }

            var hardware = _deviceService.GetHardwareById(hardwareId);
            hardware.Name = request.Name;
            return _deviceService.UpdateHardware(hardware);
        }
        else
        {
            throw new HomePermissionException(user.Id, HomePermission.ChangeDeviceName.ToString(), Guid.Parse(homeId));
        }
    }

    public List<MemberResponse> GetMembers(string homeId)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId, h => h.Members, h => h.NotificationMembers);

        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        var userIds = home.Members.Select(m => m.UserId).ToList();
        var notificationMembersIds = home.NotificationMembers.Select(m => m.UserId).ToList();

        var users = _userRepository.GetAll(u => userIds.Contains(u.Id)).ToList();

        return users.Select(user =>
        {
            var homePermissions = user.HomePermissions
                .Where(uhp => uhp.HomeId.ToString() == homeId)
                .SelectMany(uhp => uhp.Permissions)
                .Select(hp => hp.ToString())
                .ToList();

            return new MemberResponse(
                user.Id,
                user.Name,
                user.Surname,
                user.Email,
                homePermissions,
                notificationMembersIds.Contains(user.Id));
        }).ToList();
    }

    public List<HardwareResponse> GetDevices(string homeId, User user)
    {
        if (UserHasPermission(homeId, user.Id, HomePermission.AssociateDevices))
        {
            return GetDevices(homeId).ConvertAll(h => new HardwareResponse(h));
        }
        else
        {
            throw new HomePermissionException(user.Id, HomePermission.AssociateDevices.ToString(), Guid.Parse(homeId));
        }
    }

    public List<Hardware> GetDevices(string homeId)
    {
        var home = _homeRepository.GetOrDefault(
                    h => h.Id.ToString() == homeId, h => h.Devices);

        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        var hardwareIds = home.Devices.ConvertAll(h => h.Id);
        return hardwareIds.ConvertAll(_deviceService.GetHardwareById);
    }

    public Dictionary<string, List<HardwareResponse>> GetRooms(string homeId)
    {
        var home = _homeRepository.GetOrDefault(
                        h => h.Id.ToString() == homeId, h => h.Devices);

        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        var roomHardwareMap = new Dictionary<string, List<HardwareResponse>>();

        foreach (var room in home.Rooms)
        {
            var hardwaresInRoom = home.Devices
                .Where(device => device.Room == room)
                .Select(device => new HardwareResponse(_deviceService.GetHardwareById(device.Id)))
                .ToList();

            roomHardwareMap[room] = hardwaresInRoom;
        }

        return roomHardwareMap;
    }

    public void AddRooms(string homeId, List<string> newRooms, User user)
    {
        if (UserHasPermission(homeId, user.Id, HomePermission.AddRooms))
        {
            var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId);

            if (home == null)
            {
                throw new NotFoundException("Home", homeId);
            }

            foreach (var room in newRooms)
            {
                if (home.Rooms.Contains(room))
                {
                    throw new AlreadyExistsException($"Room '{room}' already exists in home.", new { RoomName = room, HomeId = home.Id });
                }
            }

            home.Rooms.AddRange(newRooms);
            _homeRepository.Update(home);
        }
        else
        {
            throw new HomePermissionException(user.Id, HomePermission.AddRooms.ToString(), Guid.Parse(homeId));
        }
    }

    public void ChangeHardwareRoom(string homeId, string newRoom, string hardwareId, User user)
    {
        if (UserHasPermission(homeId, user.Id, HomePermission.ChangeHardwareRoom))
        {
            var home = _homeRepository.GetOrDefault(
                h => h.Id.ToString() == homeId, h => h.Devices);

            if (home == null)
            {
                throw new NotFoundException("Home", homeId);
            }

            if (!home.Rooms.Contains(newRoom))
            {
                throw new NotFoundException("Room", newRoom);
            }

            var hardware = home.Devices.FirstOrDefault(d => d.Id.ToString() == hardwareId);

            if (hardware == null)
            {
                throw new NotFoundException("Hardware", hardwareId);
            }

            hardware.Room = newRoom;
            _deviceService.UpdateHardware(hardware);
        }
        else
        {
            throw new HomePermissionException(user.Id, HomePermission.ChangeHardwareRoom.ToString(), Guid.Parse(homeId));
        }
    }

    public void AddNotificationMember(string homeId, string memberEmail)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId, h => h.NotificationMembers) ?? throw new NotFoundException("Home", homeId);

        var member = _userRepository.GetOrDefault(u => u.Email == memberEmail) ?? throw new NotFoundException("Member", memberEmail);

        if (!home.NotificationMembers.Any(h => h.UserId == member.Id))
        {
            var notificationMember = new NotificationMember() { HomeId = home.Id, UserId = member.Id, Id = new() };
            _notificationMembersRepository.Add(notificationMember);

            home.NotificationMembers.Add(notificationMember);
            _homeRepository.Update(home);
        }
    }

    public bool UserHasPermission(string homeId, Guid userId, HomePermission permission)
    {
        var home = _homeRepository.GetOrDefault(
                          h => h.Id.ToString() == homeId,
                          h => h.Members,
                          h => h.Owner);

        if (home == null)
        {
            throw new NotFoundException("Home", homeId);
        }

        if (home.Owner.Id == userId)
        {
            return true;
        }

        var userHomePermission = home.Members.FirstOrDefault(uhp => uhp.User.Id == userId);
        if (userHomePermission == null)
        {
            throw new NotFoundException("Member", userId.ToString());
        }

        return userHomePermission.Permissions.Any(p => p == permission);
    }

    public Home? GetHomeById(string homeId)
    {
        if (!Guid.TryParse(homeId, out var guidHomeId))
        {
            throw new InvalidValueException("HomeId", homeId, new { Reason = "Invalid GUID format" });
        }

        return _homeRepository.GetOrDefault(h => h.Id == guidHomeId, h => h.Owner);
    }

    public UserHomePermission? GetUserHomePermission(string homeId, Guid userId)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId, h => h.Members);

        return home?.Members.FirstOrDefault(uhp => uhp.UserId == userId);
    }

    public UserHomePermission? GetMemberByEmail(string homeId, string email)
    {
        var home = _homeRepository.GetOrDefault(h => h.Id.ToString() == homeId, h => h.Members);

        var member = _userRepository.GetOrDefault(u => u.Email == email)
                     ?? throw new NotFoundException("Member", email);

        return home?.Members.FirstOrDefault(uhp => uhp.UserId == member.Id);
    }

    public void AddHomePermission(UserHomePermission permission)
    {
        _userHomePermissionsRepository.Update(permission);
    }

    public HomeResponse GetHomeResponseById(Guid homeId)
    {
        var home = _homeRepository.Get(h => h.Id == homeId, h => h.Owner);

        return new HomeResponse(
            home.Id,
            home.Name,
            home.Street,
            home.StreetNumber,
            home.Ubication,
            home.Owner.Email,
            home.Rooms,
            home.MaxMembers);
    }

    public void HardwareTurnOff(HardwareChangeStatusRequest request, User user)
    {
        IsMember(request.HomeId, user);
        _deviceService.HardwareTurnOff(request.HardwareId, user);
    }

    public void HardwareTurnOn(HardwareChangeStatusRequest request, User user)
    {
        IsMember(request.HomeId, user);
        _deviceService.HardwareTurnOn(request.HardwareId, user);
    }

    private void IsMember(string homeId, User user)
    {
        var home = _homeRepository.Get(
                   h => h.Id.ToString() == homeId,
                   h => h.Members,
                   h => h.Owner);

        if (home.Owner.Id != user.Id)
        {
            var userHomePermission = home.Members.FirstOrDefault(uhp => uhp.User.Id == user.Id);
            if (userHomePermission == null)
            {
                throw new NotFoundException("Member", user.Id);
            }
        }
    }
}
