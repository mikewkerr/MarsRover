using MarsRover.Helper;

namespace MarsRover
{
    public static class MapCoordinates
    {
        public static int[] Map(string coordinateInput)
        {
            int[] coordinates = new[] { 0, 0 };
            string[] coordinateList = coordinateInput.Split(' ');

            coordinates[0] = ParseStringToInt.Parse(coordinateList[0]);
            coordinates[1] = (coordinateList.Length == 1 || string.IsNullOrWhiteSpace(coordinateList[1])) ? 0 : ParseStringToInt.Parse(coordinateList[1]);

            return coordinates;
        }
    }
}
