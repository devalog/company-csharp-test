namespace DevinApi.Core;

public interface IIsRetryableContent
{
    public bool IsRetryable { get; }
}
