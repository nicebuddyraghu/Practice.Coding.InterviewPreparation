using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{

    internal class SingleNumber
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/single-number/
         * 
         * 
         */
        internal class Solution
        {
            internal int SingleNumber(int[] nums)
            {
                Dictionary<int, bool> dupCheckDic = new
                    Dictionary<int, bool>();

                foreach (var num in nums)
                {
                    if (!dupCheckDic.ContainsKey(num))
                        dupCheckDic.Add(num, false);
                    else
                        dupCheckDic[num] = true;
                }

                foreach (var keyval in dupCheckDic)
                {
                    if (!keyval.Value)
                        return keyval.Key;
                }

                return -1;
            }
        }
    }
}
