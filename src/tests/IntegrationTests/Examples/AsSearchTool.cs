/*
order: 40
title: Search Tool
slug: search-tool

Shows how to use Exa as an AIFunction tool with any IChatClient.
*/

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsSearchTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a search tool from the Exa client for use with any IChatClient.
        var tool = client.AsSearchTool(numResults: 3);
        tool.Name.Should().Be("WebSearch");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
