#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class WebhooksAttemptsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhooks-attempts", @"Webhooks Attempts endpoint commands.");
                         command.Subcommands.Add(WebhooksAttemptsWebhooksAttemptsListCommandApiCommand.Create());
        return command;
    }
}