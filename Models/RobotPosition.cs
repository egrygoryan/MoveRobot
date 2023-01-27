namespace MoveRobot.Models;

public class RobotPosition
{
    public Point Position { get; private set; }
    public Direction CurrentDirection { get; private set; }
    public RobotPosition(Point position, Direction direction) => 
        (Position, CurrentDirection) = (position, direction);
    public void ChangeDirection(Direction initDirection, Rotation rotate) =>
        CurrentDirection = (initDirection, rotate) switch
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
    public void Move() =>
        _ = CurrentDirection switch
        {
            Direction.North => Position.Y++,
            Direction.East => Position.X++,
            Direction.South => Position.Y--,
            Direction.West => Position.X--,
        };
    public override string ToString() => $"{Position}, direction: {CurrentDirection}";
}