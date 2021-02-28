using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class NavigateRoverTests
    {
        public class TheNavigateMethod
        {
            [Theory]
            [InlineData("1 2 N", "LMLMLMLMM", new[] { 5, 5 }, "1 3 N")]
            [InlineData("3 3 E", "MMRMMRMRRM", new[] { 5, 5 }, "5 1 E")]
            [InlineData("10 E", "MMMRMMLM", new[] { 10, 10 }, "10 0 E")]
            [InlineData("", "", new[] { 0, 0 }, "0 0 N")] // Default int array is 0, 0 because Map Coordinates handles this
            public void WithInput_ReturnsExpectedResult(string startingPositions, string movementPlan, int[] upperRightCoordinates, string expected)
            {
                // Arrange
                // Act
                string actual = NavigateRover.Navigate(startingPositions, movementPlan, upperRightCoordinates);

                // Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
