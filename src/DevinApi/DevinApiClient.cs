using DevinApi.Core;

namespace DevinApi;

public partial class DevinApiClient
{
    private readonly RawClient _client;

    public DevinApiClient(ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "DevinApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "DevinTest.Net/0.0.1" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Imdb = new ImdbClient(_client);
    }

    public ImdbClient Imdb { get; }
}
