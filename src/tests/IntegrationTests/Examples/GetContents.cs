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
        var response = await client.GetContentsAsync(new ContentsRequest
        {
            Urls = ["https://exa.ai"],
            Text = true,
        });

        response.Results.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Retrieved contents for {response.Results!.Count} URL(s)");

        foreach (var result in response.Results)
        {
            var text = result.Text;
            Console.WriteLine($"  - {result.Url}: {text?[..Math.Min(text.Length, 100)]}...");
        }
    }
}
