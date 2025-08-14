using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Easy
{
    internal class CountDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number..");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Recursions(n));

        }
        private static int BruteForceApproach(int n)
        {
            int count = 0;
            if (n == 0) return 1;
            while (n > 0)
            {
                n = n / 10;
                count++;

            }
            return count;
        }

        private static int Recursions(int n)
        {
            if(n == 0) return 1;

            if (n < 10)
                return 1;

            return 1 + Recursions(n/10);
        }
    }
}
