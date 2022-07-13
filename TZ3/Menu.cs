using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TZ3
{
    internal class Menu
    {
        public static void FuncMenu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("РАБОТА С МАССИВАМИ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Одномерный массив - 1\n");
            Console.WriteLine("Двумерный массив - 2\n");
            Console.WriteLine("Супер-массив - 3\n");
            Console.WriteLine("Введите значение\n");
            int meaning = int.Parse(Console.ReadLine());                     
            switch (meaning)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("-----------------------");
                    int[] Array = ArrayOutput.ArrayRand();
                    ArraySearch.SumOddEvenElements(Array);
                    ArraySearch.MinMaxElements(Array);
                    ArraySearch.PermutationMinMaxElements(Array);
                    ArraySearch.OddMinEvenMaxElements(Array);

                    SortingArray.SortingArrayAscending(Array);
                    SortingArray.SortingArrayDescending(Array);
                    SortingArray.EvenAfterOddSortingArray(Array);

                    SelectionElements.EvenOrOddElements(Array);
                    SelectionElements.ZeroingTwoDigitElements(Array);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("-----------------------");
                    int[,] TwoArray = ArrayOutput.TwoArrayRand();
                    TwoDimensionalArrays.SumTwoDigitElements(TwoArray);
                    TwoDimensionalArrays.SumElementsFive(TwoArray);
                    TwoDimensionalArrays.ResetElementsBelowMainDiagonal(TwoArray);
                    TwoDimensionalArrays.ResetElementsHigherMainDiagonal(TwoArray);
                    TwoDimensionalArrays.ResetElementsHigherSideDiagonal(TwoArray);
                    TwoDimensionalArrays.ResetElementsBelowSideDiagonal(TwoArray);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("-----------------------");
                    int[,] SuperArray = ArrayOutput.SuperArrayRand();
                    SuperArrayClass.ResetElementsHigherMainDiagonal(SuperArray);
                    SuperArrayClass.OutputElementsSideDiagonal(SuperArray);                  
                    break;
                default:
                    Console.WriteLine("Такого значения нет");
                    break;
            }

            //Func1(ArrayOutput.ArrayRand(5), 5);

        }
    }
}