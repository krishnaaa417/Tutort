using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BasicRecursion
{
    internal class PrintNameNtimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your n number");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(NTimes(1,n));
            Console.WriteLine(Nto1(1,n));
        }

        private static int NTimes(int i, int n)
        {
            if (i > n)
            {
                return 0;
            }
            Console.WriteLine("Happy 79th Independence Day..");
            return NTimes(i + 1, n);
        }

        private static int Nto1(int i, int n)
        {
            if (n == 1)
            {
                return 1;
            }
            Console.WriteLine(n);
            return Nto1(i, n-1);
        }
    }
}
