using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculator_Add
    {
        [Fact]
        public void GivenEmptyStringReturnsZero()
        {
            //
            var calc = new StringCalculator();

            //Act
            var result = calc.Add("");

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("5", 5)]

        public void GivenXStringReturnsX(string inputParam, int expectedResult)
        {
            //Arrange
            var calc = new StringCalculator();

            //Act
            var result = calc.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        public void GivenTwoNumbersReturnsSum(string inputParam, int expectedResult)
        {
            //Arrange
            var calculator = new StringCalculator();

            //Act
            var result = calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}