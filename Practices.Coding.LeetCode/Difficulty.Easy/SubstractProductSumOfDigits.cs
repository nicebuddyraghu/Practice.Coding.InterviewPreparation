using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SubstractProductSumOfDigits
    {
        /**
         * 
         * https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/submissions/
         * 
         * 
         */
        internal class Solution
        {
            internal int SubtractProductAndSum(int n)
            {

                List<int> intlist = new List<int>();

                var tempnum = n;

                while (tempnum > 0)
                {
                    var digit = tempnum % 10;
                    tempnum = tempnum / 10;
                    intlist.Add(digit);
                }

                int product = 1;
                int sum = 0;
                foreach (var num in intlist)
                {
                    product = num * product;
                    sum += num;
                }

                return product - sum;
            }
        }
    }
}
