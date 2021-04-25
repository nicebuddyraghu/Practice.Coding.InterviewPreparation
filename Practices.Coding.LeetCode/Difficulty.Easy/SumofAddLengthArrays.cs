using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class SumofAddLengthArrays
    {
        /**
         * 
         * 
         * 
         * 
         * https://leetcode.com/problems/sum-of-all-odd-length-subarrays/submissions/
         * 
         * 
         * 
         */

        public class Solution
        {
            public int SumOddLengthSubarrays(int[] arr)
            {

                List<int> listclear = new List<int>();
                int sum = 0;
                for (int iindex = 0; iindex < arr.Length; iindex++)
                {
                    for (int jindex = iindex; jindex < arr.Length; jindex++)
                    {
                        for (int kindex = iindex; kindex <= jindex; kindex++)
                        {
                            listclear.Add(arr[kindex]);
                        }
                        if (listclear.Count % 2 != 0)
                        {
                            foreach (var item in listclear)
                            {
                                sum += item;
                                Console.WriteLine($"Value:{item}");
                            }
                        }

                        listclear.Clear();
                    }
                }

                return sum;
            }
        }
    }
}
