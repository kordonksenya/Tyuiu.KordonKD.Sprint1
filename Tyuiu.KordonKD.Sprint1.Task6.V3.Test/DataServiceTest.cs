using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KordonKD.Sprint1.Task6.V3.Lib;

namespace Tyuiu.KordonKD.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Погода просто супер";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "аор";
            Assert.AreEqual(wait, res);
        }
    }
}
