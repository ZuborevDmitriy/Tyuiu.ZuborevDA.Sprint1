using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double wait = 1.0 / 9;
            double result = Math.Round(wait, 3);
            var res = ds.Calculate(x);
            Assert.AreEqual(result, res);
        }
    }
}
