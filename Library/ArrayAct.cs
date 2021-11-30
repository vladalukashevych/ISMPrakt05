using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ArrayAct
    {
        public static int[] ArrayCreating(int amount)
        {
            Random rnd = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < amount; i++)
                arr[i] =  rnd.Next(-11, 11);
            return arr;
        }
        public static int SumOfNegatives(int[] arr, int amount)
        {
            int sum = 0;
            for (int i = 0; i < amount; i++)
                if (arr[i] < 0) sum += arr[i];
            return sum;
        }
        public static int MaxOfEvenElements(int[] arr, int amount)
        {
            int max = 0;
            for (int i = 0; i < amount; i++)
            {
                if (arr[i] % 2 == 0) max = arr[i];
                break;
            }
            for (int i = 0; i < amount; i++)
                if (arr[i] % 2 == 0 && arr[i] > max) max = arr[i];
            return max;
        }
        public static int ProductOfElements(int[] arr, int amount)
        {
            int product = 1;
            for (int i = 0; i < amount; i += 2)
                product *= arr[i];
            return product;
        }
        public static int IndexOfMaxElement(int[] arr, int amount)
        {
            int index = 0, max = arr[0];
            for (int i = 1; i < amount; i++)
                if (arr[i] > max) max = arr[i];
            for (int i = 0; i < amount; i++)
                if (arr[i] == max)
                {
                    index = i;
                    break;
                }
            return index;
        }
        public static int MaxOfAbsoluteValues(int[] arr, int amount)
        {
            int max = Math.Abs(arr[0]);
            for (int i = 0; i < amount; i++)
                if (Math.Abs(arr[i]) > max) max = arr[i];  
            return max;
        }
        public static int SumOfPositivsIndexes(int[] arr, int amount)
        {
            int sum = 0;
            for (int i = 0; i < amount; i++)
                if (arr[i] > 0) sum += i;
            return sum;
        }
        public static int AmountOfOddElements(int[] arr, int amount)
        {
            int count = 0;
            for (int i = 0; i < amount; i++)
                if (arr[i] % 2 != 0) count++;
            return count;
        }
        public static void ArrayPrint(int[] arr, int amount)
        {
            Console.Write("\n");
            for (int i = 0; i < amount; i++)
                Console.WriteLine($" arr[{i}] = {arr[i]}\n");
        }

    }
}
