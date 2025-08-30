using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.BackTracking
{
    internal class BackTracking
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            var result =  Subsets(nums);
          foreach (var response in result)
            {
                Console.WriteLine(response);
            }
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(0, new List<int>(), nums, result);
            return result;

        }
        private static void Backtrack(int start, List<int> path, int[] nums, IList<IList<int>> result)
        {
            result.Add(new List<int>(path));

            for (int i = start; i < nums.Length; i++)
            {
                path.Add(nums[i]);
                Backtrack(i + 1, path, nums, result);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}