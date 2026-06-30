#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class WebsetsPreviewApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"websets-preview", @"Websets Preview endpoint commands.");
                         command.Subcommands.Add(WebsetsPreviewWebsetsPreviewCommandApiCommand.Create());
        return command;
    }
}