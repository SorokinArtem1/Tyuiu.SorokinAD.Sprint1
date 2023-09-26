using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint1.Task7.V4.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.185, res);
        }
    }
}
