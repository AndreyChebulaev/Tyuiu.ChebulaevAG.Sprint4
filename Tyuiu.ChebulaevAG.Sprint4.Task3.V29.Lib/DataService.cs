using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChebulaevAG.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int sumArray = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumArray *= array[i, 0];
            }

            return sumArray;
        }
    }
}
