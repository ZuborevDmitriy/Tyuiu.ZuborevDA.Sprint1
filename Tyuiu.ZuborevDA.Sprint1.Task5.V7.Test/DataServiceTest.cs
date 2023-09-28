using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
                double f = 90;
                DataService ds = new DataService();
                int result = ds.AngleToHoursMinutes(f);
                int wait = 3;
                Assert.AreEqual(wait, result);
        }
    }
}
