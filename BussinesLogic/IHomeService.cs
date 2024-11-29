using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;

public interface IHomeService
{
    string AddHome(HomeRequest newHome, User user);
    Guid AddHardware(string homeId, RequestHardware request, User user);
    Guid UpdateHardware(string homeId, PatchHardwareRequest request, User user);
    List<HardwareResponse> GetDevices(string homeId, User user);
    Dictionary<string, List<HardwareResponse>> GetRooms(string homeId);
    void AddRooms(string homeId, List<string> newRooms, User user);
    void ChangeHardwareRoom(string homeId, string newRoom, string hardwareId, User user);
    void AddMember(string userEmail, string homeId, List<HomePermission> permissions);
    public Guid AddHardware(Hardware hardware);
    public List<MemberResponse> GetMembers(string homeId);
    public List<Hardware> GetDevices(string homeId);
    public void AddNotificationMember(string homeId, string memberEmail);
    public bool UserHasPermission(string homeId, Guid userId, HomePermission permission);
    public Home? GetHomeById(string homeId);
    public UserHomePermission? GetUserHomePermission(string homeId, Guid userId);
    public UserHomePermission? GetMemberByEmail(string homeId, string email);
    public void AddHomePermission(UserHomePermission permission);
    public HomeResponse GetHomeResponseById(Guid homeId);
    void HardwareTurnOn(HardwareChangeStatusRequest request, User user);
    void HardwareTurnOff(HardwareChangeStatusRequest request, User user);
}
