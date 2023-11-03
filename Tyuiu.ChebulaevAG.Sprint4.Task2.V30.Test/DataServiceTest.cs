using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint4.Task2.V30.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 4, 7, 2, 6, 5, 8, 2, 7, 3, 4, 5 };
            int wait = 11025; 

            int res = ds.Calculate(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
