using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BratsunDA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1| Выполнил: Брацун Д.А. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил Брацун Д.А. | ПКТБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет полное количество часов,         *");
            Console.WriteLine("* прошедших от начала суток до момента когда часовая стрелка              *");
            Console.WriteLine("* повернулась на f градусов.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double f;

            Console.WriteLine("Введите на сколько градусов повернулась стрелка часов: ");
            f = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (f > 0 && f < 360)
            {
                Console.WriteLine("Прошло " + ds.AngleToHoursMinutes(f) + " часов.");
            }
            else
            {
                Console.WriteLine("Градусная величина должна быть от 0 до 360 градусов.");
            }

            Console.ReadKey();
        }
    }
}
