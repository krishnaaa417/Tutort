using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tutort.Leetcode_Medium
{
    internal class DeleteOperation
    {
        static void Main(string[] args)
        {
            string s1 = "leetcode";
            string s2 = "etco";
            Console.WriteLine(BruteForceSolution(s1,s2));
        }
        private static int BruteForceSolution(string s1, string s2)
        {
            //step:1
            int m = s1.Length; // 8
            int n = s2.Length; // 4 
            //step:2
            int[] prev = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                prev[i] = i;
            }
            //step:3
            for (int i = 1; i <= m; i++)
            {
                int[] curr = new int[n + 1];
                curr[0] = i;

                //step : 4
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        curr[j] = prev[j - 1];
                    }
                    else
                    {

                        curr[j] = 1 + Math.Min(curr[j - 1], prev[j]);
                    }
                }
                prev = curr;
            }
            return prev[n];
        }
    }
}
