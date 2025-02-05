using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KordonKD.Sprint1.Task4.V2.Lib
{
    public class Dataservice : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            double res = 1 / Math.Sqrt(x + 2 * y);
            res = Math.Round(res, 3);

            return res;

        }
    }
}
