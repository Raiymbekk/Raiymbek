using System;

// Создание пространства имен Utils
namespace Utils
{
    // Класс Helper в пространстве имен Utils
    public class Helper
    {
        // Статический метод PrintMessage
        public static void PrintMessage(string message)
        {
            Console.WriteLine("Message from Utils.Helper: " + message);
        }
    }
}

class Zadacha4
{
    static void Main()
    {
        // Импорт пространства имен Utils
        using Utils;

        // Вызов метода PrintMessage без явного указания пространства имен
        Helper.PrintMessage("Hello from Helper");

        // Пауза, чтобы консольное окно не закрывалось сразу после вывода информации
        Console.ReadLine();
    }
}
