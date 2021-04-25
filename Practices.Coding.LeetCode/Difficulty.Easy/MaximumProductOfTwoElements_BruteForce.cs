using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class MaximumProductOfTwoElements_BruteForce
    {
        /*
         * 
         * 
         *https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/submissions/ 
         * 
         * 
         * 
         */
        public class Solution
        {
            public int MaxProduct(int[] nums)
            {

                Stack<int> intstack = new Stack<int>();

                int max = 0;
                int lastindex = 0;
                for (int i = 0; i < 2; i++)
                {
                    int index = 0;
                    foreach (var num in nums)
                    {
                        if (intstack.Count == 0)
                        {
                            if (num >= max)
                            {
                                max = num;
                                lastindex = index;
                            }
                        }
                        else
                        {
                            if (num >= max && lastindex != index && intstack.Peek() >= num)
                            {
                                Console.WriteLine($"Index: {index}");
                                max = num;
                            }
                        }
                        index++;
                    }

                    Console.WriteLine($"Last Index: {lastindex}");
                    intstack.Push(max);
                    Console.WriteLine($"Max: {max}");
                    max = 0;
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
