namespace SmartHub.Exceptions;
public class HardwareFeatureNotSupportedException : SmartHubBaseException
{
    public string HardwareId { get; }
    public string Feature { get; }

    public HardwareFeatureNotSupportedException(string hardwareId, string feature, object? additionalData = null, Exception? innerException = null)
        : base($"The hardware with ID '{hardwareId}' does not support the feature '{feature}'.", "HARDWARE_FEATURE_NOT_SUPPORTED", additionalData, innerException)
    {
        HardwareId = hardwareId;
        Feature = feature;
    }
}
