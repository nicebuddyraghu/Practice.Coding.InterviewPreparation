using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * https://leetcode.com/problems/set-matrix-zeroes/
     */
    public class SetMatrixZerosQueue
    {
        public class Solution
        {
            public void SetZeroes(int[][] matrix)
            {

                Queue<int> dimensionsqueue = new Queue<int>();

                for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                {
                    for (int columnindex = 0; columnindex <= matrix[rowindex].Length - 1; columnindex++)
                    {
                        if (matrix[rowindex][columnindex] == 0)
                        {
                            dimensionsqueue.Enqueue(rowindex);
                            dimensionsqueue.Enqueue(columnindex);
                        }
                    }
                }

                while (dimensionsqueue.Count > 0)
                {
                    var row = dimensionsqueue.Dequeue();
                    var column = dimensionsqueue.Dequeue();

                    for (int columnindex = 0; columnindex <= matrix[row].Length - 1; columnindex++)
                    {
                        matrix[row][columnindex] = 0;
                    }

                    for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                    {
                        matrix[rowindex][column] = 0;
                    }

                }

            }
        }
    }
}
