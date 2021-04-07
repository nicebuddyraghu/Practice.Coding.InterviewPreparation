using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class JewelsAndStones
    {
        /*
         * https://leetcode.com/problems/jewels-and-stones/submissions/
         * 
         * */
        internal class Solution
        {
            internal int NumJewelsInStones(string jewels, string stones)
            {

                int totaljewels = 0;

                foreach (var jewel in jewels)
                {
                    foreach (var stone in stones)
                    {
                        if (jewel == stone)
                        {
                            totaljewels++;
                        }
                    }
                }

                return totaljewels;
            }
        }
    }
}
