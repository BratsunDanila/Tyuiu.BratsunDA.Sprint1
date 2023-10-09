using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.BratsunDA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string value = "0234hggh";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(value);
            Assert.AreEqual(res, false);
        }
    }
}
