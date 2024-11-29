namespace SmartHub.Model.Response;
public readonly struct UserResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public string Email { get; }
    public string ProfilePhoto { get; }
    public DateTime CreatedAt { get; }
    public List<string> Roles { get; }

    public UserResponse(Guid id, string name, string surname, string email, string profilePhoto, DateTime createdAt, List<string> roles)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        ProfilePhoto = profilePhoto;
        CreatedAt = createdAt;
        Roles = roles ?? [];
    }
}
