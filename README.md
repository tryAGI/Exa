# Exa

[![Nuget package](https://img.shields.io/nuget/vpre/Exa)](https://www.nuget.org/packages/Exa/)
[![dotnet](https://github.com/tryAGI/Exa/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Exa/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Exa)](https://github.com/tryAGI/Exa/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on the [official Exa Public API v2 OpenAPI specification](https://exa.ai/docs/exa-spec.yaml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Generated coverage for all 64 operations in the current Exa Public API v2 specification, plus all 6 operations in the separate Team Management specification
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Supports .NET 10

### Usage
```csharp
using Exa;

using var client = new ExaClient(apiKey);
```

### API coverage

The SDK follows Exa's [official specifications](https://exa.ai/docs/admin/openapi-spec).
All clients below are included in the `Exa` NuGet package.

| API | Client | Coverage |
| --- | --- | --- |
| Search | `client.SearchAsync`, `client.SearchAsStreamAsync` | Search modes, filters, contents, structured synthesis, SSE |
| Contents | `client.GetContentsAsync` | Page text, highlights, summaries, metadata |
| Answer | `client.AnswerAsync`, `client.AnswerAsStreamAsync` | Answers and citations, SSE |
| Find Similar | `client.FindSimilarAsync` | Similar-page discovery |
| Agent | `client.Agent` | Create, list, retrieve, cancel, stop, delete runs; events and SSE |
| Monitors | `client.Monitors`, `client.Runs` | Recurring searches, batch actions, triggers, run history |
| Batch | `client.Batches` | Create, list, retrieve, cancel, delete; requires the generated beta-header enum |
| Websets | `client.Websets`, `client.WebsetsPreview`, `client.Searches`, `client.Items`, `client.Enrichments` | Datasets, preview, searches, items, enrichments |
| Websets automation | `client.Monitors`, `client.MonitorsRuns`, `client.Imports`, `client.Webhooks`, `client.WebhooksAttempts`, `client.Events` | Websets monitors, imports, webhooks, delivery attempts, events |
| Team | `client.Teams` | Current-team information |
| Team Management | `Exa.TeamManagement.ExaTeamManagementClient` | API-key creation, listing, retrieval, update, deletion, usage |

```csharp
var response = await client.SearchAsync(new SearchRequest
{
    Query = "Latest developments in .NET",
    Type = "auto",
    NumResults = 5,
    Contents = new ContentsOptions { Highlights = true },
});
var results = response.Results?.Results ?? response.Synthesis?.Results;

// Team Management uses a service key and a separate admin host.
using var admin = new Exa.TeamManagement.ExaTeamManagementClient(serviceKey);
var keys = await admin.ListApiKeysAsync();
```

Websets operations automatically use `https://api.exa.ai/websets`; Team Management
uses `https://admin-api.exa.ai/team-management` with `x-api-key` authentication.
Public API operations use Bearer authentication. Agent data partners are selected
through `CreateAgentRunRequest.DataSources`.

### Migrating from the legacy specification

This update changes generated types to match Public API v2. Replace
`AllOf<SearchRequest2, CommonRequest>` with `SearchRequest`, and
`AllOf<GetContentsRequest2, ContentsRequest>` with `ContentsRequest`.
Search responses expose the `Results` / `Synthesis` union; result fields such as
`Title`, `Url`, and `Text` are now direct properties. Answer uses `AnswerResponse`.
The old `/research/v0/tasks` endpoints are absent from Exa's current specification;
use `client.Agent` for new research workflows. Existing callers must migrate before
upgrading. This is an unofficial community SDK.

### CLI

```bash
dotnet tool install --global Exa.CLI --prerelease
exa --help
```

<!-- EXAMPLES:START -->
### Search
Shows how to search the web using Exa's AI-powered search.

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

### Get Contents
Shows how to retrieve page contents for specific URLs using Exa.

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

### Find Similar
Shows how to find pages similar to a given URL using Exa.

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

### Search Tool
Shows how to use Exa as an AIFunction tool with any IChatClient.

```csharp
using var client = new ExaClient("test-key");

// Create a search tool from the Exa client for use with any IChatClient.
var tool = client.AsSearchTool(numResults: 3);
```

### Answer Tool
Shows how to use Exa's answer endpoint as an AIFunction tool with any IChatClient.

```csharp
using var client = new ExaClient("test-key");

// Create an answer tool from the Exa client for RAG-style question answering.
var tool = client.AsAnswerTool();
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Exa/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Exa/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
