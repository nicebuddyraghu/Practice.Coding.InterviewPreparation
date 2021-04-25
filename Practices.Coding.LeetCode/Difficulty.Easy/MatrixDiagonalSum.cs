using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class MatrixDiagonalSum
    {
        /**
         * 
         * 
         * 
         * https://leetcode.com/problems/matrix-diagonal-sum/submissions/
         * 
         * 
         * 
         */
        public class Solution
        {
            public int DiagonalSum(int[][] mat)
            {

                int sum = 0;
                int colindex = mat.Length - 1;
                int rowindex = 0;
                for (int row = 0; row < mat.Length; row++, rowindex++, colindex--)
                {
                    sum += mat[row][row];
                    if (colindex != rowindex)
                    {
                        sum += mat[rowindex][colindex];
                    }
                }

                return sum;
            }
        }
    }
}
