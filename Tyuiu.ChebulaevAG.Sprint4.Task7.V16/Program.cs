using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint4.Task7.V16.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "382976421897948";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 382976421897948.                      *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3                                        *");
            Console.WriteLine("* и подсчитайте произведение четных чисел.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(str[index].ToString());
                    index++;
                    Console.Write($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);

            Console.WriteLine("Произведение четных чисел = " + res);
            Console.ReadKey();
        }
    }
}
