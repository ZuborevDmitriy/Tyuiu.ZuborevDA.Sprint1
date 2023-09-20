using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint1.Task2.V9.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 5;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(1570.0/3, res);
        }
    }
}
