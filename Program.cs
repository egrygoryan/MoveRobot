// See https://aka.ms/new-console-template for more information

Point init = new Point(7, 3);
RobotPosition rp = new RobotPosition(init, Direction.North);
Robot greg = new Robot(rp);
greg.ExecuteInstruction("RAALAL");
Console.WriteLine(greg);