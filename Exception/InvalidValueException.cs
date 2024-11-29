namespace SmartHub.Exceptions;
public class InvalidValueException : SmartHubBaseException
{
    public string FieldName { get; }
    public object? ProvidedValue { get; }

    public InvalidValueException(string fieldName, object? providedValue, object? additionalData = null, Exception? innerException = null)
        : base($"The value '{providedValue}' for the field '{fieldName}' is invalid or not allowed.", "INVALID_VALUE", additionalData, innerException)
    {
        FieldName = fieldName;
        ProvidedValue = providedValue;
    }
}
