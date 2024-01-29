using System;

// Создание пространства имен Company.Project
namespace Company.Project
{
    // Объявление класса Employee
    public class Employee
    {
        // Поля класса
        public string Name;
        public string Position;
    }
}

class Zadacha1
{
    static void Main()
    {
        // Создание экземпляра класса Employee
        Company.Project.Employee employee = new Company.Project.Employee();

        // Установка значений полей
        employee.Name = "Alan";
        employee.Position = "NeAlan";

        // Вывод информации о сотруднике
        Console.WriteLine("Employee Name: " + employee.Name);
        Console.WriteLine("Employee Position: " + employee.Position);

        // Пауза, чтобы консольное окно не закрывалось сразу после вывода информации
        Console.ReadLine();
    }
}
