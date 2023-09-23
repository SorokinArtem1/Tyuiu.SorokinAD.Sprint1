using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint1.Task2.V10.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task2.V10
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* и преобразует расстояние в метрах в расстояние в дюймах.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите расстояние в метрах:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расстояние в дюймах = " + ds.ConvertMetreToInchs(x));

            Console.ReadKey();

        }
    }
}
