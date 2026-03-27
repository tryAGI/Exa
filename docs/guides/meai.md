# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Exa SDK provides `AIFunction` tool wrappers from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), allowing you to use Exa search, content retrieval, and answer generation as tools with any `IChatClient`.

## Installation

```bash
dotnet add package Exa
```

## Search Tool

Use `AsSearchTool()` to create an `AIFunction` that searches the web using Exa's AI-powered search:

```csharp
using Exa;
using Microsoft.Extensions.AI;

var exaClient = new ExaClient(apiKey: Environment.GetEnvironmentVariable("EXA_API_KEY")!);

var searchTool = exaClient.AsSearchTool(numResults: 5);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [searchTool],
};

var response = await chatClient.GetResponseAsync(
    "What are the latest developments in quantum computing?",
    options);
```

## Content Retrieval Tool

Use `AsGetContentsTool()` to extract page content from URLs:

```csharp
var contentTool = exaClient.AsGetContentsTool();

var options = new ChatOptions
{
    Tools = [searchTool, contentTool],
};
```

## Answer Tool

Use `AsAnswerTool()` for RAG-style question answering with citations:

```csharp
var answerTool = exaClient.AsAnswerTool();

var options = new ChatOptions
{
    Tools = [answerTool],
};

var response = await chatClient.GetResponseAsync(
    "What is the latest valuation of SpaceX?",
    options);
```

## Combining Tools

All three tools can be used together to give an LLM comprehensive web research capabilities:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        exaClient.AsSearchTool(numResults: 5),
        exaClient.AsGetContentsTool(),
        exaClient.AsAnswerTool(),
    ],
};
```
