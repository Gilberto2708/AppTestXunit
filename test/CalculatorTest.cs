using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using console;
using Xunit;

namespace test
{
    public class CalculatorTest
    {


        // A test function to verify that the Sum method returns the correct sum of two given numbers.

        [Fact]
        public void Sum_GivenTwoNumbers_ReturnsTheirSum()
        {
            // Arrange
            var calculator = new Calculator();
            const int x = 5;
            const int y = 10;

            // Act
            var sum = calculator.Sum(x, y);

            // Assert
            Assert.Equal(x + y, sum);

        }
        [Fact]
        public void Sum_0_4()
        {
            // Arrange
            var calculator = new Calculator();
            const int x = 0;
            const int y = 4;

            // Act
            var sum = calculator.Sum(x, y);

            // Assert
            Assert.Equal(4, sum);

        }

    }

}

