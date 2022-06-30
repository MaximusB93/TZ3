﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZ3
{
    internal class Program
    {
        public static void Main()
        {
            ////Наполнение и вывод массива на консоль
            //Console.WriteLine("Введите величину массива");
            //int ValueArray = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Random rand = new Random();
            //int[] MyArray = new int[ValueArray];
            //Console.WriteLine("Массив рандомно наполнен");
            //for (int i = 0; i < MyArray.Length; i++)
            //{
            // MyArray[i] = rand.Next(20);
            // Console.Write(MyArray[i] + "\t");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine("\n-----------------------\n");

            ////Сумма четных и нечетных чисел
            //int SumEvenNumbers = 0;
            //int SumOddNumbers = 0;
            //for (int i = 0; i < MyArray.Length; i++)
            //{
            //    if (MyArray[i] % 2 == 0)
            //    {
            //        SumEvenNumbers += MyArray[i];
            //    }
            //    else
            //    {
            //        SumOddNumbers += MyArray[i];
            //    }
            //}
            //Console.WriteLine("Сумма четных чисел - " + SumEvenNumbers);
            //Console.WriteLine("Сумма нечетных чисел - " + SumOddNumbers);
            //Console.WriteLine("\n-----------------------\n");

            ////Минимальный и максимальный элемент массива
            ////Console.WriteLine(MyArray.Min());
            ////Console.WriteLine(MyArray.Max());

            ////Либо через цикл
            //int MaxNumber = MyArray[0];
            //int MinNumber = MyArray[0];
            //for (int i = 1; i < MyArray.Length; i++)
            //{
            //    if (MaxNumber < MyArray[i])
            //    {
            //        MaxNumber = MyArray[i];
            //    }
            //    else if (MinNumber > MyArray[i])
            //    {
            //        MinNumber = MyArray[i];
            //    }
            //}
            //Console.WriteLine("Максимальный элемент массива - " + MaxNumber);
            //Console.WriteLine("Минимальный элемент массива - " + MinNumber);
            //Console.WriteLine("\n-----------------------\n");

            //// Нечетный минимальный и четный максимальный
            //int MaxEvenNumber = MyArray[0];
            //int MinOddNumber = MyArray[0];
            //for (int i = 1; i < MyArray.Length; i++)
            //{
            //    if (MaxEvenNumber < MyArray[i] && MyArray[i] % 2 == 0)
            //    {
            //        MaxEvenNumber = MyArray[i];
            //    }
            //    else if (MinOddNumber > MyArray[i] && MyArray[i] % 2 != 0)
            //    {
            //        MinOddNumber = MyArray[i];
            //    }
            //}
            //Console.WriteLine("Четный максимальный элемент - " + MaxEvenNumber);
            //Console.WriteLine("Нечетный минимальный элемент - " + MinOddNumber);
            //Console.WriteLine("\n-----------------------\n");

            ////Перестановка максимального и минимального элементов массива
            //Console.WriteLine("Перестановка максимального и минимального элементов массива");
            //int MaxElementArray = MyArray.Max();
            //int MinElementArray = MyArray.Min();
            //for (int i = 0; i < MyArray.Length; i++)
            //{
            // if (MyArray[i] == MaxElementArray)
            //    {
            // Console.Write(MinElementArray + "\t");
            //    }
            // else if (MyArray[i] == MinElementArray)
            //    {
            // Console.Write(MaxElementArray + "\t");
            //    }
            // else
            //    {
            // Console.Write(MyArray[i] + "\t");
            //    }
            //}
            //Console.WriteLine("\n-----------------------\n");

            ////Сортировка массива
            ////По возрастанию
            //Console.WriteLine("Сортировка массива по возрастанию");
            //int[] MyArray2 = new int[MyArray.Length];
            //Array.Copy(MyArray, 0, MyArray2, 0, MyArray.Length);
            //Array.Sort(MyArray2);
            //for (int i = 0; i < MyArray2.Length; i++)
            //{
            // Console.Write(MyArray2[i] + "\t");

            //}
            ////Array.ForEach(MyArray, Console.WriteLine);
            //Console.WriteLine("\n-----------------------\n");

            ////По убыванию
            //Console.WriteLine("Сортировка массива по убыванию"); 
            //Array.Sort(MyArray2);
            //Array.Reverse(MyArray2);
            //for (int i = 0; i < MyArray2.Length; i++)
            //{
            // Console.Write(MyArray2[i] + "\t");

            //}
            ////Array.ForEach(MyArray, Console.WriteLine);
            //Console.WriteLine("\n-----------------------\n");

            ////Четные, а после нечетные числа
            //Console.WriteLine("Четные, а после нечетные числа");
            //Array.Sort(MyArray2);
            //for (int i = 0; i < MyArray2.Length; i++)
            //{
            // if (MyArray2[i] % 2 == 0)
            //    {
            // Console.Write(MyArray2[i] + "\t");
            //    }
            //}
            //for (int i = 0; i < MyArray2.Length; i++)
            //{
            // if (MyArray2[i] % 2 != 0)
            //    {
            // Console.Write(MyArray2[i] + "\t");
            //    }
            //}
            //Console.WriteLine("\n-----------------------\n");

            ////Только четные или нечетные
            //Console.WriteLine("\nДля вывода четных чисел введите - 1\n");
            //Console.WriteLine("Для вывода нечетных чисел введите - 2\n");
            //int Counter = int.Parse(Console.ReadLine());
            //switch (Counter)
            //{
            // case 1:
            // Console.WriteLine("Четные числа");
            // for (int i = 0; i < MyArray.Length; i++)
            //        {
            // if (MyArray[i] % 2 == 0)
            //            {
            // Console.Write(MyArray[i] + "\t");
            //            }
            //        }
            // break;
            // case 2:
            // Console.WriteLine("Нечетные числа");
            // for (int i = 0; i < MyArray.Length; i++)
            //        {
            // if (MyArray[i] % 2 != 0)
            //            {
            // Console.Write(MyArray[i] + "\t");
            //            }
            //        }
            // break;
            // default:
            // Console.WriteLine("Такого значения нет");
            // break;
            //}
            //Console.WriteLine("\n-----------------------\n");

            ////Обнуление двухзначных чисел
            //Console.WriteLine("Обнуление двухзначных чисел");
            //for (int i = 0; i < MyArray.Length; i++)
            //{
            // if (MyArray[i] > 9 & 100 > MyArray[i])
            //    {
            // MyArray[i] = 0;
            // Console.Write(MyArray[i] + "\t");
            //    }
            // else
            //    {
            // Console.Write(MyArray[i] + "\t");
            //    }
            //}

            //Двухмерные массивы
            Random rand2 = new Random();
            int[,] TwoArray = new int[5, 5];
            Console.WriteLine("Массив выведен рандомно");
            for (int i = 0; i < TwoArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray.GetLength(1); j++)
                {
                    Console.Write(TwoArray[i, j] = rand2.Next(15));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");

            //Сумма двухзначных элементов
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

            //Сумма элементов равных 5
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

            //Обнулить элементы ниже главной диагонали
            Console.WriteLine("Обнулить элементы ниже главной диагонали");
            int[,] TwoArray2 = new int[TwoArray.GetLength(0), TwoArray.GetLength(1)];
            Array.Copy(TwoArray, 0, TwoArray2, 0, TwoArray.Length);
            for (int i = 0; i < TwoArray2.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray2.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        Console.Write(TwoArray2[i, j] = 0);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(TwoArray2[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");

            //Обнулить элементы выше главной диагонали
            Console.WriteLine("Обнулить элементы выше главной диагонали");
            int[,] TwoArray3 = new int[TwoArray.GetLength(0), TwoArray.GetLength(1)];
            Array.Copy(TwoArray, 0, TwoArray3, 0, TwoArray.Length);
            for (int i = 0; i < TwoArray3.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray3.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Console.Write(TwoArray3[i, j] = 0);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(TwoArray3[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");

            //Обнулить элементы ниже побочной диагонали
            Console.WriteLine("Обнулить элементы ниже побочной диагонали");
            int[,] TwoArray4 = new int[TwoArray.GetLength(0), TwoArray.GetLength(1)];
            Array.Copy(TwoArray, 0, TwoArray4, 0, TwoArray.Length);
            for (int i = 0; i < TwoArray4.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray4.GetLength(1); j++)
                {
                    if (i > 1 - j + 1)
                    {
                        Console.Write(TwoArray4[i, j] = 0);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(TwoArray4[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");

            //Обнулить элементы выше побочной диагонали
            int n = TwoArray.GetLength(0);
            Console.WriteLine("Обнулить элементы выше побочной диагонали");
            int[,] TwoArray5 = new int[n, n];
            Array.Copy(TwoArray, 0, TwoArray5, 0, TwoArray.Length);

            for (int i = 0; i < TwoArray5.GetLength(0); i++)
            {
                for (int j = 0; j < TwoArray5.GetLength(1); j++)
                {
                    if (i < n - j + 1)
                    {
                        TwoArray5[i, j] = 0;
                        Console.Write(TwoArray5[i, j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(TwoArray5[i, j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n-----------------------\n");
        }
    }
}