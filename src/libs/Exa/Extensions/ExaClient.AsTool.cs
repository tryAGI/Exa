#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Exa;

/// <summary>
/// Extensions for using ExaClient as an MEAI tool with any IChatClient.
/// </summary>
public static class ExaToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Exa search,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Exa client to use for searches.</param>
    /// <param name="numResults">Maximum number of search results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsSearchTool(
        this ExaClient client,
        int numResults = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.SearchAsync(
                    request: new AllOf<SearchRequest2, CommonRequest>
                    {
                        Value1 = new SearchRequest2 { Query = query },
                        Value2 = new CommonRequest { NumResults = numResults },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSearchResponse(response);
            },
            name: "WebSearch",
            description: "Searches the web using Exa AI-powered search for current information on a given query. Returns relevant results with titles, URLs, and content snippets.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Exa content retrieval,
    /// suitable for extracting content from URLs as a tool.
    /// </summary>
    /// <param name="client">The Exa client to use for content retrieval.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetContentsTool(this ExaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string url, CancellationToken cancellationToken) =>
            {
                var response = await client.GetContentsAsync(
                    request: new AllOf<GetContentsRequest2, ContentsRequest>
                    {
                        Value1 = new GetContentsRequest2 { Urls = [url] },
                        Value2 = new ContentsRequest { Text = true },
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatContentsResponse(response);
            },
            name: "GetWebContent",
            description: "Retrieves and returns the main text content from a given URL using Exa.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that wraps Exa answer generation,
    /// suitable for RAG-style question answering as a tool.
    /// </summary>
    /// <param name="client">The Exa client to use for answering.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsAnswerTool(this ExaClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string query, CancellationToken cancellationToken) =>
            {
                var response = await client.AnswerAsync(
                    request: new AnswerRequest
                    {
                        Query = query,
                        Text = true,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAnswerResponse(response);
            },
            name: "AnswerQuestion",
            description: "Answers a question using Exa's AI-powered search and answer generation. Returns a direct answer with citations from web sources.");
    }

    private static string FormatSearchResponse(SearchResponse response)
    {
        var parts = new List<string>();

        if (response.Results is { Count: > 0 })
        {
            parts.Add("Sources:");
            foreach (var result in response.Results)
            {
                var title = result.Value1?.Title;
                var url = result.Value1?.Url;
                var text = result.Value2?.Text;
                var summary = result.Value2?.Summary;

                var entry = $"- [{title}]({url})";
                if (!string.IsNullOrWhiteSpace(summary))
                {
                    entry += $": {summary}";
                }
                else if (!string.IsNullOrWhiteSpace(text))
                {
                    entry += $": {(text.Length > 200 ? text[..200] + "..." : text)}";
                }

                parts.Add(entry);
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatContentsResponse(GetContentsResponse response)
    {
        var parts = new List<string>();

        if (response.Results is { Count: > 0 })
        {
            foreach (var result in response.Results)
            {
                var title = result.Value1?.Title;
                var url = result.Value1?.Url;
                var text = result.Value2?.Text;

                if (!string.IsNullOrWhiteSpace(title))
                {
                    parts.Add($"# {title}");
                }
                if (!string.IsNullOrWhiteSpace(url))
                {
                    parts.Add($"URL: {url}");
                }
                if (!string.IsNullOrWhiteSpace(text))
                {
                    parts.Add(text);
                }
            }
        }

        return string.Join("\n\n", parts);
    }

    private static string FormatAnswerResponse(AllOf<AnswerResult, AnswerResponse2> response)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(response.Value1?.Answer))
        {
            parts.Add($"Answer: {response.Value1.Answer}");
        }

        if (response.Value1?.Citations is { Count: > 0 })
        {
            parts.Add("Citations:");
            foreach (var citation in response.Value1.Citations)
            {
                parts.Add($"- [{citation.Title}]({citation.Url})");
            }
        }

        return string.Join("\n", parts);
    }
}
