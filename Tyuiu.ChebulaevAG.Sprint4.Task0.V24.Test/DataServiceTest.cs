using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint4.Task0.V24.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int wait = 32; 

            int res = ds.GetMultEvenArrEl(numsArray);

            Assert.AreEqual(wait, res);
        }
    }
}
