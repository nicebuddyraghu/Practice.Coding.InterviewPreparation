using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/rotate-image/
     * 
     * 
     */
    public class RotateImage
    {
        public class Solution
        {
            public void Rotate(int[][] matrix)
            {

                for (int row = 0; row < matrix.Length - 1; row++)
                {
                    int maxrow = matrix.Length - 1;
                    int maxcolumn = matrix[row].Length - 1;
                    for (int column = row; column < matrix[row].Length - row - 1; column++)
                    {
                        Console.WriteLine($"Swap at {row}|{column}");
                        var temp = matrix[row][column];
                        matrix[row][column] = matrix[maxcolumn - column][row];
                        matrix[maxcolumn - column][row] = matrix[maxrow - row][maxcolumn - column];
                        matrix[maxrow - row][maxcolumn - column] = matrix[column][maxrow - row];
                        matrix[column][maxrow - row] = temp;
                    }
                }
            }
        }
    }
}
