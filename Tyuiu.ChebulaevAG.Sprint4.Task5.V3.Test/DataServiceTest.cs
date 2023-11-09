using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint4.Task5.V3.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[,]
        {
            { 1, -2, 3, -4, 5 },
            { -1, 2, -3, 4, -5 },
            { 6, 7, -8, -9, 10 },
            { -6, -7, 8, 9, 11 },
            { 12, -13, 14, -15, 16 }
        };

            int[,] wait = new int[,]
            {
            { 1, 0, 3, 0, 5 },
            { 0, 2, 0, 4, 0 },
            { 6, 7, 0, 0, 10 },
            { 0, 0, 8, 9, 11 },
            { 12, 0, 14, 0, 16 }
            };

            int[,] res = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
