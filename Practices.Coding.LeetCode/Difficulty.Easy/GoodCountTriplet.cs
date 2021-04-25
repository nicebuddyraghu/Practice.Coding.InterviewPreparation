using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class GoodCountTriplet
    {
        /*
         * 
         * 
         * https://leetcode.com/problems/count-good-triplets/submissions/
         * 
         * 
         * 
         */

        public class Solution
        {
            public int CountGoodTriplets(int[] arr, int a, int b, int c)
            {

                List<Tuple<int, int, int>> tripletlist = new List<Tuple<int, int, int>>();

                for (int iindex = 0; iindex <= arr.Length - 3; iindex++)
                {
                    for (int jindex = iindex + 1; jindex <= arr.Length - 2; jindex++)
                    {
                        for (int kindex = jindex + 1; kindex <= arr.Length - 1; kindex++)
                        {
                            int absvalue1 = Math.Abs(arr[iindex] - arr[jindex]);
                            int absvalue2 = Math.Abs(arr[jindex] - arr[kindex]);
                            int absvalue3 = Math.Abs(arr[iindex] - arr[kindex]);
                            if (absvalue1 <= a &&
                               absvalue2 <= b &&
                               absvalue3 <= c)
                            {
                                tripletlist.Add(Tuple.Create(absvalue1, absvalue2, absvalue3));
                            }
                        }
                    }
                }

                return tripletlist.Count;
            }
        }
    }
}
