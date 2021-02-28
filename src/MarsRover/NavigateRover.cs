using MarsRover.Helper;
using System.Collections.Generic;

namespace MarsRover
{
    public static class NavigateRover
    {
        public static string Navigate(string startingPositions, string movementPlan, int[] upperRightCoordinates)
        {
            string[] startingPosition = startingPositions.Split(' ');
            int[] currentCoordinates = GetStartingCoordinates(startingPosition);
            string currentDirection = DetermineStartingDirection(startingPosition);

            foreach (char ch in movementPlan)
            {
                string character = ch.ToString().ToLower();

                switch (character)
                {
                    case "r":
                        currentDirection = TurnRover.Turn(character, currentDirection);
                        break;
                    case "l":
                        currentDirection = TurnRover.Turn(character, currentDirection);
                        break;
                    case "m":
                        currentCoordinates = MoveRover.Move(currentDirection, currentCoordinates, upperRightCoordinates);
                        break;
                    default:
                        // Left default case to allow an unexpected entry to just be ignored.
                        break;
                }
            }

            return $"{currentCoordinates[0].ToString()} {currentCoordinates[1].ToString()} {currentDirection.ToUpper()}";
        }

        private static int[] GetStartingCoordinates(IReadOnlyList<string> startingPositions)
        {
            int[] currentCoordinates = { 0, 0 };

            currentCoordinates[0] = string.IsNullOrWhiteSpace(startingPositions[0]) ? 0 : ParseStringToInt.Parse(startingPositions[0]);
            currentCoordinates[1] = startingPositions.Count < 2 || string.IsNullOrWhiteSpace(startingPositions[1]) ? 0 : ParseStringToInt.Parse(startingPositions[1]);

            return currentCoordinates;
        }

        private static string DetermineStartingDirection(IReadOnlyList<string> startingPosition)
        // This method is necessary to assure that only one of the 4 directions is used to start, otherwise it defaults to North.
        {
            int arrayLength = startingPosition.Count;
            const string defaultResult = "N";

            if (arrayLength < 3)
                return string.IsNullOrWhiteSpace(startingPosition[arrayLength - 1]) ? "N" : startingPosition[arrayLength - 1];

            if (string.IsNullOrWhiteSpace(startingPosition[2]))
                return defaultResult;

            string result = startingPosition[2];

            if (result.ToLower() == "n" || result.ToLower() == "e" || result.ToLower() == "s" || result.ToLower() == "w")
                return result;

            return defaultResult;
        }
    }
}
