using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Dynamic_Programming.General_Recursion
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = 5;
            //Console.WriteLine(NormalRecursion(n));
            Console.WriteLine(Memoization(n));
        }

        private static int NormalRecursion(int n)
        {
            if(n == 0) return 0;
            else if(n == 1) return 1;
            return NormalRecursion(n - 1) + NormalRecursion(n-2);
        }

        private static int Memoization(int n)
        {
            int[] dp= new int[n+1];
            Array.Fill(dp, -1);
            return HelperMethod(dp, n);
        }

        private static int HelperMethod(int[] dp,int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else if (dp[n] != -1) return dp[n];
            dp[n] = HelperMethod(dp, n - 1) + HelperMethod(dp, n - 2);
            return dp[n];
        }
    }
}
