using System;

// Создание пространства имен Company.Project
namespace Company.Project
{
    // Создание вложенного пространства имен Utilities
    namespace Utilities
    {
        // Объявление класса Calculator
        public class Calculator
        {
            // Метод для сложения двух чисел
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}

class Zadacha2
{
    static void Main()
    {
        // Создание экземпляра класса Calculator из вложенного пространства имен Utilities
        Company.Project.Utilities.Calculator calculator = new Company.Project.Utilities.Calculator();

        // Вызов метода Add и вывод результата
        int result = calculator.Add(5, 7);
        Console.WriteLine("Result of addition: " + result);

        // Пауза, чтобы консольное окно не закрывалось сразу после вывода информации
        Console.ReadLine();
    }
}
