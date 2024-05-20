using SimpleCalculator;
using Xunit;

namespace SimpleCalculator.Tests
{
    public class CalcTests
    {
        private readonly Calc _calc;

        public CalcTests()
        {
            _calc = new Calc();
        }
        // add
        [Fact]
        public void Addition_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Addition(3, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Addition_DecimalNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Addition(6.4, 3.6);
            Assert.Equal(10, result);
        }

        [Fact]
        public void Addition_PositiveNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Addition(5, 3);
            Assert.Equal(8, result);
        }
        
        // divison
        [Fact]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Division(10, 0));
        }

        [Fact]
        public void Division_PositiveNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Division(18, 3);
            Assert.Equal(6, result);
        }

        public void Division_DecimalNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Division(-4.2, -2.1);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Division_NegativeNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Division(-4, -4);
            Assert.Equal(1, result);
        }

        // Multiplication

        [Fact]
        public void Multiplication_PositiveNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Multiplication(5, 3);
            Assert.Equal(15, result);
        }

        [Fact]
        public void Multiplication_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Multiplication(5, 2.8);
            Assert.Equal(14, result);
        }
        [Fact]
        public void Multiplication_DecimalNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Multiplication(3.2, 2.1);
            Assert.Equal(6.72, result, 2);
        }
        public void Multiplication_NegativeNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Multiplication(-5, -3);
            Assert.Equal(15, result);
        }

        // subtraction
        [Fact]
        public void Subtraction_Array_ReturnsCorrectResult()
        {
            double result = _calc.Subtraction(20, 3);
            Assert.Equal(17, result);
        }
        [Fact]
        public void Subtraction_DecimalNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Subtraction(10.3, 3.9);
            Assert.Equal(6.4, result);
        }
        [Fact]
        public void Subtraction_TwoNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Subtraction(5, 3);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Subtraction_NegativeNumbers_ReturnsCorrectResult()
        {
            double result = _calc.Subtraction(-10, -3);
            Assert.Equal(-7, result);
        }
    }
}
