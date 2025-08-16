using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Easy
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            string s = "loveda";
            Console.WriteLine(Ispalindrome(s));
        }

        private static bool Ispalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            bool b = true;

            while (i < j)
            {
                if (s[i] != s[j])
                {
                    b = false;
                    return b;
                }
                i++; ;
                j--;
            }
            return b;
        }
    }
}
