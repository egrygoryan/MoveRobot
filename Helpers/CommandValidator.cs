// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Helpers;

public static class CommandValidator
{
    private static readonly string _allowedCommands = "RLA";
    public static bool ValidateCommand(string command)
    {
        ArgumentNullException.ThrowIfNull(command);

        return command.All(c => _allowedCommands.Contains(c));
    }
}
