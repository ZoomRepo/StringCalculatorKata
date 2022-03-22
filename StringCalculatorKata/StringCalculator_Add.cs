using Xunit;

namespace StringCalculatorKata
{
    public class StringCalculator_Add
    {
        private StringCalculator _calculator = new StringCalculator();

        [Fact]
        public void GivenEmptyStringReturnsZero()
        {
            //Act
            var result = _calculator.Add("");

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("5", 5)]

        public void GivenXStringReturnsX(string inputParam, int expectedResult)
        {
            //Act
            var result = _calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("7,2,3", 12)]
        [InlineData("-1,6", "Negatives not allowed: -1")]
        public void GivenXNumbersCommaSeparatedReturnsSum(string inputParam, object expectedResult)
        {
            //Act
            var result = _calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n4\n5\n1", 11)]
        public void NewLineShouldBeInterpretedAsDelimeter(string inputParam, int expectedResult)
        {
            //Act
            var result = _calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void CustomDelimeterDefinedOnFirstLine(string inputParam, int expectedResult)
        {
            //Act
            var result = _calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n-1;2;-3", "Negatives not allowed: -1, -3")]
        public void CallingAddWithNegativeNumbersWillThrowException(string inputParam, string expectedResult)
        {
            //Act
            var result = _calculator.Add(inputParam);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}