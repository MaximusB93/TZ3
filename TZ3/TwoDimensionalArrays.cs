using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{
    /// <summary>
    /// Двумерные массивы
    /// </summary>
    internal class TwoDimensionalArrays
    {
        /// <summary>
        /// Сумма двухзначных элементов
        /// </summary>
        public static void SumTwoDigitElements(int[,] TwoArray)
        {
            Console.WriteLine("Сумма двухзначных чисел двухмерного массива");
            int SumTwoElement = 0;
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    if (TwoArray[i, j] > 9 & TwoArray[i, j] < 100)
                    {
                        SumTwoElement += TwoArray[i, j];
                    }
                }
            }
            Console.WriteLine(SumTwoElement);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Сумма элементов равных 5
        /// </summary>
        public static void SumElementsFive(int[,] TwoArray)
        {
            Console.WriteLine("Сумма элементов равных 5");
            int FiveNumberSum = 0;
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    if (TwoArray[i, j] == 5)
                    {
                        FiveNumberSum += TwoArray[i, j];
                    }
                }
            }
            Console.WriteLine(FiveNumberSum);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Обнулить элементы ниже главной диагонали
        /// </summary>
        public static void ResetElementsBelowMainDiagonal(int[,] TwoArray)
        {

            int[,] CloneTwoArray = (int[,])TwoArray.Clone();
            Console.WriteLine("Обнулить элементы ниже главной диагонали");
            for (int i = 0; i < CloneTwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < CloneTwoArray.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        Console.Write(CloneTwoArray[i, j] = 0);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(CloneTwoArray[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Обнулить элементы выше главной диагонали
        /// </summary>
        public static void ResetElementsHigherMainDiagonal(int[,] TwoArray)
        {
            int[,] CloneTwoArray = (int[,])TwoArray.Clone();
            Console.WriteLine("Обнулить элементы выше главной диагонали");
            for (int i = 0; i < CloneTwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < CloneTwoArray.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Console.Write(CloneTwoArray[i, j] = 0);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(CloneTwoArray[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Обнулить элементы выше побочной диагонали
        /// </summary>
        public static void ResetElementsHigherSideDiagonal(int[,] TwoArray)
        {
            int[,] CloneTwoArray = (int[,])TwoArray.Clone();
            Console.WriteLine("Обнулить элементы выше побочной диагонали");
            for (int i = 0; i < CloneTwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < CloneTwoArray.GetLength(1); j++)
                {
                    if (i < (CloneTwoArray.GetLength(0) - 2) - j + 1)
                    {
                        CloneTwoArray[i, j] = 0;
                        Console.Write(CloneTwoArray[i, j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(CloneTwoArray[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Обнулить элементы ниже побочной диагонали
        /// </summary>
        /// <param name="TwoArray"></param>
        /// <param name="n"></param>
        public static void ResetElementsBelowSideDiagonal(int[,] TwoArray)
        {
            int[,] CloneTwoArray = (int[,])TwoArray.Clone();
            int n = CloneTwoArray.GetLength(0);
            Console.WriteLine("Обнулить элементы ниже побочной диагонали");
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = n - 1; j > n - i - 1; j--)
                {
                    CloneTwoArray[i, j] = 0;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(CloneTwoArray[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }
    }
}
