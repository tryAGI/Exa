#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class MonitorsRunsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"monitors-runs", @"Monitors Runs endpoint commands.");
                         command.Subcommands.Add(MonitorsRunsMonitorsRunsGetCommandApiCommand.Create());
                         command.Subcommands.Add(MonitorsRunsMonitorsRunsListCommandApiCommand.Create());
        return command;
    }
}