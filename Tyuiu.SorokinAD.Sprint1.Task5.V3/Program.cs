using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            DataService ds = new DataService();



            Console.Title = "Спринт #1| Выполнил: Сорокин А. Д. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, присваивает переменной k третью с конца    *");
            Console.WriteLine("* цифру в записи положительного целого числа k                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите переменную k больше 99");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Третья цифра с конца числа {k} : {ds.Calculate(k)}");
            Console.ReadKey();


        }
    }
}
