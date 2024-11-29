using SmartHub.Domain;
using SmartHub.Model.Request;
using SmartHub.Model.Response;

namespace SmartHub.BussinesLogic;
public interface IMemberService
{
    void AddMember(MemberRequest request, string homeId, User user);
    void AddPermission(string homeId, Guid userId, List<string> permissions, User user);
    List<MemberResponse> GetMembers(string homeId);
    void AddNotificationMember(string homeId, string memberEmail);
}
