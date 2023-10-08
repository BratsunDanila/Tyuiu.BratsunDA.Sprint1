using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint1.Task4.V11.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = Math.Round(ds.Calculate(x, y),3);
            Assert.AreEqual(0.289, res);
        }
    }
}
