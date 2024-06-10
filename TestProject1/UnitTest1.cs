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
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double a = -10;
            double b = 2;

            // Act
            double result = Calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double a = 10;
            double b = 0;

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
        }
    }
}