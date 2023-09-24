using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint1.Task1.V3.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = 3;
            var res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(6, res);
        }
    }
}
