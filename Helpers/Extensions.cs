// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Helpers;

public static class Extensions
{
    public static void ForEachAction<T>(this IEnumerable<T> source, Action<T> action)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(action);
        using IEnumerator<T> e = source.GetEnumerator();
        while (e.MoveNext())
            action(e.Current);
    }
}