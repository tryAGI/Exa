# Find Similar

Shows how to find pages similar to a given URL using Exa.

This example assumes `using Exa;` is in scope and `apiKey` contains your Exa API key.

```csharp
using var client = new ExaClient(apiKey);

        // Find pages similar to a given URL. This is useful for discovering
        // related content, competitor analysis, or expanding a research corpus.
#pragma warning disable CS0618 // findSimilar is deprecated by Exa but kept for complete API coverage.
        var response = await client.FindSimilarAsync(
            new FindSimilarRequest { Url = "https://arxiv.org/abs/2307.06435", NumResults = 3 });
#pragma warning restore CS0618

        Console.WriteLine($"Found {response.Results!.Count} similar pages");

        foreach (var result in response.Results)
        {
            Console.WriteLine($"  - {result.Title}: {result.Url}");
        }
```