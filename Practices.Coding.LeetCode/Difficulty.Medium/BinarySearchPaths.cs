using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class BinarySearchPaths
    {
        public class Solution
        {
            Dictionary<int, int> treecountdictionary = new Dictionary<int, int>();
            public int NumTrees(int n)
            {
                if (n == 0)
                {
                    return 1;
                }

                if (treecountdictionary.ContainsKey(n))
                    return treecountdictionary[n];

                int numtreescount = 0;
                for (int i = 1; i <= n; i++)
                {
                    numtreescount += NumTrees(i - 1) * NumTrees(n - i);
                }

                treecountdictionary.Add(n, numtreescount);

                return numtreescount;
            }
        }
    }
}
