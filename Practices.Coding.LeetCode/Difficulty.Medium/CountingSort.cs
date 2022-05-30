namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * https://leetcode.com/problems/sort-colors/
     * 
     */
    public class CountingSort
    {
        public class Solution
        {
            public void SortColors(int[] nums)
            {

                nums = Sort(nums, 300);
            }

            public int[] Sort(int[] nums, int range)
            {
                int[] rangenums = new int[range];
                int[] output = new int[range];

                for (int index = 0; index < range; index++)
                {
                    rangenums[index] = 0;
                }

                for (int index = 0; index < nums.Length; index++)
                {
                    rangenums[nums[index]] = rangenums[nums[index]] + 1;
                }


                for (int index = 0; index < range; index++)
                {
                    System.Console.Write($"{rangenums[index]}");
                }
                System.Console.WriteLine();


                for (int index = 1; index < range; index++)
                {
                    rangenums[index] = rangenums[index] + rangenums[index - 1];
                }

                for (int index = 0; index < range; index++)
                {
                    System.Console.Write($"{rangenums[index]}");
                }
                System.Console.WriteLine();

                for (int index = nums.Length - 1; index >= 0; index--)
                {
                    output[rangenums[nums[index]]] = nums[index];
                    rangenums[nums[index]] = rangenums[nums[index]] - 1;
                }

                for (int index = nums.Length - 1; index >= 0; index--)
                {
                    nums[index] = output[index + 1];
                }

                return nums;
            }
        }
    }
}
