using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint1.Task5.V3.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 1323123733;
            int res = ds.Calculate(k);
            Assert.AreEqual(7, res);
        }
    }
}
