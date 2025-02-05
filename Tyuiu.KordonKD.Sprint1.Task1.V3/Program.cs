﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KordonKD.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataservice ds = new Dataservice();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Кордон Ксения Дмитриевна  | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (x-y)/(x+3)+3 и печатает его на экране.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*   (x - y) / (x + 3) + 3                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
