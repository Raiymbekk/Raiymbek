using System;

namespace project{

    class Programm {

        static void Main(){

        // Задача 1

            Console.Write("Введите количество часов: ");
            int h = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Введите количество минут: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество секунд: ");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Все время в секундах: " + ((h * 3600) + (m * 60) + s) + " секунд");

            // Задача 2

            Console.Write("Радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Высота: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("V = " + Math.PI * r * r * height);
            Console.WriteLine("S = " + 2 * Math.PI * r * (height + r));

            // Задача 3
            Console.Write("Начальный капитал: ");
            double kapital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Процентная ставку: ");
            double stavka = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Кол-во Лет: ");
            double years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + kapital * Math.Pow((1 + stavka), years));


        }
    }

}
