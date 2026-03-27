/*
order: 50
title: Answer Tool
slug: answer-tool

Shows how to use Exa's answer endpoint as an AIFunction tool with any IChatClient.
*/

namespace Exa.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsAnswerTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an answer tool from the Exa client for RAG-style question answering.
        var tool = client.AsAnswerTool();
        tool.Name.Should().Be("AnswerQuestion");
        tool.Description.Should().NotBeNullOrEmpty();
    }
}
