namespace SmartHub.Model.Response;
public readonly struct MemberResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public string Email { get; }
    public List<string> Permissions { get; }
    public bool Notification { get; }

    public MemberResponse(Guid id, string name, string surname, string email, List<string> permissions, bool notification)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Email = email;
        Permissions = permissions ?? [];
        Notification = notification;
    }
}
