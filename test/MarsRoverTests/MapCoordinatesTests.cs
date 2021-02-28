using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class MapCoordinatesTests
    {
        public class TheMapMethod
        {
            [Theory]
            [InlineData("5 5", new int[] { 5, 5 })]
            [InlineData("M 5", new int[] { 0, 5 })]
            [InlineData("m m", new int[] { 0, 0 })]
            [InlineData("5", new int[] { 5, 0 })]
            [InlineData("m", new int[] { 0, 0 })]
            [InlineData("", new int[] { 0, 0 })]
            public void WithValue_ReturnsExpectedResult(string inputString, int[] expected)
            {
                // Arrange
                int[] actual = new[] { 0, 0 };

                // Act
                actual = MapCoordinates.Map(inputString);

                // Assert
                Assert.Equal(expected, actual);
                Assert.Equal(expected[0], actual[0]);
                Assert.Equal(expected[1], actual[1]);
            }
        }
    }
}
