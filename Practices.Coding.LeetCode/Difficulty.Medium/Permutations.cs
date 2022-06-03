using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/permutations/
     * 
     * 
     */
    public class Permutations
    {
        public class Solution
        {

            public IList<IList<int>> Permute(int[] nums)
            {
                return Permute(nums, 0, nums.Length - 1);
            }

            public void AddPermutationToTheList(int[] nums, IList<IList<int>> listOfPermutations)
            {
                List<int> list = new List<int>();
                for (int index = 0; index < nums.Length; index++)
                {
                    list.Add(nums[index]);
                }

                listOfPermutations.Add(list);
            }

            public void Swap(int[] nums, int index1, int index2)
            {
                var temp = nums[index1];
                nums[index1] = nums[index2];
                nums[index2] = temp;
            }

            public IList<IList<int>> Permute(int[] nums, int start, int end)
            {
                IList<IList<int>> listOfPermutations = new List<IList<int>>();

                if (start == end)
                {
                    AddPermutationToTheList(nums, listOfPermutations);
                }
                else if (start < end)
                {
                    for (int index = start; index <= end; index++)
                    {
                        Swap(nums, start, index);

                        var subpermutations = Permute(nums, start + 1, end);

                        foreach (var list in subpermutations)
                        {
                            listOfPermutations.Add(list);
                        }

                        Swap(nums, start, index);
                    }
                }


                return listOfPermutations;
            }
        }
    }
}
