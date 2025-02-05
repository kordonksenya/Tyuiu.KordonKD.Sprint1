using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KordonKD.Sprint1.Task3.V15.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class Dataservicetest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double v1 = 60; 
            double v2 = 80; 
            double S = 100;
            double T = 2;   
            Dataservice dataservice = new Dataservice();
            double result = dataservice.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(100.0, result, 0.001, "The distance remaining should be 100 km.");
        }
    }
}
