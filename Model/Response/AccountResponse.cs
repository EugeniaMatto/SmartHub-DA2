namespace SmartHub.Model.Response;

public readonly struct AccountResponse
{
    public Guid Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public string FullName { get; }
    public List<string> Roles { get; }
    public DateTime CreatedAt { get; }
    public string Email { get; }

    public AccountResponse(Guid id, string name, string surname, string fullName, List<string> roles, DateTime createdAt, string email)
    {
        Id = id;
        Name = name;
        Surname = surname;
        FullName = fullName;
        Roles = roles ?? [];
        CreatedAt = createdAt;
        Email = email;
    }
}
