using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Easy
{
    internal class SUmOFtheDigits
    {
        static void Main(string[] args)
        {
            int n = 12345;
            Console.WriteLine(SumofDigits(n));
        }
        private static int SumofDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int count = n % 10; // count = 1
                sum += count;
                n /= 10;
            }
            return sum;
        }
    }
}
