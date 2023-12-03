using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SorokinAD.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataSerivce ds = new DataSerivce();
            double res = ds.Calculate(3);
            double wait = 6.695;
            Assert.AreEqual(wait, res);
        }
    }
}
