using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SortedArrayByParity
    {
        /**
         * 
         *  https://leetcode.com/problems/sort-array-by-parity/submissions/
         * 
         * 
         */
        internal class Solution
        {
            internal int[] SortArrayByParity(int[] A)
            {

                int[] sorrtedarray = new int[A.Length];

                int newindex = 0;
                for (int index = 0; index < A.Length; index++)
                {
                    if (A[index] % 2 == 0)
                    {
                        sorrtedarray[newindex] = A[index];
                        newindex++;
                    }
                }

                for (int index = 0; index < A.Length; index++)
                {
                    if (A[index] % 2 != 0)
                    {
                        sorrtedarray[newindex] = A[index];
                        newindex++;
                    }
                }

                return sorrtedarray;
            }
        }
    }
}
