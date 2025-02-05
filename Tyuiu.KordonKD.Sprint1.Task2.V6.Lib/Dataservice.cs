using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KordonKD.Sprint1.Task2.V6.Lib
{
    public class Dataservice : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            return (value / 1000) + (value % 1000) * 0.001;
        }
    }
}
