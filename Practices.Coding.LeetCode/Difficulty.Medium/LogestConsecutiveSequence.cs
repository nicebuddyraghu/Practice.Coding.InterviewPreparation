namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class LogestConsecutiveSequence
    {
        /*
         * 
         * https://leetcode.com/problems/longest-consecutive-sequence/
         */

        public class Solution
        {
            public int LongestConsecutive(int[] nums)
            {

                if (nums.Length == 0) return 0;
                System.Collections.Generic.Dictionary<int, int> indexdictionary = new System.Collections.Generic.Dictionary<int, int>();
                System.Collections.Generic.Dictionary<int, int> sequencedictionary = new System.Collections.Generic.Dictionary<int, int>();
                for (int index = 0; index < nums.Length; index++)
                {
                    if (!indexdictionary.ContainsKey(nums[index]))
                        indexdictionary.Add(nums[index], index);
                }

                int sequence = 0;

                for (int index = 0; index < nums.Length; index++)
                {
                    var tempnum = nums[index];
                    int tempsequence = 0;

                    while (indexdictionary.ContainsKey(tempnum))
                    {
                        tempnum++;
                        if (sequencedictionary.ContainsKey(tempnum))
                        {
                            tempsequence += sequencedictionary[tempnum];
                            tempsequence++;
                            break;
                        }
                        tempsequence++;
                    }

                    tempnum = nums[index];
                    if (!sequencedictionary.ContainsKey(tempnum))
                    {
                        sequencedictionary.Add(tempnum, tempsequence);
                    }

                    if (tempsequence > sequence)
                    {
                        sequence = tempsequence;
                    }
                }

                return sequence;
            }
        }
    }
}
