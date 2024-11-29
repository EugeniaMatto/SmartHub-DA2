namespace SmartHub.Exceptions;
public class AlreadyExistsException : SmartHubBaseException
{
    public AlreadyExistsException(string message, object? additionalData = null, Exception? innerException = null)
        : base(message, "ALREADY_EXISTS", additionalData, innerException)
    {
    }
}
