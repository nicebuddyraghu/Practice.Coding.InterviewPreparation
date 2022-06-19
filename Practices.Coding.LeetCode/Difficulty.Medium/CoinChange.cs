using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class CoinChange
    {
        public class Solution
        {
            public int CoinChange(int[] coins, int amount)
            {
                return GetCoins(amount, coins);
            }

            Dictionary<int, int> numberofCoinsDictionary = new Dictionary<int, int>();
            public int GetCoins(int amount, int[] coins)
            {
                int[] coinscount = new int[amount + 1];
                coinscount[0] = 0;

                for (int coinamount = 1; coinamount <= amount; coinamount++)
                {
                    coinscount[coinamount] = Int32.MaxValue;

                    for (int index = 0; index < coins.Length; index++)
                    {
                        if (coins[index] <= coinamount)
                        {
                            var coin = coinscount[coinamount - coins[index]];
                            if (coin != Int32.MaxValue)
                                coinscount[coinamount] = Math.Min(coinscount[coinamount], 1 + coinscount[coinamount - coins[index]]);
                        }
                    }
                }

                return (coinscount[amount] > amount || coinscount[amount] < 0) ? -1 : coinscount[amount];
            }

        }

    }
}
