using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.ZuborevDA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello my dear friend";
            DataService ds = new DataService();
            bool res = ds.CheckHello(strTest);
            Assert.AreEqual(true, res);
        }
    }
}
