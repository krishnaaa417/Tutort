using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BasicRecursion
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            string s = "plaindrome";
            Console.WriteLine(IsPalindrome(s));
        }

        private static bool IsPalindrome(string s)
        {
            int n = s.Length;
            int left = 0;
            int right = n - 1;
            while(left < right)
            {
                if (s[left] !=s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
