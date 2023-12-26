using System;

namespace MathLibrary
{
    public class AdvancedCalculator : Calculator
    {
        // Метод для возведения числа в указанную степень
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

        // Метод для извлечения квадратного корня из числа
        public double SquareRoot(double number)
        {
            if (number >= 0)
            {
                return Math.Sqrt(number);
            }
            else
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }
        }
    }
}