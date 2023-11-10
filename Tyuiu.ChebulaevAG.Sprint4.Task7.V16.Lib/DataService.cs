using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChebulaevAG.Sprint4.Task7.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int currentIndex = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = value[currentIndex++] - '0';
                }
            }

            int product = 1;
            foreach (var element in matrix)
            {
                if (element % 2 == 0)
                {
                    product *= element;
                }
            }

            return product;  
        }
    }
}
