using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Interview_Programs
{
    internal class RecursionFails
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Recursions(0)); ;
        }

        private static int Recursions(int n)
        {
            if (n == 5)
            {
                return 0 ;
                
            }
            Console.WriteLine(n);
            return Recursions(n+1);
        }
    }
}
