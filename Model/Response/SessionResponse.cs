namespace SmartHub.Model.Response;
public readonly struct SessionResponse
{
    public Guid UserId { get; }
    public Guid Token { get; }
    public List<string> Roles { get; }
    public string Name { get; }
    public string Surname { get; }
    public string Email { get; }
    public string ProfilePhoto { get; }
    public DateTime CreatedAt { get; }

    public SessionResponse(Guid userId, Guid token, List<string> roles, string name, string surname, string email, string profilePhoto, DateTime createdAt)
    {
        UserId = userId;
        Token = token;
        Roles = roles ?? [];
        Name = name;
        Surname = surname;
        Email = email;
        ProfilePhoto = profilePhoto;
        CreatedAt = createdAt;
    }
}
