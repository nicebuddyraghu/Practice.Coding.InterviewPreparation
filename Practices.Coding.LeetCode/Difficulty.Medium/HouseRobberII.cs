using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class HouseRobberII
    {
        public class Solution
        {
            public int Rob(int[] nums)
            {

                if (nums.Length == 1)
                {
                    return nums[0];
                }

                int maxrobbedmoney1 = 0;
                int maxrobbedmoney2 = 0;

                for (int housenumber = 0; housenumber < nums.Length - 1; housenumber++)
                {
                    var moneyrobbedfromhouse = nums[housenumber];
                    var temp = Math.Max(moneyrobbedfromhouse + maxrobbedmoney1, maxrobbedmoney2);
                    maxrobbedmoney1 = maxrobbedmoney2;
                    maxrobbedmoney2 = temp;
                }

                maxrobbedmoney1 = 0;
                int maxrobbedmoney3 = 0;
                for (int housenumber = 1; housenumber < nums.Length; housenumber++)
                {
                    var moneyrobbedfromhouse = nums[housenumber];
                    var temp = Math.Max(moneyrobbedfromhouse + maxrobbedmoney1, maxrobbedmoney3);
                    maxrobbedmoney1 = maxrobbedmoney3;
                    maxrobbedmoney3 = temp;
                }

                return Math.Max(maxrobbedmoney3, maxrobbedmoney2);
            }
        }

    }
}
