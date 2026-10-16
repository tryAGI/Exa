# Search

Shows how to search the web using Exa's AI-powered search.

This example assumes `using Exa;` is in scope and `apiKey` contains your Exa API key.

```csharp
using var client = new ExaClient(apiKey);

// Search the web for relevant results using a natural language query.
var response = await client.SearchAsync(
    new SearchRequest { Query = "Latest developments in LLM capabilities", Type = "auto", NumResults = 5 });

var results = response.Results?.Results;
Console.WriteLine($"Found {results!.Count} results");

foreach (var result in results)
{
    Console.WriteLine($"  - {result.Title}: {result.Url}");
}
```