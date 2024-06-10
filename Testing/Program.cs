namespace Testing
{
    public class Program
    {

        public class Calculator
        {
            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                return a / b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
