using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint1.Task4.V7.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 4;
            double b = 1;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(3, res);
        }
    }
}
