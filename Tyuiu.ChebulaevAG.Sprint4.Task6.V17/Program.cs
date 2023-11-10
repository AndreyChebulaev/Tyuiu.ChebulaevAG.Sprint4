using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint4.Task6.V17.Lib;

namespace Tyuiu.ChebulaevAG.Sprint4.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [ Python, JavaScript, Java, C#, Swift, Kotlin, Ruby ]                   *");
            Console.WriteLine("* используя класс Array подсчитайте количество элементов,                 *");
            Console.WriteLine("* длина которых равна 6.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var codes = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= codes.Length - 1; i++)
            {
                Console.WriteLine(codes[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых равна 6:");

            int nums = ds.Calculate(codes);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
