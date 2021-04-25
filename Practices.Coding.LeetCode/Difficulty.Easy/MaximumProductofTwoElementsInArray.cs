using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class MaximumProductofTwoElementsInArray
    {
        /**
         * 
         * 
         * 
         * https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
         * 
         * 
         * 
         */
        public class Solution
        {
            public int MaxProduct(int[] nums)
            {

                Stack<int> intstack = new Stack<int>();

                int max = nums[0];
                for (int i = 0; i < 2; i++)
                {
                    int lastindex = 0;
                    int index = 0;
                    foreach (var num in nums)
                    {
                        if (intstack.Count == 0)
                        {
                            if (num >= max && lastindex != index)
                            {
                                max = num;
                                lastindex = index;
                            }
                        }
                        else
                        {
                            if (num >= max && lastindex != index && intstack.Peek() > num)
                            {
                                max = num;
                                lastindex = index;
                            }
                        }
                        index++;
                    }

                    intstack.Push(max);
                    max = nums[0];
                }

                int product = 1;
                while (intstack.Count > 0)
                {
                    product *= (intstack.Pop() - 1);
                }

                return product;

            }
        }
    }
}
