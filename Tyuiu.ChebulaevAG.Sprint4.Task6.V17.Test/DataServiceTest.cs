using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint4.Task6.V17.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var codes = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int res = ds.Calculate(codes);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
