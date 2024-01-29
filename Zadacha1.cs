using System;

class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}

class Zadacha1
{
    static void Main()
    {
        // Создание экземпляра класса Person
        Person personInstance = new Person("John Doe");

        // Использование метода GetName() для получения значения поля name
        string personName = personInstance.GetName();

        // Вывод значения поля name
        Console.WriteLine("Person's name: " + personName);
    }
}
