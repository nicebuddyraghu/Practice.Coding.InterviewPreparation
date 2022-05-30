using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * https://leetcode.com/problems/set-matrix-zeroes/submissions/
     * 
     */
    public class SetMatrixZeros
    {
        public class Solution
        {
            public void SetZeroes(int[][] matrix)
            {

                List<int> rowlist = new List<int>();
                List<int> columnlist = new List<int>();


                for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                {
                    for (int columnindex = 0; columnindex <= matrix[rowindex].Length - 1; columnindex++)
                    {
                        if (matrix[rowindex][columnindex] == 0)
                        {
                            if (!rowlist.Contains(rowindex))
                            {
                                rowlist.Add(rowindex);
                            }
                            if (!columnlist.Contains(columnindex))
                            {
                                columnlist.Add(columnindex);
                            }
                        }
                    }
                }

                foreach (var row in rowlist)
                {
                    for (int columnindex = 0; columnindex <= matrix[row].Length - 1; columnindex++)
                    {
                        matrix[row][columnindex] = 0;
                    }
                }

                foreach (var column in columnlist)
                {
                    for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                    {
                        matrix[rowindex][column] = 0;
                    }
                }
            }
        }
    }
}
