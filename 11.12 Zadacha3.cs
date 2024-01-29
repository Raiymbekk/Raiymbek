using System;

// Создание первого пространства имен
namespace Company1
{
    // Класс Logger в первом пространстве имен
    public class Logger
    {
        // Метод Log в первом пространстве имен
        public void Log(string message)
        {
            Console.WriteLine("Logger 1: " + message);
        }
    }
}

// Создание второго пространства имен
namespace Company2
{
    // Класс Logger во втором пространстве имен
    public class Logger
    {
        // Метод Log во втором пространстве имен
        public void Log(string message)
        {
            Console.WriteLine("Logger 2: " + message);
        }
    }
}

class Zadacha3
{
    static void Main()
    {
        // Создание экземпляра класса Logger из первого пространства имен
        Company1.Logger logger1 = new Company1.Logger();
        // Вызов метода Log из первого пространства имен
        logger1.Log("Log message from Logger 1");

        // Создание экземпляра класса Logger из второго пространства имен
        Company2.Logger logger2 = new Company2.Logger();
        // Вызов метода Log из второго пространства имен
        logger2.Log("Log message from Logger 2");

        // Пауза, чтобы консольное окно не закрывалось сразу после вывода информации
        Console.ReadLine();
    }
}
