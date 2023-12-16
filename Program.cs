using System;

namespace CarSimulationProject.Domain
{


    public class Program
    {
        static void Main()
        {
            // Read input

            string[] fieldSize = Console.ReadLine().Split(' ');

            int width = int.Parse(fieldSize[0]);
            int height = int.Parse(fieldSize[1]);

            string[] initialPosition = Console.ReadLine().Split(' ');
            int x = int.Parse(initialPosition[0]);
            int y = int.Parse(initialPosition[1]);
            char direction = char.Parse(initialPosition[2]);

            string commands = Console.ReadLine();

            // Process commands
            var car = new Domain.AutoDrivingCarSimulator(x, y, direction);
            var result =car.ExecuteCommands(commands, width, height);

            // Output final position and direction
            Console.WriteLine($"Final position:({result.Item1},{result.Item2}) , Final direction: {result.Item3}");
           
            Console.ReadLine();
        }
    }

}


