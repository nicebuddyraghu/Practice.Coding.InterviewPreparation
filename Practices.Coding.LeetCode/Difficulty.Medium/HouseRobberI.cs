using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class HouseRobberI
    {
        public class Solution
        {
            public int Rob(int[] nums)
            {
                int maxrobbedmoney1 = 0;
                int maxrobbedmoney2 = 0;

                for (int housenumber = 0; housenumber < nums.Length; housenumber++)
                {
                    var moneyrobbedfromhouse = nums[housenumber];
                    var temp = Math.Max(moneyrobbedfromhouse + maxrobbedmoney1, maxrobbedmoney2);
                    maxrobbedmoney1 = maxrobbedmoney2;
                    maxrobbedmoney2 = temp;
                }

                return maxrobbedmoney2;
            }
        }
    }
}
