/*
order: 40
title: Find Similar
slug: find-similar

Shows how to find pages similar to a given URL using Exa.
*/

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task FindSimilar()
    {
        using var client = GetAuthenticatedClient();

        //// Find pages similar to a given URL. This is useful for discovering
        //// related content, competitor analysis, or expanding a research corpus.
        var response = await client.FindSimilarAsync(new AllOf<FindSimilarRequest2, CommonRequest>
        {
            Value1 = new FindSimilarRequest2
            {
                Url = "https://arxiv.org/abs/2307.06435",
            },
            Value2 = new CommonRequest
            {
                NumResults = 3,
            },
        });

        response.Results.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Found {response.Results!.Count} similar pages");

        foreach (var result in response.Results)
        {
            Console.WriteLine($"  - {result.Value1?.Title} (score: {result.Value1?.Score:F4})");
        }
    }
}
