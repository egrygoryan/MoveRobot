// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Models;
public class Robot
{
    public Point Position { get; private set; }
    public Direction CurrentDirection { get; private set; }
    public Robot(Point initPosition, Direction initDirection) =>
        (Position, CurrentDirection) = (initPosition, initDirection);
    public void ProceedCommand(string command)
    {
        if (!CommandValidator.ValidateCommand(command))
        {
            throw new ArgumentException("Invalid command");
        }
        command.ForEachAction(c =>
        {
            switch (c)
            {
                case 'R':
                    CurrentDirection = ChangeDirection(CurrentDirection, Rotation.Right);
                    break;
                case 'L':
                    CurrentDirection = ChangeDirection(CurrentDirection, Rotation.Left);
                    break;
                case 'A':
                    Move();
                    break;
            }
        });

    }
    private Direction ChangeDirection(Direction initDirection, Rotation rotate) =>
        (initDirection, rotate) switch
        {
            (Direction.North, Rotation.Right) => Direction.East,
            (Direction.North, Rotation.Left) => Direction.West,
            (Direction.East, Rotation.Right) => Direction.South,
            (Direction.East, Rotation.Left) => Direction.North,
            (Direction.South, Rotation.Right) => Direction.West,
            (Direction.South, Rotation.Left) => Direction.East,
            (Direction.West, Rotation.Right) => Direction.North,
            (Direction.West, Rotation.Left) => Direction.South,
        };
    private void Move() =>
        _ = CurrentDirection switch
        {
            Direction.North => Position.Y++,
            Direction.East => Position.X++,
            Direction.South => Position.Y--,
            Direction.West => Position.X--,
        };

    public override string ToString()
    {
        return $"{Position}, direction: {CurrentDirection}";
    }
}