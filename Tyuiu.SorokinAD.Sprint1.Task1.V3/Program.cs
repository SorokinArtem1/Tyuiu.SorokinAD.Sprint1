using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint1.Task1.V3.Lib;


namespace Tyuiu.SorokinAD.Sprint1.Task1.V3
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* и вычисляет объем параллелепипеда                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");




            double lenght, width, height;
            Console.WriteLine("Введите длину в сантиметрах");
            lenght = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("Введите ширину в сантиметрах");
            width = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("Введите высоту в сантиметрах");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Объем Параллелепипеда = " + ds.ParallelepipedVolume(lenght,width,height) +" см.куб");

            Console.ReadKey();

        }
    }
}
