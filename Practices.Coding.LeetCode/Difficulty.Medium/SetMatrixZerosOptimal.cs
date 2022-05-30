namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/set-matrix-zeroes/
     * 
     */
    public class SetMatrixZerosOptimal
    {
        public class Solution
        {
            public void SetZeroes(int[][] matrix)
            {

                int constant = matrix[0][0];
                bool convertdummyrowtozero = false;
                bool convertdummycolumntozero = false;

                for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                {
                    if (matrix[rowindex][0] == 0)
                    {
                        convertdummycolumntozero = true;
                        break;
                    }
                }

                for (int columnindex = 0; columnindex <= matrix[0].Length - 1; columnindex++)
                {
                    if (matrix[0][columnindex] == 0)
                    {
                        convertdummyrowtozero = true;
                        break;
                    }
                }

                for (int rowindex = 1; rowindex <= matrix.Length - 1; rowindex++)
                {
                    for (int columnindex = 1; columnindex <= matrix[rowindex].Length - 1; columnindex++)
                    {
                        if (matrix[rowindex][columnindex] == 0)
                        {
                            matrix[0][columnindex] = 0;
                            matrix[rowindex][0] = 0;
                        }
                    }
                }

                for (int rowindex = matrix.Length - 1; rowindex >= 1; rowindex--)
                {
                    for (int columnindex = matrix[rowindex].Length - 1; columnindex >= 1; columnindex--)
                    {
                        if (matrix[rowindex][columnindex] != 0)
                        {
                            if (matrix[0][columnindex] == 0 || matrix[rowindex][0] == 0)
                            {
                                matrix[rowindex][columnindex] = 0;
                            }
                        }
                    }
                }



                if (convertdummycolumntozero)
                {
                    for (int rowindex = 0; rowindex <= matrix.Length - 1; rowindex++)
                    {
                        if (matrix[rowindex][0] != 0)
                        {
                            matrix[rowindex][0] = 0;
                        }
                    }
                }

                if (convertdummyrowtozero)
                {
                    for (int columnindex = 0; columnindex <= matrix[0].Length - 1; columnindex++)
                    {
                        if (matrix[0][columnindex] != 0)
                        {
                            matrix[0][columnindex] = 0;
                        }
                    }
                }

            }
        }
    }
}
