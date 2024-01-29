using System;

public class ImmutableClass
{
    private readonly int value;

    public ImmutableClass(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return value;
    }
}

class Zadacha4
{
    static void Main()
    {
        // Создание экземпляра неизменяемого класса
        ImmutableClass immutableInstance = new ImmutableClass(42);

        // Попытка изменения значения (неудачная из-за readonly)
        // immutableInstance.value = 50; // Эта строка вызовет ошибку компиляции

        // Вывод значения поля value
        Console.WriteLine("ImmutableClass's value: " + immutableInstance.GetValue());
    }
}
