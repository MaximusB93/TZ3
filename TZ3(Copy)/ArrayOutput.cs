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
            Random rand = new Random();
            int[] MyArray = new int[ValueArray];
            Console.WriteLine("Массив рандомно наполнен");
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = rand.Next(1,15);
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
            Console.WriteLine("Введите величину двумерного массива");
            int ValueArray = int.Parse(Console.ReadLine());
            Random rand2 = new Random();
            int[,] TwoArray = new int[ValueArray, ValueArray];
            Console.WriteLine("Массив выведен рандомно");
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    Console.Write(TwoArray[i, j] = rand2.Next(1, 15));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
            return TwoArray;
        }
        /// <summary>
        /// Вывод супер-массива
        /// </summary>
        /// <returns></returns>
        public static int[,] SuperArrayRand()
        {
            Random random = new Random();
            Console.WriteLine("Супер-массив");
            Console.WriteLine("Укажите размерность массива");
            int length = int.Parse(Console.ReadLine());
            int[,] SuperArray = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(SuperArray[i, j] = random.Next(1, 15));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            return SuperArray;
        }
    }
}
