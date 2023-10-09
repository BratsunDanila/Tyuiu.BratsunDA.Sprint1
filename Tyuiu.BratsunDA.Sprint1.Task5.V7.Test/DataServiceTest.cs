using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 180;
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(6, result);
        }
    }
}
