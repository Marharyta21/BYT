using NUnit.Framework;

namespace BYT

{
    public class CalculatorTests
    {
        [Test]
        public void TestAddition_PositiveNumbers()
        {
            Calculator calc = new Calculator(10, 5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(15));
        }

        [Test]
        public void TestAddition_NegativeNumbers()
        {
            Calculator calc = new Calculator(-10, -5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(-15));
        }

        [Test]
        public void TestAddition_WithZero()
        {
            Calculator calc = new Calculator(10, 0, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestAddition_Decimals()
        {
            Calculator calc = new Calculator(10.5, 5.3, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(15.8).Within(0.001));
        }
        
        [Test]
        public void TestSubtraction_PositiveNumbers()
        {
            Calculator calc = new Calculator(10, 5, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestSubtraction_NegativeResult()
        {
            Calculator calc = new Calculator(5, 10, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(-5));
        }

        [Test]
        public void TestSubtraction_WithZero()
        {
            Calculator calc = new Calculator(10, 0, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestSubtraction_NegativeNumbers()
        {
            Calculator calc = new Calculator(-10, -5, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(-5));
        }
        
        [Test]
        public void TestMultiplication_PositiveNumbers()
        {
            Calculator calc = new Calculator(10, 5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestMultiplication_ByZero()
        {
            Calculator calc = new Calculator(10, 0, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }

        [Test]
        public void TestMultiplication_NegativeNumbers()
        {
            Calculator calc = new Calculator(-10, -5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestMultiplication_PositiveAndNegative()
        {
            Calculator calc = new Calculator(10, -5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(-50));
        }

        [Test]
        public void TestMultiplication_Decimals()
        {
            Calculator calc = new Calculator(2.5, 4, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(10).Within(0.001));
        }
        
        [Test]
        public void TestDivision_PositiveNumbers()
        {
            Calculator calc = new Calculator(10, 5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivision_WithRemainder()
        {
            Calculator calc = new Calculator(10, 3, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(3.333).Within(0.001));
        }

        [Test]
        public void TestDivision_NegativeNumbers()
        {
            Calculator calc = new Calculator(-10, -5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivision_PositiveAndNegative()
        {
            Calculator calc = new Calculator(10, -5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void TestDivision_ByZero_ThrowsException()
        {
            Calculator calc = new Calculator(10, 0, "/");
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void TestDivision_ZeroByNumber()
        {
            Calculator calc = new Calculator(0, 5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }
        
        [Test]
        public void TestInvalidOperation_ThrowsException()
        {
            Calculator calc = new Calculator(10, 5, "%");
            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperation_EmptyString()
        {
            Calculator calc = new Calculator(10, 5, "");
            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperation_RandomString()
        {
            Calculator calc = new Calculator(10, 5, "abc");
            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }
        
        [Test]
        public void TestLargeNumbers_Addition()
        {
            Calculator calc = new Calculator(1000000, 2000000, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(3000000));
        }

        [Test]
        public void TestLargeNumbers_Multiplication()
        {
            Calculator calc = new Calculator(1000, 1000, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(1000000));
        }

        [Test]
        public void TestVerySmallDecimals()
        {
            Calculator calc = new Calculator(0.001, 0.002, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(0.003).Within(0.0001));
        }
    }
}