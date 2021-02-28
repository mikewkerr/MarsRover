using MarsRover.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverTests
{
    public class ParseStringToIntTests
    {
        public class TheParseMethod
        {
            [Theory]
            [InlineData("5", 5)]
            [InlineData("-1", -1)]
            [InlineData("m", 0)]
            [InlineData("", 0)]
            public void WithValue_ReturnsExpectedResult(string stringValue, int expected)
            {
                // Arrange
                // Act
                int actual = ParseStringToInt.Parse(stringValue);

                // Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
