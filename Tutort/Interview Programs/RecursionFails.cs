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

            Console.WriteLine(Recursions(5)); ;
        }

        private static int Recursions(int n)
        {
            
            if (n == 0)
            {
                return 0 ;
                
            }
            Console.WriteLine("krishna..");
            return Recursions(n-1);
           
        }
    }
}
