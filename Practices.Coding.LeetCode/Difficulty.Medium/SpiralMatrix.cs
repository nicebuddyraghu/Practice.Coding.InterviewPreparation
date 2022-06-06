using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/spiral-matrix/
     * 
     */
    public class SpiralMatrix
    {
        public class Solution
        {
            public IList<int> SpiralOrder(int[][] matrix)
            {

                int[][] visited = new int[matrix.Length][];

                for (int row = 0; row <= matrix.Length - 1; row++)
                {
                    visited[row] = new int[matrix[row].Length];
                    for (int column = 0; column < matrix[row].Length - 1; column++)
                    {
                        visited[row][column] = 0;
                    }
                }
                SpiralOrder(matrix, 0, 0, ref visited);

                return spiralOrderList;
            }
            IList<int> spiralOrderList = new List<int>();
            public void SpiralOrder(int[][] matrix, int row, int column, ref int[][] visited)
            {
                if (row >= 0 && row <= matrix.Length - 1 && column >= 0 && column <= matrix[row].Length - 1)
                {
                    visited[row][column] = 1;
                    spiralOrderList.Add(matrix[row][column]);
                }

                if ((column + 1 <= matrix[row].Length - 1 && visited[row][column + 1] != 1) && (row - 1 >= 0 && visited[row - 1][column] != 1))
                {
                    SpiralOrder(matrix, row - 1, column, ref visited);
                }
                else if (column + 1 <= matrix[row].Length - 1 && visited[row][column + 1] != 1)
                {
                    SpiralOrder(matrix, row, column + 1, ref visited);
                }

                if (row + 1 <= matrix.Length - 1 && visited[row + 1][column] != 1)
                {
                    SpiralOrder(matrix, row + 1, column, ref visited);
                }
                if (column - 1 >= 0 && visited[row][column - 1] != 1)
                {
                    SpiralOrder(matrix, row, column - 1, ref visited);
                }
                if (row - 1 >= 0 && visited[row - 1][column] != 1)
                {
                    SpiralOrder(matrix, row - 1, column, ref visited);
                }
            }
        }
    }
}
