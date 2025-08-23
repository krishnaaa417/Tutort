using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutort.MyOwnWayCoding
{
    internal class CoinExchange
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5 };
            int amount = 11;
            //number of ways.. 
            //1+1+1+1+1+1+1+1+1+1+1 = count = 11
            //2+2+2+2+2+1 = count=6; 11
            //5+5+1 = 11;count =3
            //5+2+2+2=11; count=4
            // these are the ways to equal to amount 
            //My own thought is compare with count and return the least count..|
            Console.WriteLine(BruteForceCoinChange(nums,amount));
        }

        private static int BruteForceCoinChange(int[] coins, int amount)
        {
            if (amount == 0) return 0;
            if (amount < 0) return int.MaxValue;

            int minCount = int.MaxValue;

            foreach (int coin in coins)
            {
                int res = BruteForceCoinChange(coins, amount - coin);
                if (res != int.MaxValue)
                {
                    minCount = Math.Min(minCount, res + 1);
                }
            }

            return minCount;
        }

    }
}
