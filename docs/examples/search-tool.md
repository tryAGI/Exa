# Search Tool

Shows how to use Exa as an AIFunction tool with any IChatClient.

This example assumes `using Exa;` is in scope and `apiKey` contains your Exa API key.

```csharp
using var client = new ExaClient("test-key");

// Create a search tool from the Exa client for use with any IChatClient.
var tool = client.AsSearchTool(numResults: 3);
```