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
        var response = await client.SearchAsync(new AllOf<SearchRequest2, CommonRequest>
        {
            Value1 = new SearchRequest2
            {
                Query = "Latest developments in LLM capabilities",
            },
            Value2 = new CommonRequest
            {
                NumResults = 5,
            },
        });

        response.Results.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Found {response.Results!.Count} results");

        foreach (var result in response.Results)
        {
            Console.WriteLine($"  - {result.Value1?.Title}: {result.Value1?.Url}");
        }
    }
}
