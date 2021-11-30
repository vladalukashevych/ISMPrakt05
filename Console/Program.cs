﻿using System;
using Library;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write(" Enter the amount of array elements\n\t");
            int amount = 0;
            bool OK = false;
            while (OK == false || amount < 1)
            {
                OK = int.TryParse(Console.ReadLine(), out amount);
                if (OK == false || amount < 1) Console.Write(" Incorect data entered. Please, try again.\n\t");
            }
            int[] arr = new int[100];
            arr = ArrayAct.ArrayCreating(amount);
            ArrayAct.ArrayPrint(arr, amount);
            Console.WriteLine($" Sum of negative elements is {ArrayAct.SumOfNegatives(arr, amount)}");
            Console.WriteLine($" Max of even elements is {ArrayAct.MaxOfEvenElements(arr, amount)}");
            Console.WriteLine($" Product of elements with even indexes is {ArrayAct.ProductOfElements(arr, amount)}");
            Console.WriteLine($" Index of max element is {ArrayAct.IndexOfMaxElement(arr, amount)}");
            Console.WriteLine($" Max of absolute values is {ArrayAct.MaxOfAbsoluteValues(arr, amount)}");
            Console.WriteLine($" Sum of positive's indexes is {ArrayAct.SumOfPositivsIndexes(arr, amount)}");
            Console.WriteLine($" Amount of odd elements is {ArrayAct.AmountOfOddElements(arr, amount)}");
        }
    }
}
