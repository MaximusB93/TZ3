using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ3
{/// <summary>
 /// Простой поиск
 /// </summary>
    internal class ArraySearch
    {
        /// <summary>
        /// Сумма четных и нечетных элементов массива
        /// </summary>
        /// <param name="MyArray"></param>
        public static void SumOddEvenElements(int[] MyArray)
        {
            //Сумма четных и нечетных чисел
            int SumEvenNumbers = 0;
            int SumOddNumbers = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 == 0)
                {
                    SumEvenNumbers += MyArray[i];
                }
                else
                {
                    SumOddNumbers += MyArray[i];
                }
            }
            Console.WriteLine("Сумма четных чисел - " + SumEvenNumbers);
            Console.WriteLine("Сумма нечетных чисел - " + SumOddNumbers);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Максимальный и минимальный элемент массива
        /// </summary>
        /// <param name="MyArray"></param>
        public static void MinMaxElements(int[] MyArray)
        {

            //Console.WriteLine(MyArray.Min());
            //Console.WriteLine(MyArray.Max());

            //Либо через цикл
            int MaxNumber = MyArray[0];
            int MinNumber = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MaxNumber < MyArray[i])
                {
                    MaxNumber = MyArray[i];
                }
                else if (MinNumber > MyArray[i])
                {
                    MinNumber = MyArray[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива - " + MaxNumber);
            Console.WriteLine("Минимальный элемент массива - " + MinNumber);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Нечетный минимальный и четный максимальный
        /// </summary>
        /// <param name="MyArray"></param>
        public static void OddMinEvenMaxElements(int[] MyArray)
        {
            int MaxEvenNumber = MyArray[0];
            int MinOddNumber = MyArray[0];
            for (int i = 1; i < MyArray.Length; i++)
            {
                if (MaxEvenNumber < MyArray[i] && MyArray[i] % 2 == 0)
                {
                    MaxEvenNumber = MyArray[i];
                }
                else if (MinOddNumber > MyArray[i] && MyArray[i] % 2 != 0)
                {
                    MinOddNumber = MyArray[i];
                }
            }
            Console.WriteLine("Четный максимальный элемент - " + MaxEvenNumber);
            Console.WriteLine("Нечетный минимальный элемент - " + MinOddNumber);
            Console.WriteLine("\n-----------------------\n");
        }
        /// <summary>
        /// Перестановка максимального и минимального элементов массива
        /// </summary>
        /// <param name="MyArray"></param>
        public static void PermutationMinMaxElements(int[] MyArray)
        {
            Console.WriteLine("Перестановка максимального и минимального элементов массива");
            int MaxElementArray = MyArray.Max();
            int MinElementArray = MyArray.Min();
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] == MaxElementArray)
                {
                    Console.Write(MinElementArray + "\t");
                }
                else if (MyArray[i] == MinElementArray)
                {
                    Console.Write(MaxElementArray + "\t");
                }
                else
                {
                    Console.Write(MyArray[i] + "\t");
                }
            }
            Console.WriteLine("\n-----------------------\n");
        }
    }
}
