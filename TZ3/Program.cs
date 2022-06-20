﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сумма четных и нечетных чисел

            Random rand = new Random();

            Console.WriteLine("Введите величину массива");

            int ValueArray = int.Parse(Console.ReadLine());
            Console.Clear();
            int[] MyArray = new int[ValueArray];
            Console.WriteLine("Массив рандомно наполнен");

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = rand.Next(1, 100);
                Console.Write(MyArray[i] + "\t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n-----------------------\n");
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


            //Минимальный и максимальный элемент массива
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

            // Нечетный минимальный и четный максимальный

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


            int MaxElementArray = MyArray.Max();
            int MinElementArray = MyArray.Min();

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] == MaxElementArray)
                {
                    MaxElementArray = MyArray[i];
                }

                else if (MyArray[i] == MinElementArray)
                {
                    MinElementArray = MyArray[i];
                }
            }

            Console.WriteLine()

        }
    }
}
