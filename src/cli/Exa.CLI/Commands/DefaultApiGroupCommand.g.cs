#nullable enable

using System.CommandLine;

namespace Exa.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(AnswerCommandApiCommand.Create());
                         command.Subcommands.Add(AnswerAsStreamCommandApiCommand.Create());
                         command.Subcommands.Add(FindSimilarCommandApiCommand.Create());
                         command.Subcommands.Add(GetContentsCommandApiCommand.Create());
                         command.Subcommands.Add(SearchCommandApiCommand.Create());
                         command.Subcommands.Add(SearchAsStreamCommandApiCommand.Create());
        return command;
    }
}