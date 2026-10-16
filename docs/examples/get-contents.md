# Get Contents

Shows how to retrieve page contents for specific URLs using Exa.

This example assumes `using Exa;` is in scope and `apiKey` contains your Exa API key.

```csharp
using var client = new ExaClient(apiKey);

// Retrieve the text content of specific web pages by URL.
var response = await client.GetContentsAsync(
    new ContentsRequest { Urls = ["https://exa.ai"], Text = true });

Console.WriteLine($"Retrieved contents for {response.Results!.Count} URL(s)");

foreach (var result in response.Results)
{
    var text = result.Text;
    Console.WriteLine($"  - {result.Url}: {text?[..Math.Min(text.Length, 100)]}...");
}
```