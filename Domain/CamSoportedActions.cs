namespace SmartHub.Domain;

/// <summary>
/// Specifies the actions that the camera can support.
/// </summary>
public enum CamSupportedActions
{
    /// <summary>
    /// The camera supports motion detection.
    /// </summary>
    MotionDetection,

    /// <summary>
    /// The camera supports person detection.
    /// </summary>
    PersonDetection
}
