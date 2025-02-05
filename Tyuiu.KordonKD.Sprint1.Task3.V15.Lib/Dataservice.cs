using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KordonKD.Sprint1.Task3.V15.Lib
{
    public class Dataservice : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            double totalSpeed = v1 + v2;

            double distanceCovered = totalSpeed * T;

            double remainingDistance = S - distanceCovered;


            return Math.Round(remainingDistance, 3);
        }
    }
}
