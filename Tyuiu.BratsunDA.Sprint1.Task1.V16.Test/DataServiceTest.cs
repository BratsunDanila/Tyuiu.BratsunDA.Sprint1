using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint1.Task1.V16.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.0;
            double y = 2.0;
            double x = 1.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(16.0, res);
        }
    }
}
