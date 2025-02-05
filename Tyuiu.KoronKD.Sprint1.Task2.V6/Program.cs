using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KoronKD.Sprint1.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dataservice ds = new Dataservice();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value;

            Console.WriteLine("Введите значение Value:");
            value = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние в километрах " + ds.ConvertMToKm(value));

            Console.ReadLine();
        }
    }
}
