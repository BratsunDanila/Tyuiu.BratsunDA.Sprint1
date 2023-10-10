using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint1.Task7.V26.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.218, res);
        }
    }
}
