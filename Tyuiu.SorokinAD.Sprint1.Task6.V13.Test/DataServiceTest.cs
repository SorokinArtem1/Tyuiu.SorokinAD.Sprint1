using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint1.Task6.V13.Lib;

namespace Tyuiu.SorokinAD.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAlph()
        {
            DataService ds = new DataService();
            string strTest = "Привет";
            bool res = ds.CheckWordsAlphabet(strTest);
            Assert.AreEqual(false, res);

        }
    }
}
