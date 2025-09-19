using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Maths
{
    internal class AlternativeSUm
    {
        static void Main(string[] args)
        {
            int n = 521;
            Console.WriteLine("Alternative sum.."+SHow(n));
        }

        private static int SHow(int n)
        {
            int sum0 = 0, sum1 = 0, count = 0;
            while (n != 0)
            {
                if (count % 2 == 0)
                {
                    sum0 += n % 10;
                }
                else
                {
                    sum1 += n % 10;
                }
                n /= 10;
                count++;

            }
            if (count % 2 == 0)
            {
                return sum1 - sum0;
            }
            return sum0 - sum1;
        }
    }
    }

