using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KordonKD.Sprint1.Task1.V3.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class Dataservicetest 
    {
        [TestMethod]
        public void ValidExpression()
        {
            Dataservice ds = new Dataservice();
            double x = 2.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.4, res);
        }
    }
}
