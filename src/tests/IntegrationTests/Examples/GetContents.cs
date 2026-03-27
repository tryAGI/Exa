/*
order: 30
title: Get Contents
slug: get-contents

Shows how to retrieve page contents for specific URLs using Exa.
*/

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetContents()
    {
        using var client = GetAuthenticatedClient();

        //// Retrieve the text content of specific web pages by URL.
        var response = await client.GetContentsAsync(new AllOf<GetContentsRequest2, ContentsRequest>
        {
            Value1 = new GetContentsRequest2
            {
                Urls = ["https://exa.ai"],
            },
            Value2 = new ContentsRequest
            {
                Text = true,
            },
        });

        response.Results.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Retrieved contents for {response.Results!.Count} URL(s)");

        foreach (var result in response.Results)
        {
            var text = result.Value2?.Text;
            Console.WriteLine($"  - {result.Value1?.Url}: {text?[..Math.Min(text.Length, 100)]}...");
        }
    }
}
