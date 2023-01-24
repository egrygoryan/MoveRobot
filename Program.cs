// See https://aka.ms/new-console-template for more information

Point init = new Point(0, 0);
Robot greg = new Robot(init, Direction.South);
greg.ProceedCommand("AALAA");
Console.WriteLine(greg);