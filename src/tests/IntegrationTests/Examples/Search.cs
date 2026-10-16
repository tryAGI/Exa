/*
order: 20
title: Search
slug: search

Shows how to search the web using Exa's AI-powered search.
*/

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Search()
    {
        using var client = GetAuthenticatedClient();

        //// Search the web for relevant results using a natural language query.
        var response = await client.SearchAsync(
            new SearchRequest { Query = "Latest developments in LLM capabilities", Type = "auto", NumResults = 5 });

        var results = response.Results?.Results;
        results.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Found {results!.Count} results");

        foreach (var result in results)
        {
            Console.WriteLine($"  - {result.Title}: {result.Url}");
        }
    }
}
