#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static partial class RunsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"runs", @"Runs endpoint commands.");
                         command.Subcommands.Add(RunsGetRunCommandApiCommand.Create());
                         command.Subcommands.Add(RunsListRunsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}