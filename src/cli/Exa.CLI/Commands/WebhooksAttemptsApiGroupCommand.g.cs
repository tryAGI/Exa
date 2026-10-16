#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class WebhooksAttemptsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"webhooks-attempts", @"Webhooks Attempts endpoint commands.");
                         command.Subcommands.Add(WebhooksAttemptsWebhooksAttemptsListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}