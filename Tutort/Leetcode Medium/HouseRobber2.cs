using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.Leetcode_Medium
{
    internal class HouseRobber2
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            int n = nums.Length;
            if (n == 0) Console.WriteLine(0);
            else if (n == 1) Console.WriteLine(nums[0]);
            else if (n == 2) Console.WriteLine(Math.Max(nums[0], nums[1]));
            Console.WriteLine(Math.Max(SpaceOptimization(nums, 0, n - 2), SpaceOptimization(nums, 1, n - 1)));
        }
        private static int SpaceOptimization(int[] nums, int start, int end)
        {
            int a = nums[start];
            int b = Math.Max(nums[start], nums[end]);
            for (int i = start + 2; i <= end; i++)
            {
                int c = Math.Max(nums[i] + a, b);
                a = b;
                b = c;
            }
            return b;
        }
    }
}
