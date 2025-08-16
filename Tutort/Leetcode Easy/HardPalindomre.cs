using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Easy
{
    internal class HardPalindomre
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            Console.WriteLine(IsPalindrome(s));
        }

        private static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i <= j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                else if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                else if (char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
