using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class BestTimeToBuyAndSellStock
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                Dictionary<int, int> maxprofitDictionary = new Dictionary<int, int>();

                int bestProfit = 0;
                for (int presentday = 0; presentday < prices.Length; presentday++)
                {
                    int stockPriceOfPresentDay = prices[presentday];
                    int maximumProfitOfPresentStock = 0;
                    if (maxprofitDictionary.ContainsKey(prices[presentday]))
                    {
                        maximumProfitOfPresentStock = maxprofitDictionary[prices[presentday]];
                        if (bestProfit < maximumProfitOfPresentStock)
                        {
                            bestProfit = maximumProfitOfPresentStock;
                        }
                        continue;
                    }

                    for (int futureday = presentday + 1; futureday < prices.Length; futureday++)
                    {
                        if (prices[futureday] - stockPriceOfPresentDay > maximumProfitOfPresentStock)
                        {
                            maximumProfitOfPresentStock = prices[futureday] - stockPriceOfPresentDay;
                        }
                    }

                    if (!maxprofitDictionary.ContainsKey(prices[presentday]))
                        maxprofitDictionary.Add(prices[presentday], maximumProfitOfPresentStock);

                    if (bestProfit < maximumProfitOfPresentStock)
                    {
                        bestProfit = maximumProfitOfPresentStock;
                    }
                }

                return bestProfit;
            }
        }
    }
}
