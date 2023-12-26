// MathLibrary/Calculator.cs

namespace MathLibrary
{
    public class Calculator
    {

        private double result;

        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double GetResult()
        {
            return result;
        }
    }
}
