using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ClimbStairs
    {
        //Dynamic Programming Example.
        /***
         * 
         * 
         * https://leetcode.com/problems/climbing-stairs/submissions/
         * 
         */

        //Took 1 hour 10 minutes to solve this problem.
        //1 Hour: 8 Minutes: 49 Seconds.

        public class Solution
        {

            Dictionary<int, int> stepsClimbed = new Dictionary<int, int>();

            public Solution()
            {
                stepsClimbed.Add(1, 1);
                stepsClimbed.Add(2, 2);
            }
            public int ClimbStairs(int n)
            {

                if (n == 1)
                {
                    return stepsClimbed[1]; //return 1 step.
                }
                else if (n == 2)
                {
                    return stepsClimbed[2]; //return 2 step.
                }
                else
                {
                    if (!stepsClimbed.ContainsKey(n - 1))
                        stepsClimbed.Add(n - 1, ClimbStairs(n - 1));

                    if (!stepsClimbed.ContainsKey(n - 2))
                        stepsClimbed.Add(n - 2, ClimbStairs(n - 2));

                    return stepsClimbed[n - 1] + stepsClimbed[n - 2];
                }
            }
        }
    }
}
