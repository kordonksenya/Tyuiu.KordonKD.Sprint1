using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KordonKD.Sprint1.Task0.V5.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class Dataservicetest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dataservice ds = new Dataservice();
            var res = ds.Calculate();
            Assert.AreEqual(9, res);
        }
    }
}
