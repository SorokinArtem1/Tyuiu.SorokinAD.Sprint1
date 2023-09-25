using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint1.Task4.V7.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #1| Выполнил: Сорокин А. Д. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;
            Console.WriteLine("Введите переменную x: ");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите переменную y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Высчитывания по формуле (1+√(x*y))/((x-3*y)^2) дали результат = " + ds.Calculate(x,y));
            Console.ReadKey(); 

        }
    }
}
