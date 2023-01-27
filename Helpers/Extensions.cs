// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Helpers;

public static class Extensions
{
    public static void ExecuteActionForEachChar(this IEnumerable<char> source, Action<char> action)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(action);
        using IEnumerator<char> e = source.GetEnumerator();
        while (e.MoveNext())
            action(e.Current);
    }
}