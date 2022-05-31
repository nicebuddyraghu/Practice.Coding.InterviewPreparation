using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /***
     * 
     * 
     * https://leetcode.com/problems/permutations/
     * 
     * 
     */
    public class PermutationsIntegers
    {
        public class Solution
        {

            public IList<IList<int>> Permute(int[] nums)
            {
                var listofList = Permute(nums, 0, nums.Length - 1);
                IList<int> newlist = new List<int>();
                foreach (var element in nums)
                {
                    newlist.Add(element);
                }

                listofList.Add(newlist);

                return listofList;
            }

            public IList<IList<int>> Permute(int[] nums, int start, int end)
            {
                IList<IList<int>> listOfList = new List<IList<int>>();


                if (start < end)
                {
                    for (int index = start; index <= end; index++)
                    {
                        var temp = nums[end];
                        for (int moveindex = end; moveindex >= start + 1; moveindex--)
                        {
                            nums[moveindex] = nums[moveindex - 1];
                        }
                        nums[start] = temp;

                        if (index != end)
                        {
                            IList<int> newlist = new List<int>();
                            foreach (var element in nums)
                            {
                                newlist.Add(element);
                            }


                            listOfList.Add(newlist);
                        }

                        var sublistofList = Permute(nums, start + 1, end);

                        foreach (var list in sublistofList)
                        {
                            listOfList.Add(list);
                        }

                    }
                }
                return listOfList;
            }
        }
    }
}
