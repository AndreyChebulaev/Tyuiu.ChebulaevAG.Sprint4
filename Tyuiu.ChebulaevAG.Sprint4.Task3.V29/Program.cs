using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint4.Task3.V29.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 5 до 9.              *");
            Console.WriteLine("* Найдите произведение элементов в первом столбце массива.                *");
            Console.WriteLine("* 9, 9, 8, 6, 9,                                                          *");
            Console.WriteLine("* 5, 8, 8, 8, 7,                                                          *");
            Console.WriteLine("* 6, 5, 9, 7, 9,                                                          *");
            Console.WriteLine("* 7, 7, 9, 7, 8,                                                          *");
            Console.WriteLine("* 8, 5, 8, 5, 5,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[5, 5] { { 9, 9, 8, 6, 9 },
                                          { 5, 8, 8, 8, 7 },
                                          { 6, 5, 9, 7, 9 },
                                          { 7, 7, 9, 7, 8 },
                                          { 8, 5, 8, 5, 5 } };

            Console.WriteLine("Массив:");

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    Console.Write(mtrx[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Произведение элементов в первом столбце: " + res);
            Console.ReadKey();
        }
    }
}
