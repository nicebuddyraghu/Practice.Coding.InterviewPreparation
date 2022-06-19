namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class UniquePaths
    {
        public class Solution
        {
            public int UniquePaths(int m, int n)
            {

                int[][] matrix = new int[m][];
                for (int i = 0; i < m; i++)
                {
                    matrix[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0 || j == 0)
                        {
                            matrix[i][j] = 1;
                        }
                        else
                        {
                            matrix[i][j] = matrix[i - 1][j] + matrix[i][j - 1];
                        }
                    }
                }

                return matrix[m - 1][n - 1];
            }


            //Recursive with Memoization.
            /*

            public int UniquePaths(int m, int n) {

                if(m==1 && n==1)
                    return 1;
                else
                    return UniquePathsRecursive(0,0,m-1,n-1);

            }

            Dictionary<string,int> uniquePathsDictionary = new Dictionary<string,int>();

            public int UniquePathsRecursive(int i, int j, int m, int n)
            {
                int pathcount = 0;

                if(uniquePathsDictionary.ContainsKey($"{i}_{j}"))
                    return uniquePathsDictionary[$"{i}_{j}"];

                if(i<m && j<n)
                {
                    pathcount= UniquePathsRecursive(i,j+1,m,n) + UniquePathsRecursive(i+1,j,m,n);
                    uniquePathsDictionary.Add($"{i}_{j}",pathcount);
                    return pathcount;
                }
                else if(i<m && j==n)
                {
                    if(uniquePathsDictionary.ContainsKey($"{i+1}_{j}"))
                            return uniquePathsDictionary[$"{i+1}_{j}"];

                    if(i+1==m)
                    {
                        pathcount= 1;
                        uniquePathsDictionary.Add($"{i+1}_{j}",pathcount);
                        return pathcount;
                    }
                    else
                    {
                        pathcount= UniquePathsRecursive(i+1,j,m,n);
                        uniquePathsDictionary.Add($"{i+1}_{j}",pathcount);
                        return pathcount;
                    }
                }
                else if(i==m && j<n)
                {
                    if(uniquePathsDictionary.ContainsKey($"{i}_{j+1}"))
                         return uniquePathsDictionary[$"{i}_{j+1}"];

                    if(j+1==n)
                    {
                        pathcount= 1;
                        uniquePathsDictionary.Add($"{i}_{j+1}",pathcount);
                        return pathcount;
                    }
                    else
                    {
                        pathcount= UniquePathsRecursive(i,j+1,m,n);
                        uniquePathsDictionary.Add($"{i}_{j+1}",pathcount);
                        return pathcount;
                    }
                }

                return 0;
            }

            */
        }
    }
}
