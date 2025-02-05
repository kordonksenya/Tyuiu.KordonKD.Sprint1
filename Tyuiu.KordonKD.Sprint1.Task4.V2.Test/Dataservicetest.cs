using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KordonKD.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class Dataservicetest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            Dataservice ds = new Dataservice();
            double x = 1;
            double y = 2;
            double wail = 0.25;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wail, res, 3);
        }
    }
}
