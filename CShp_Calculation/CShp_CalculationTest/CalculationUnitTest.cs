using CShp_Calculation;
using Xunit;

namespace CShp_CalculationTest
{
    public class CalculationUnitTest
    {
        [Fact]
        public void Sum_TwoDouble_ReturnDouble()
        {
            // Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 6;

            // Act
            var soma = Calculation.Sum(num1, num2);

            // Assert
            Assert.Equal(expectedValue, soma);
        }

        [Fact]
        public void Subtract_TwoDouble_ReturnDouble()
        {
            // Arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = -0.2;

            // Act  
            var subtraction = Calculation.Subtract(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, subtraction, 1);
        }

        [Fact]
        public void Mutiply_TwoDouble_ReturnDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 8.99;

            // Act
            var mult = Calculation.Multiply(num1, num2);

            // Assert
            Assert.Equal(expectedValue, mult, 2);
        }

        [Fact]
        public void Divide_TwoDouble_ReturnDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 0.94; // Rounded value 
            
            // Act  
            var div = Calculation.Divide(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, div, 2);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, 1, int.MinValue+1)]
        public void Sum_TwoRelativeNumbers_ReturnRelativeNumber(int num1, int num2, int expectedValue)
        {
            //Act
            var result = Calculation.Sum(num1, num2);
            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}
