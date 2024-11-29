namespace SmartHub.Model.Response;
public readonly struct UserHomeResponse
{
    public HomeResponse Home { get; }
    public string Role { get; }
    public List<string>? Permissions { get; }

    public UserHomeResponse(HomeResponse home, string role, List<string>? permissions)
    {
        Home = home;
        Role = role;
        Permissions = permissions;
    }
}
