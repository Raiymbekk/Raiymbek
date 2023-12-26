using System;
using MathLibrary;

class Program
{
    static void Main()
    {
        // Создаем экземпляр класса Calculator
        Calculator calculator = new Calculator();

        AdvancedCalculator advancedCalculator = new AdvancedCalculator();

        // Используем методы для выполнения математических операций
        int a = calculator.Plus(5, 3);
        Console.WriteLine($"5 + 3 = {a}");

        int b = calculator.Minus(8, 3);
        Console.WriteLine($"8 - 3 = {b}");

        int c = calculator.Multiply(4, 6);
        Console.WriteLine($"4 * 6 = {c}");

        double d = calculator.Divide(9, 3);
        Console.WriteLine($"9 / 3 = {d}");

        // Используем методы AdvancedCalculator
        double resultPower = advancedCalculator.Power(2, 3);
        Console.WriteLine($"2^3 = {resultPower}");

        double resultSquareRoot = advancedCalculator.SquareRoot(25);
        Console.WriteLine($"Square Root of 25 = {resultSquareRoot}");
    }
}