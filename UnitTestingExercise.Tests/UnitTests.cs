using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(6, 8, 90, 104)]
        [InlineData(67, 34, 54, 155)]
        [InlineData(4, 4, 4, 12)]
        [InlineData(1, 3, 5, 9)]
        [InlineData(8, 18, 23, 49)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 6, 1)]//Add test data <-------
        [InlineData(18, 7, 11)]
        [InlineData(45, 6, 39)]
        [InlineData(103, 53, 50)]
        [InlineData(32, 18, 14)]
        [InlineData(67, 21, 46)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 7, 42)]//Add test data <-------
        [InlineData(13, 4, 52)]
        [InlineData(45, 6, 270)]
        [InlineData(21, 3, 63)]
        [InlineData(89, 2, 178)]
        [InlineData(56, 5, 280)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(42, 7, 6)]//Add test data <-------
        [InlineData(32, 8, 4)]
        [InlineData(21, 7, 3)]
        [InlineData(18, 9, 2)]
        [InlineData(66, 11, 6)]
        [InlineData(80, 10, 8)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
