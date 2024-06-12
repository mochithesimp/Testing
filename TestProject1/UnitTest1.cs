using static Testing.Program;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Divide_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double a = 10;
            double b = 2;

            // Act
            double result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(100, result);
        }

        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectResult()
        {

            double a = -10;
            double b = 2;


            double result = Calculator.Divide(a, b);


            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Divide_NegativeNumber_ReturnsCorrectResult()
        {

            double a = -10;
            double b = 5;


            double result = Calculator.Divide(a, b);


            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {

            double a = 10;
            double b = 0;

            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
        }
    }
}