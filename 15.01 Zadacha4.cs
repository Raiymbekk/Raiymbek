﻿using System;

class ГеометрическаяФигура
{
    // Метод для расчета площади круга
    public double Площадь(double радиус)
    {
        return Math.PI * Math.Pow(радиус, 2);
    }

    // Метод для расчета площади прямоугольника
    public double Площадь(double длина, double ширина)
    {
        return длина * ширина;
    }

    // Метод для расчета площади треугольника
    public double Площадь(double основание, double высота, double длина_стороны)
    {
        // Формула Герона для расчета площади треугольника по длинам его сторон
        double полупериметр = (основание + высота + длина_стороны) / 2;
        return Math.Sqrt(полупериметр * (полупериметр - основание) * (полупериметр - высота) * (полупериметр - длина_стороны));
    }
}

class Primer4
{
    static void Main()
    {
        ГеометрическаяФигура фигура = new ГеометрическаяФигура();

        // Расчет площади круга
        double площадьКруга = фигура.Площадь(5);
        Console.WriteLine("Площадь круга: " + площадьКруга);

        // Расчет площади прямоугольника
        double площадьПрямоугольника = фигура.Площадь(4, 6);
        Console.WriteLine("Площадь прямоугольника: " + площадьПрямоугольника);

        // Расчет площади треугольника
        double площадьТреугольника = фигура.Площадь(3, 4, 5);
        Console.WriteLine("Площадь треугольника: " + площадьТреугольника);
    }
}
