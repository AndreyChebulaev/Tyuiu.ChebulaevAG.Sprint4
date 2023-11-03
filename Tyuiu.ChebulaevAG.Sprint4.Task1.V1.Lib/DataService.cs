using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChebulaevAG.Sprint4.Task1.V1.Lib
{
    public class DataService : ISprint4Task1V1
    {
        public int Calculate(int[] array)
        {
            int res = 0;

            foreach (var num in array)
            {
                if (num % 2 == 0)
                {
                    res += num;
                }
            }

            return res;
        }
    }
}
