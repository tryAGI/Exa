#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class EnrichmentsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"enrichments", @"Enrichments endpoint commands.");
                         command.Subcommands.Add(EnrichmentsWebsetsEnrichmentsCancelCommandApiCommand.Create());
                         command.Subcommands.Add(EnrichmentsWebsetsEnrichmentsCreateCommandApiCommand.Create());
                         command.Subcommands.Add(EnrichmentsWebsetsEnrichmentsDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(EnrichmentsWebsetsEnrichmentsGetCommandApiCommand.Create());
                         command.Subcommands.Add(EnrichmentsWebsetsEnrichmentsUpdateCommandApiCommand.Create());
        return command;
    }
}