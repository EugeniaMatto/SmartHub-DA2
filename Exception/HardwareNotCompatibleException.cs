namespace SmartHub.Exceptions;
public class HardwareNotCompatibleException : SmartHubBaseException
{
    public string HardwareId { get; }

    public HardwareNotCompatibleException(string hardwareId, string expectedType, object? additionalData = null, Exception? innerException = null)
        : base($"The hardware with ID '{hardwareId}' is not compatible. Expected type: {expectedType}.", "HARDWARE_NOT_COMPATIBLE", additionalData, innerException)
    {
        HardwareId = hardwareId;
    }
}
