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
    }
}