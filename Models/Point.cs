// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Models;
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"X position: {X}, Y position: {Y}";
    }
}
