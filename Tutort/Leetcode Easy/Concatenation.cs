using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Easy
{
    internal class Concatenation
    {
        static void Main(string[] args)
        {
            int[] result = { 1, 2, 3 };
           var response = BruteForceApproach(result);
            foreach (var item in response)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] BruteForceApproach(int[] result)
        {
            int n = result.Length;
            int[] output = new int[2*n];
            for (int i = 0; i < n; i++)
            {
                output[i] = result[i];
                output[i + n] = result[i];
            }
            return output;
        }
    }
}
