using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint1.Task3.V15.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataservice ds = new Dataservice();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Кордон Ксения Дмитриевна  | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите скорость первого автомобиля (км/ч): ");
            double V1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость второго автомобиля (км/ч): ");
            double V2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите начальное расстояние между автомобилями (км): ");
            double S = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите время в пути (часы): ");
            double T = Convert.ToDouble(Console.ReadLine());
            double result = DistanceOverTime(V1, V2, S, T);

            Console.WriteLine($"Расстояние между автомобилями через {T} часов: {result:F3} км");
            static double DistanceOverTime(double V1, double V2, double S, double T);
            double distanceMoved = (V1 + V2) * T;
            double totalDistance = S + distanceMoved;
            return totalDistance;


        }
    }
}
