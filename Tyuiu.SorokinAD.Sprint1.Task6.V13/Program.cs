using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SorokinAD.Sprint1.Task6.V13.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            DataService ds = new DataService();


            Console.Title = "Спринт #1| Выполнил: Сорокин А. Д. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил Сорокин А. Д. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что буквы строки упорядочены по алфавиту.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");





            Console.WriteLine("Введите слово, я проверю в алфавитном ли порядке расположены буквы этого слова: ");

            value = Convert.ToString(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Резльтат                                                                *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckWordsAlphabet(value) == false)
            {
                Console.WriteLine($"Буквы в данном слове расположены не в алфавитном порядке");
            }
            else
            {
                Console.WriteLine("Буквы в данном слове расположены в алфавитном порядке");

            }
            Console.ReadKey();
                
        }
    }
}
