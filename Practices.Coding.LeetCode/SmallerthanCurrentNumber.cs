using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SmallerthanCurrentNumber
    {
        internal class Solution
        {
            internal int[] SmallerNumbersThanCurrent(int[] nums)
            {

                int[] countarray = new int[nums.Length];

                for (int firstindex = 0; firstindex < nums.Length; firstindex++)
                {
                    var count = 0;
                    for (int secondindex = 0; secondindex < nums.Length; secondindex++)
                    {
                        if (nums[firstindex] > nums[secondindex])
                        {
                            count++;
                        }
                    }
                    countarray[firstindex] = count;
                }

                return countarray;
            }
        }
    }
}
