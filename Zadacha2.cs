using System;

class Vehicle
{
    protected int speed;

    public Vehicle(int speed)
    {
        this.speed = speed;
    }
}

class Car : Vehicle
{
    public Car(int speed) : base(speed)
    {
    }

    public int GetSpeed()
    {
        return speed;
    }
}

class Zadacha2
{
    static void Main()
    {
        // Создание объекта класса Car и вызов метода GetSpeed()
        Car carInstance = new Car(60);
        int carSpeed = carInstance.GetSpeed();

        // Вывод значения скорости
        Console.WriteLine("Car's speed: " + carSpeed);
    }
}
