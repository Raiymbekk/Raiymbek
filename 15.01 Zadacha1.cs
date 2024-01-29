using System;

class mathematics

{
    //int
    public int Сложение(int a, int b)
    {
        return a + b;
    }

    //double
    public double Сложение(double a, double b)
    {
        return a + b;
    }

    //конкатенация строк
    public string Сложение(string a, string b)
    {
        return a + b;
    }
}

class Primer1
{
    static void Main()
    {
        mathematics математика = new mathematics();

        // Использование метода сложения для целых чисел (int)
        int результатInt = математика.Сложение(5, 10);
        Console.WriteLine("Сложение int: " + результатInt);

        // Использование метода сложения для чисел с плавающей точкой (double)
        double результатDouble = математика.Сложение(3.5, 2.7);
        Console.WriteLine("Сложение double: " + результатDouble);

        // Использование метода сложения для строк (конкатенация строк)
        string результатString = математика.Сложение("Привет, ", "мир!");
        Console.WriteLine("Сложение string: " + результатString);
    }
}
