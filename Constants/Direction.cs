// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Constants;

public enum Direction
{
    North = 1 << 0,
    East = 1 << 1,
    South = 1 << 2,
    West = 1 << 3
}