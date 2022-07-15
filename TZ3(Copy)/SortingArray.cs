using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{
    /// <summary>
    /// Сортировка массива
    /// </summary>
    internal class SortingArray
    {
        /// <summary>
        /// Сортировка массива по возврастанию
        /// </summary>
        public static void SortingArrayAscending(int[] MyArray)
        {
            Console.WriteLine("Сортировка массива по возрастанию");
            int[] MyArray2 = new int[MyArray.Length];
            Array.Copy(MyArray, 0, MyArray2, 0, MyArray.Length);
            Array.Sort(MyArray2);
            for (int i = 0; i < MyArray2.Length; i++)
            {
                Console.Write(MyArray2[i] + "\t");
            }
            //Array.ForEach(MyArray, Console.WriteLine);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Сортировка по убыванию
        /// </summary>
        public static void SortingArrayDescending(int[] MyArray)
        {
            Console.WriteLine("Сортировка массива по убыванию");
            Array.Sort(MyArray);
            Array.Reverse(MyArray);
            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + "\t");
            }
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Четные, а после нечетные числа
        /// </summary>
        public static void EvenAfterOddSortingArray(int[] MyArray)
        {
            Console.WriteLine("Четные, а после нечетные числа");
            Array.Sort(MyArray);
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 == 0)
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 != 0)
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
            Console.WriteLine("\n-----------------------\n");
        }
    }
}
