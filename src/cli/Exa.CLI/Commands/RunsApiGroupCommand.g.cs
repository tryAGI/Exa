#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class RunsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"runs", @"Runs endpoint commands.");
                         command.Subcommands.Add(RunsGetRunCommandApiCommand.Create());
                         command.Subcommands.Add(RunsListRunsCommandApiCommand.Create());
        return command;
    }
}