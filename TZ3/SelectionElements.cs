using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{
    /// <summary>
    /// Выборка элементов массива
    /// </summary>
    internal class SelectionElements
    {
        /// <summary>
        /// Только четные или нечетные
        /// </summary>
        public static void EvenOrOddElements(int[] MyArray)
        {
            //Console.WriteLine("\nДля вывода четных чисел введите - 1\n");
            //Console.WriteLine("Для вывода нечетных чисел введите - 2\n");
            //int Counter = int.Parse(Console.ReadLine());
            //switch (Counter)
            //{
            //    case 1:
            Console.WriteLine("Четные числа");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 == 0)
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
            Console.WriteLine("\n");
            //    break;
            //case 2:
            Console.WriteLine("Нечетные числа");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 != 0)
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
            //        break;
            //    default:
            //        Console.WriteLine("Такого значения нет");
            //        break;
            //}
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Обнуление двухзначных чисел
        /// </summary>
        public static void ZeroingTwoDigitElements(int[] MyArray)
        {
            Console.WriteLine("Обнуление двухзначных чисел");
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] > 9 & 100 > MyArray[i])
                {
                    MyArray[i] = 0;
                    Console.Write(MyArray[i] + "\t");
                }
                else
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
        }
    }
}
