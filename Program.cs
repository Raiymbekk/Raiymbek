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
            
            # Ваш код выглядит правильным и выполняет задачу корректно. 
            # Однако, я бы порекомендовал добавить проверку на корректность ввода, чтобы обработать случаи, когда пользователь вводит нечисловые значения. 

                
            // Задача 2

            Console.Write("Радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Высота: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("V = " + Math.PI * r * r * height);
            Console.WriteLine("S = " + 2 * Math.PI * r * (height + r));

            #  В реальных приложениях было бы хорошо добавить проверки на корректность ввода, используя, например, double.TryParse, чтобы обработать такие случаи.

            // Задача 3
            Console.Write("Начальный капитал: ");
            double kapital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Процентная ставку: ");
            double stavka = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Кол-во Лет: ");
            double years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + kapital * Math.Pow((1 + stavka), years));
            
            # Ваш код выглядит правильным и выполняет задачу расчета конечного капитала при простом процентном наращивании.

            # Задача № 4 - ???

        }
    }

}
