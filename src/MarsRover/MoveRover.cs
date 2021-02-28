using System.Collections.Generic;

namespace MarsRover
{
    public static class MoveRover
    {
        public static int[] Move(string currentDirection, int[] currentCoordinates, int[] upperRightCoordinates)
        {
            int tempCoordinate;

            switch (currentDirection.ToLower())
            {
                case "n":
                    tempCoordinate = currentCoordinates[1] + 1;
                    if (CheckBounds(tempCoordinate, "Y", upperRightCoordinates))
                        currentCoordinates[1] = tempCoordinate;
                    break;
                case "e":
                    tempCoordinate = currentCoordinates[0] + 1;
                    if (CheckBounds(tempCoordinate, "X", upperRightCoordinates))
                        currentCoordinates[0] = tempCoordinate;
                    break;
                case "s":
                    tempCoordinate = currentCoordinates[1] - 1;
                    if (CheckBounds(tempCoordinate, "Y", upperRightCoordinates))
                        currentCoordinates[1] = tempCoordinate;
                    break;
                case "w":
                    tempCoordinate = currentCoordinates[0] - 1;
                    if (CheckBounds(tempCoordinate, "X", upperRightCoordinates))
                        currentCoordinates[0] = tempCoordinate;
                    break;
                default:
                    // Left default case to allow an invalid direction to just be ignored.
                    break;
            }

            return currentCoordinates;
        }

        private static bool CheckBounds(int coordinate, string axis, IReadOnlyList<int> upperRightCoordinates)
        {
            switch (axis)
            {
                case "X" when (coordinate < 0 || coordinate > upperRightCoordinates[0]):
                case "Y" when (coordinate < 0 || coordinate > upperRightCoordinates[1]):
                    return false;
                default:
                    // Left default case to allow an invalid entry to just be ignored.
                    break;
            }

            return true;
        }
    }
}
