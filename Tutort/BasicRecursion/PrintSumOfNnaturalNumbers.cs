using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BasicRecursion
{
    internal class PrintSumOfNnaturalNumbers
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Recursion(n));
        }

        private static int SumOFNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;

        }

        private static int Recursion(int n)
        {
            
            if(n == 1) return 1;
           
            return n + Recursion(n - 1);
        }
   

    }


}
