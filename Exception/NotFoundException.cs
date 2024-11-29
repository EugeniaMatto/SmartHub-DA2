namespace SmartHub.Exceptions;
public class NotFoundException : SmartHubBaseException
{
    public string ResourceName { get; }
    public object? ResourceKey { get; }

    public NotFoundException(string resourceName, object? resourceKey, object? additionalData = null, Exception? innerException = null)
        : base($"The resource '{resourceName}' with key '{resourceKey}' was not found.", "NOT_FOUND", additionalData, innerException)
    {
        ResourceName = resourceName;
        ResourceKey = resourceKey;
    }
}
