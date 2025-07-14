namespace DevinApi;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class DevinApiException(string message, Exception? innerException = null)
    : Exception(message, innerException);
