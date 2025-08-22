using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BinarySearch
{
    internal class LeetcodeNumber34
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            int target = 8;
            var arrays = OptimizedApproach(nums,target);
            foreach (int i in arrays)
            {
                Console.WriteLine(i);
            }

        }

        private static int[] BruteForceApproach(int[] nums,int target)
        {
            //step 1 : checking the edge cases 
            if (nums == null || nums.Length == 0)
            {
                return new int[] { -1, -1 };
            }
            int left = -1;
            int right = -1;
            
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == target)
                {
                    left = i;
                    break;
                }
            }

           if (left != -1)
            {
                for (int i = nums.Length - 1; i >= left; i--)
                {
                    if (nums[i] == target)
                    {
                        right = i;
                        break;
                    }
                }
            }
           return new int[] { left, right };
        }

        private static int[] OptimizedApproach(int[] nums,int target)
        {
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1 };

            int first = FindFirst(nums, target);
            int last = FindLast(nums, target);

            return new int[] { first, last };

        }
        private static int FindFirst(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    high = mid - 1; // keep searching left
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }

        private static int FindLast(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    low = mid + 1; // keep searching right
                }
                else if (nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }


    }
}
