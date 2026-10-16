# Answer Tool

Shows how to use Exa's answer endpoint as an AIFunction tool with any IChatClient.

This example assumes `using Exa;` is in scope and `apiKey` contains your Exa API key.

```csharp
using var client = new ExaClient("test-key");

// Create an answer tool from the Exa client for RAG-style question answering.
var tool = client.AsAnswerTool();
```