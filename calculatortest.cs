using Xunit;

namespace Calculator
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 7;

            // when
            int result = calc.Add(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestSub()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 3;

            // when
            int result = calc.Sub(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestMulti()
        {
            // given
            Calculator calc = new Calculator();
            int a = 5;
            int b = 2;
            int expectedResult = 10;

            // when
            int result = calc.multi(a, b);

            // then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestDivi()
        {
            // given
            Calculator calc = new Calculator();
            int a = 6;
            int b = 2;
            int expectedResult = 3;

            // when
            int result = calc.divi(a, b);

            // then
            Assert.Equal(expectedResult, result);
            
        }
        
        [Fact]
        public void TestDivi_DivideByZero()
        {
            // given
            Calculator calc = new Calculator();
            int a = 6;
            int b = 0;

            // when and then
            Assert.Throws<DivideByZeroException>(() => calc.divi(a, b));
        }
        [Fact]
        public void TestDivi_Decimal()
        {
            // Given
            Calculator calc = new Calculator();
            double a = 5;
            double b = 2;
            double expectedResult = 5.0 / 2.0; 

            // When
            double result = calc.divis(a, b);

            // Then
            Assert.Equal(expectedResult, result); 
        }
    }
}
