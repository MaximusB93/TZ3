using System;
using System.Collections.Generic;
using System.Text;

namespace TZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сумма четных и нечетных чисел
            int[] MyArray = { 200, 5, 12, 1, 5, 5, 25 };

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


        }
    }
}
