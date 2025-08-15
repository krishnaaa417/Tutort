using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.HomeWork1
{
    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(NormalApproach(n));
            //Console.WriteLine(Divivde(n));
            Console.WriteLine(byUsingBitwiseOperators(n));
        }

        private static int NormalApproach(int n)
        {
            if (n % 2 == 0)
            {
                return 1;
            }
            return -1;
        }

        private static bool Divivde(int n)
        {
            if (n == 0) return true;
            if(n == 1) return false;
            return Divivde(n - 2);
        }

        private static bool byUsingBitwiseOperators(int n)
        {
            if ((n & 1) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
