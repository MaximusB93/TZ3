using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{/// <summary>
/// Супер-массив
/// </summary>
    internal class SuperArray
    {
        /// <summary>
        /// Обнуление чисел выше главной диагонали и меньше выбранного числа
        /// </summary>
        public static void ResetElementsHigherMainDiagonal(int[,] SuperArray)
        {
            Console.WriteLine("Введите число меньше которого нужно обнулить");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Обнуление чисел выше главной диагонали и меньше выбранного числа");
            for (int i = 0; i < SuperArray.GetLength(0); i++)
            {
                for (int j = 0; j < SuperArray.GetLength(0); j++)
                {
                    if (i < j & number > SuperArray[i, j])
                    {
                        SuperArray[i, j] = 0;
                        Console.Write(SuperArray[i, j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(SuperArray[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
        /// <summary>
        /// Вывод элементов выше побочной диагонали и меньше числа Х
        /// </summary>
        public static void OutputElementsSideDiagonal(int[,] SuperArray)
        {
            Console.WriteLine("Введите значение меньше которого нужно вывести числа");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Вывод элементов выше побочной диагонали и меньше числа Х");
            for (int i = 0; i < SuperArray.GetLength(0); i++)
            {
                for (int j = 0; j < SuperArray.GetLength(1); j++)
                {
                    if (i < (SuperArray.GetLength(0) - 2) - j + 1 & SuperArray[i, j] < number)
                    {
                        Console.Write(SuperArray[i, j] + "/t");
                    }
                }
            }
        }
    }
}