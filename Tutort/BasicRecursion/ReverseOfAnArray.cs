using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BasicRecursion
{
    internal class ReverseOfAnArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            // Recursion(arr.Length-1,arr);
            UsingWhileLoop(arr);
        }

        private static void Recursion(int i, int[] arr)
        {
            if (i < 0)
            {
                return;
            }
            Console.WriteLine(arr[i]);
            Recursion(i - 1, arr);
        }

        private static void UsingWhileLoop(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                i++;
                j--;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void SwapRecursion(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            if (left < right)
            {
                return;
            }

            
        }
    }
}
