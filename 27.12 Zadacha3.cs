using System;

class TemperatureSensor
{
    private double currentTemperature;

    public double CurrentTemperature
    {
        get { return currentTemperature; }
    }

    public void SimulateTemperatureReading(double simulatedTemperature)
    {
        // Метод для имитации считывания температуры
        currentTemperature = simulatedTemperature;
    }
}

class Zadacha3
{
    static void Main()
    {
        // Пример использования класса TemperatureSensor
        TemperatureSensor sensor = new TemperatureSensor();
        
        // Доступ к текущей температуре
        Console.WriteLine($"Current Temperature: {sensor.CurrentTemperature}");

        // Имитация считывания температуры
        sensor.SimulateTemperatureReading(25.5);
        Console.WriteLine($"Current Temperature: {sensor.CurrentTemperature}");
    }
}
