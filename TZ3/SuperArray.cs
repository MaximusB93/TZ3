using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{
    internal class SuperArray
    {/// <summary>
     /// Супер-массив
     /// </summary>
        public static void FuncSuperArray()
        {
            //Супер-массив  
            Random random = new Random();
            Console.WriteLine("Супер-массив");
            Console.WriteLine("Укажите размерность массива");
            int length = int.Parse(Console.ReadLine());
            int[,] SuperArray = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(SuperArray[i, j] = random.Next(1, 50));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Введите число меньше которого нужно обнулить");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Обнуление чисел выше главной диагонали и меньше выбранного числа");
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
            //        if (i < j & number > SuperArray[i, j])
            //        {
            //            SuperArray[i, j] = 0;
            //            Console.Write(SuperArray[i, j]);
            //            Console.Write(" ");
            //        }

            //        else
            //        {
            //            Console.Write(SuperArray[i, j]);
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (SuperArray[i, j] < number & i > (length - 2) - j + 1)
                    {
                        Console.Write(SuperArray[i, j] + "\t");
                    }
                }
            }
        }

        public static void Func1(int[,] TwoArray, int n)
        {
            //Обнулить элементы ниже побочной диагонали
            Console.WriteLine("Обнулить элементы ниже побочной диагонали");
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = n - 1; j > n - i - 1; j--)
                {
                    TwoArray[i, j] = 0;

                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(TwoArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }

    }
}
