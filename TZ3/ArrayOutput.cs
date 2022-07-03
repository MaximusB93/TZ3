using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{
    internal class ArrayOutput
    {
        /// <summary>
        /// Вывод одномерного массива
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] ArrayRand()
        {
            Console.WriteLine("Введите величину массива");
            int ValueArray = int.Parse(Console.ReadLine());
            Console.Clear();
            Random rand = new Random();
            int[] MyArray = new int[ValueArray];
            Console.WriteLine("Массив рандомно наполнен");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = rand.Next(20);
                Console.Write(MyArray[i] + "\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n-----------------------\n");
            return MyArray;
        }
        /// <summary>
        /// Вывод двумерного массива
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[,] TwoArrayRand()
        {
            Console.WriteLine("Введите величину массива");
            int ValueArray = int.Parse(Console.ReadLine());
            Random rand2 = new Random();
            int[,] TwoArray = new int[ValueArray, ValueArray];
            Console.WriteLine("Массив выведен рандомно");
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    Console.Write(TwoArray[i, j] = rand2.Next(10, 99));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
            return TwoArray;
        }
    }
}
