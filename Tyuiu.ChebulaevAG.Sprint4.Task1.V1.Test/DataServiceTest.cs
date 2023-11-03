using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint4.Task1.V1.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int wait = 14;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
