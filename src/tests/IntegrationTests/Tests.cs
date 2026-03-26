namespace Exa.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ExaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("EXA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("EXA_API_KEY environment variable is not found.");

        var client = new ExaClient(apiKey);
        
        return client;
    }
}
