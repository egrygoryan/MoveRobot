// See https://aka.ms/new-console-template for more information
namespace MoveRobot.Models;

public class Robot
{
    public RobotPosition RobotPosition { get; set; }
    public Robot(RobotPosition robotPosition) => RobotPosition = robotPosition;
    public void ExecuteInstruction(string instructions)
    {
        if (!CommandValidator.ValidateCommand(instructions))
        {
            throw new ArgumentException("Invalid instructions");
        }
        instructions.ExecuteActionForEachChar(c =>
        {
            switch (c)
            {
                case TurnRight:
                    RobotPosition.ChangeDirection(RobotPosition.CurrentDirection, Rotation.Right);
                    break;
                case TurnLeft:
                    RobotPosition.ChangeDirection(RobotPosition.CurrentDirection, Rotation.Left);
                    break;
                case Advance:
                    RobotPosition.Move();
                    break;
            }
        });
    }

    public override string ToString() => RobotPosition.ToString();
}