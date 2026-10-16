namespace Exa;

// The public spec combines the public API and Websets servers. AutoSDK omits
// default request URLs for these single-server tag clients in that configuration.
// Resolve each request independently so Websets calls sharing the HttpClient
// retain their own base path. Explicit HttpClient/baseUri overrides still apply.
internal static class ExaRequestRouting
{
    internal static void ApplyDefault(HttpClient client, HttpRequestMessage request, string defaultBaseUrl)
    {
        if (client.BaseAddress is null && request.RequestUri is { IsAbsoluteUri: false } relativeUri)
        {
            request.RequestUri = new Uri(new Uri(defaultBaseUrl), relativeUri);
        }
    }
}

public sealed partial class AgentClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) =>
        ExaRequestRouting.ApplyDefault(HttpClient, request, DefaultBaseUrl);
}

public sealed partial class BatchesClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) =>
        ExaRequestRouting.ApplyDefault(HttpClient, request, DefaultBaseUrl);
}

public sealed partial class TeamsClient
{
    partial void PrepareRequest(HttpClient client, HttpRequestMessage request) =>
        ExaRequestRouting.ApplyDefault(HttpClient, request, DefaultBaseUrl);
}
