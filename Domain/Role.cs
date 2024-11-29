namespace SmartHub.Domain;

/// <summary>
/// Represents the roles a user can have in the system.
/// </summary>
public enum Role
{
    /// <summary>
    /// A user who owns a company.
    /// </summary>
    CompanyOwner,

    /// <summary>
    /// A user who owns a home.
    /// </summary>
    HomeOwner,

    /// <summary>
    /// An administrator with full access to the system.
    /// </summary>
    Administrator
}
