using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ThirdMaximumNumer
    {
        /****
         * 
         * 
         * https://leetcode.com/problems/third-maximum-number/
         * 
         */
        internal class Solution
        {
            internal int ThirdMax(int[] nums)
            {
                Stack<int> maxStack = new Stack<int>();

                for (int iterate = 0; iterate < 3; iterate++)
                {
                    int max = maxStack.Count == 0 ? nums[0] : maxStack.Peek();

                    foreach (var num in nums)
                    {
                        if (maxStack.Count > 0 && max == maxStack.Peek() && num < max)
                        {
                            max = num;
                        }
                        else if (num > max && maxStack.Count == 0)
                        {
                            max = num;
                        }
                        else if (num > max && num < maxStack.Peek() && maxStack.Count > 0)
                        {
                            max = num;
                        }
                    }

                    if (maxStack.Count == 0)
                        maxStack.Push(max);
                    else
                    {
                        if (maxStack.Peek() > max)
                        {
                            maxStack.Push(max);
                        }
                    }
                }

                Console.WriteLine($"{maxStack.Count}");

                if (maxStack.Count == 3)
                    return maxStack.Pop();

                Console.WriteLine($"maxStack.Count");

                while (maxStack.Count > 1)
                    maxStack.Pop();

                return maxStack.Pop(); ;


            }
        }
    }
}
