# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Exa SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models web search, content retrieval, and question answering capabilities.

## Installation

```bash
dotnet add package Exa
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsSearchTool(numResults)` | `WebSearch` | Searches the web using Exa AI-powered search |
| `AsGetContentsTool()` | `GetWebContent` | Retrieves main text content from a URL |
| `AsAnswerTool()` | `AnswerQuestion` | Answers a question with citations from web sources |

## Usage

```csharp
using Exa;
using Microsoft.Extensions.AI;

var exa = new ExaClient(apiKey: Environment.GetEnvironmentVariable("EXA_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        exa.AsSearchTool(numResults: 5),
        exa.AsGetContentsTool(),
        exa.AsAnswerTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What are the latest developments in quantum computing?"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

## Tool Details

### AsSearchTool Parameters

| Parameter | Type | Default | Description |
|-----------|------|---------|-------------|
| `numResults` | `int` | `5` | Maximum number of search results to return |

### AsGetContentsTool

No configurable parameters. Extracts text content from a single URL.

### AsAnswerTool

No configurable parameters. Returns a direct answer with citations.
