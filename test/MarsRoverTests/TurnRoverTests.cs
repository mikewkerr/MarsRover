using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class TurnRoverTests
    {
        public class TheTurnMethod
        {
            [Theory]
            [InlineData("R", "N", "e")]
            [InlineData("r", "n", "e")]
            [InlineData("r", "e", "s")]
            [InlineData("r", "s", "w")]
            [InlineData("r", "w", "n")]
            [InlineData("l", "w", "s")]
            [InlineData("l", "s", "e")]
            [InlineData("l", "e", "n")]
            [InlineData("l", "n", "w")]
            [InlineData("x", "n", "n")]
            public void WithValue_ReturnsExpectedResult(string directionToTurn, string currentDirection, string expected)
            {
                // Act
                string actual = TurnRover.Turn(directionToTurn, currentDirection);

                // Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
