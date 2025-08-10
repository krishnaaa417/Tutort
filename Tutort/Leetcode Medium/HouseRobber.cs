using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Medium
{
    internal class HouseRobber
    {
        static void Main(string[] args)
        {
            int[] nums = { 2,7,9,3,1};
            Console.WriteLine(GeneralRecursion(nums));
            //don't robber adjacent side homes--
        }

        private static int GeneralRecursion(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
            {
                return nums[0];
            }
            if (n == 1)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int maxcount1 = 0;
            int maxcount2 = 0;

            for (int i = 0; i < n; i = i + 2)
            {
                maxcount1 += nums[i];
            }
            for (int i = 1; i < n; i = i + 2)
            {
                maxcount2 += nums[i];
            }

            return Math.Max(maxcount1, maxcount2);
        }
    }
}
