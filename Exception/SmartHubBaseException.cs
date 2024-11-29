namespace SmartHub.Exceptions;
public abstract class SmartHubBaseException(string message, string errorCode, object? additionalData = null, Exception? innerException = null) : Exception(message, innerException)
{
    public string ErrorCode { get; } = errorCode;
    public object? AdditionalData { get; } = additionalData;
}
