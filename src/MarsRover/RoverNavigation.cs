using System;

namespace MarsRover
{
    public class RoverNavigation
    {
        //Based on requirements, only 2 rovers exist.  Using variable so that way we can update one place, or assign via console.
        private const int NumberOfRovers = 2;
        private static int[] _upperRightCoordinates = new[] { 0, 0 };

        static void Main()
        {
            // Get upper right coordinates
            Console.Write("Enter Graph Upper Right Coordinate: ");
            RoverNavigation._upperRightCoordinates = MapCoordinates.Map(Console.ReadLine());

            Console.Write("\n");
            for (int rover = 1; rover <= RoverNavigation.NumberOfRovers; rover++)
            {
                // Obtain input from user to navigate rover
                Console.Write($"Rover {rover} Starting Position: ");
                string roverStartingPositon = Console.ReadLine();

                Console.Write($"Rover {rover} Movement Plan: ");
                string roverMovementPlan = Console.ReadLine();

                // Navigate current rover based on user input
                string result = NavigateRover.Navigate(roverStartingPositon, roverMovementPlan, RoverNavigation._upperRightCoordinates);

                // Print current rover and its final position
                Console.WriteLine($"Rover {rover} Output: {result}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("Navigation complete\n");
        }
    }
}
