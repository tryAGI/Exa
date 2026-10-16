#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebsetsPreviewApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"websets-preview", @"Websets Preview endpoint commands.");
                         command.Subcommands.Add(WebsetsPreviewWebsetsPreviewCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}