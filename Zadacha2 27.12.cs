using System;

class Shape
{
    public string Color { get; set; }
    public double CenterX { get; set; }
    public double CenterY { get; set; }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Square : Shape
{
    public double SideLength { get; set; }

    public double CalculateArea()
    {
        return SideLength * SideLength;
    }
}

class Zadacha2
{
    static void Main()
    {
        // Пример использования классов для круга и квадрата
        Circle circle = new Circle { Color = "Red", CenterX = 0, CenterY = 0, Radius = 5 };
        Square square = new Square { Color = "Blue", CenterX = 0, CenterY = 0, SideLength = 4 };

        Console.WriteLine($"Circle Area: {circle.CalculateArea()}, Color: {circle.Color}");
        Console.WriteLine($"Square Area: {square.CalculateArea()}, Color: {square.Color}");
    }
}
