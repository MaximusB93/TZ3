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
            try
            {
                int meaning = int.Parse(Console.ReadLine());
                switch (meaning)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("-----------------------");
                        int[] Array = ArrayOutput.ArrayRand();
                        Console.WriteLine("\n");
                        ArraySearch.SumOddEvenElements(Array);
                        ArraySearch.MinMaxElements(Array);
                        ArraySearch.PermutationMinMaxElements(Array);
                        ArraySearch.OddMinEvenMaxElements(Array);

                        SortingArray.SortingArrayAscending(Array);
                        SortingArray.SortingArrayDescending(Array);
                        SortingArray.EvenAfterOddSortingArray(Array);

                        SelectionElements.EvenOrOddElements(Array);
                        SelectionElements.ZeroingTwoDigitElements(Array);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Menu.FuncMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("-----------------------");
                        int[,] TwoArray = ArrayOutput.TwoArrayRand();
                        Console.WriteLine("\n");
                        TwoDimensionalArrays.SumTwoDigitElements(TwoArray);
                        TwoDimensionalArrays.SumElementsFive(TwoArray);
                        TwoDimensionalArrays.ResetElementsBelowMainDiagonal(TwoArray);
                        TwoDimensionalArrays.ResetElementsHigherMainDiagonal(TwoArray);
                        TwoDimensionalArrays.ResetElementsHigherSideDiagonal(TwoArray);
                        TwoDimensionalArrays.ResetElementsBelowSideDiagonal(TwoArray);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Menu.FuncMenu();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("-----------------------");
                        int[,] SuperArray = ArrayOutput.SuperArrayRand();
                        Console.WriteLine("\n");
                        SuperArrayClass.ResetElementsHigherMainDiagonal(SuperArray);
                        SuperArrayClass.OutputElementsSideDiagonal(SuperArray);
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        Menu.FuncMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такого значения нет, попробуйте еще раз");
                        Menu.FuncMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Неверное значение, попробуйте еще раз");
                Menu.FuncMenu();
            }       
        }
    }
}