using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KordonKD.Sprint1.Task2.V6.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class Dataservicetest
    {
        [TestMethod]
        public void ValidExpression()
        {
            Dataservice ds = new Dataservice();
            int x = 4354;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(4.354, res);
        }
    }
}
