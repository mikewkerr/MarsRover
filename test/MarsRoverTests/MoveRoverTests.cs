using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class MoveRoverTests
    {
        public class TheMoveMethod
        {
            [Theory]
            [InlineData("N", new[] { 0, 0 }, new[] { 5, 5 }, new[] { 0, 1 })]
            [InlineData("E", new[] { 0, 0 }, new[] { 5, 5 }, new[] { 1, 0 })]
            [InlineData("S", new[] { 0, 0 }, new[] { 5, 5 }, new[] { 0, 0 })]
            [InlineData("W", new[] { 0, 0 }, new[] { 5, 5 }, new[] { 0, 0 })]
            [InlineData("N", new[] { 5, 5 }, new[] { 5, 5 }, new[] { 5, 5 })]
            [InlineData("E", new[] { 5, 5 }, new[] { 5, 5 }, new[] { 5, 5 })]
            [InlineData("S", new[] { 5, 5 }, new[] { 5, 5 }, new[] { 5, 4 })]
            [InlineData("W", new[] { 5, 5 }, new[] { 5, 5 }, new[] { 4, 5 })]
            public void WithValue_ReturnsExpectedResult(string currentDirection, int[] currentCoordinates, int[] upperRightCoordinates, int[] expected)
            {
                // Arrange
                int[] actual = new[] { 0, 0 };

                // Act
                actual = MoveRover.Move(currentDirection, currentCoordinates, upperRightCoordinates);

                // Assert
                Assert.Equal(expected, actual);
                Assert.Equal(expected[0], actual[0]);
                Assert.Equal(expected[1], actual[1]);
            }
        }
    }
}
