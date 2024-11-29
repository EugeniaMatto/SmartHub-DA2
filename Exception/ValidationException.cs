namespace SmartHub.Exceptions;
public class ValidationException : SmartHubBaseException
{
    public Dictionary<string, string[]> Errors { get; } = [];
    public ValidationException(string message, Dictionary<string, string[]>? errors, object? additionalData = null, Exception? innerException = null)
        : base(FormatMessage(message, errors), "VALIDATION_ERROR", additionalData, innerException)
    {
        Errors = errors ?? [];
    }

    private static string FormatMessage(string message, Dictionary<string, string[]>? errors)
    {
        if (errors == null || errors.Count == 0)
        {
            return message;
        }

        var formattedErrors = string.Join("; ", errors.Select(e => $"{e.Key}: {string.Join(", ", e.Value)}"));
        return $"{message}: {formattedErrors}";
    }

    public ValidationException(string message, object? additionalData = null, Exception? innerException = null)
    : base(message, "VALIDATION_ERROR", additionalData, innerException)
    {
        Errors = [];
    }
}
