using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/number-of-islands/
     * 
     * 
     * 
     */
    public class NumberOfIslands
    {
        public class LandNode
        {
            public int landnumber { get; }
            public int IsVisited { get; set; }
            public LandNode Right { get; set; }
            public LandNode Left { get; set; }
            public LandNode Top { get; set; }
            public LandNode Down { get; set; }

            public LandNode(int number)
            {
                landnumber = number;
                IsVisited = 0;
            }
        }

        public class Solution
        {
            public int NumIslands(char[][] grid)
            {

                Dictionary<int, LandNode> landsDictionary = new Dictionary<int, LandNode>();

                int count = 1;
                for (int rowindex = 0; rowindex < grid.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < grid[rowindex].Length; columnindex++)
                    {
                        if (grid[rowindex][columnindex] == '1')
                        {
                            landsDictionary.Add(count, new LandNode(count));
                        }
                        else
                        {
                            landsDictionary.Add(count, null);
                        }
                        count++;
                    }
                }

                //Assigning Adjustcent nodes.
                count = 1;
                for (int rowindex = 0; rowindex < grid.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < grid[rowindex].Length; columnindex++)
                    {
                        if (grid[rowindex][columnindex] == '1')
                        {
                            if (landsDictionary.ContainsKey(count))
                            {
                                var landnode = landsDictionary[count];
                                landnode.Right = null;
                                landnode.Left = null;
                                landnode.Top = null;
                                landnode.Down = null;

                                //Right Node.
                                if (columnindex + 1 <= grid[rowindex].Length - 1)
                                {
                                    landnode.Right = landsDictionary[count + 1];
                                }
                                if (columnindex - 1 >= 0)
                                {
                                    landnode.Left = landsDictionary[count - 1];
                                }
                                if (rowindex - 1 >= 0)
                                {
                                    landnode.Top = landsDictionary[count - grid[rowindex].Length];
                                }
                                if (rowindex + 1 <= grid.Length - 1)
                                {
                                    landnode.Down = landsDictionary[count + grid[rowindex].Length];
                                    Console.WriteLine($"For landnumber:{landnode.landnumber},down is {count + grid.Length + 1}");
                                }
                            }
                        }
                        count++;
                    }
                }

                foreach (var landnode in landsDictionary)
                {
                    if (landnode.Value != null && landnode.Value.IsVisited == 0)
                    {
                        Dfs(landnode.Value);
                        totalnumberofislands++;
                    }
                }

                Console.WriteLine($"Total Count of landnodes : {totalnumberofislands}");
                return totalnumberofislands;

            }

            int totalnumberofislands = 0;
            public void Dfs(LandNode landnode)
            {
                Console.WriteLine($"Visiting node: {landnode.landnumber}");
                landnode.IsVisited = 1;

                if (landnode.Right != null && landnode.Right.IsVisited == 0)
                {
                    Dfs(landnode.Right);
                }
                if (landnode.Down != null && landnode.Down.IsVisited == 0)
                {
                    Dfs(landnode.Down);
                }
                if (landnode.Left != null && landnode.Left.IsVisited == 0)
                {
                    Dfs(landnode.Left);
                }
                if (landnode.Top != null && landnode.Top.IsVisited == 0)
                {
                    Dfs(landnode.Top);
                }

            }
        }
    }
}
