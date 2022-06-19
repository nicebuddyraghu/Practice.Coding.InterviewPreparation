using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaximumPathSums
    {
        public class GridNode
        {
            public int PathValue { get; set; }
            public int Number { get; set; }
            public int Visited { get; set; }
            public GridNode RightNode { get; set; }
            public GridNode DownNode { get; set; }
            public GridNode(int pathvalue, int number)
            {
                PathValue = pathvalue;
                Number = number;
                Visited = 0;
                RightNode = null;
                DownNode = null;
            }
        }

        public class Solution
        {
            public int MinPathSum(int[][] grid)
            {

                Dictionary<int, GridNode> gridNodes = new Dictionary<int, GridNode>();

                int count = 1;
                for (int row = 0; row < grid.Length; row++)
                {
                    for (int column = 0; column < grid[row].Length; column++)
                    {
                        var gridnode = new GridNode(grid[row][column], count);
                        gridNodes.Add(count, gridnode);
                        count++;
                    }
                }

                count = 1;
                for (int row = 0; row < grid.Length; row++)
                {
                    for (int column = 0; column < grid[row].Length; column++)
                    {
                        if (gridNodes[count] != null)
                        {
                            //Right Orange.
                            if (column + 1 < grid[row].Length)
                            {
                                gridNodes[count].RightNode = (gridNodes[count + 1]);
                            }
                            //Down Orange.
                            if (row + 1 < grid.Length)
                            {
                                gridNodes[count].DownNode = (gridNodes[count + grid[row].Length]);
                            }
                        }
                        count++;
                    }
                }


                int minpathValue = Int32.MaxValue;
                foreach (var node in gridNodes.Values)
                {
                    if (node != null && node.Visited == 0)
                    {
                        var pathvalue = Traverse(node);
                        minpathValue = minpathValue > pathvalue ? pathvalue : minpathValue;
                    }
                }

                return minpathValue;
            }

            Dictionary<int, int> pathvaluedictionary = new Dictionary<int, int>();
            public int Traverse(GridNode node)
            {
                if (pathvaluedictionary.ContainsKey(node.Number))
                    return pathvaluedictionary[node.Number];

                if (node.RightNode == null && node.DownNode == null)
                {
                    pathvaluedictionary.Add(node.Number, node.PathValue);
                    //Console.WriteLine($"Visiting the node {node.Number}");
                    node.Visited = 1;
                    return node.PathValue;
                }


                //Console.WriteLine($"Visiting the node {node.Number}");
                int right = -1;
                int down = -1;
                if (node.RightNode != null)
                    right = Traverse(node.RightNode);
                if (node.DownNode != null)
                    down = Traverse(node.DownNode);

                node.Visited = 1;

                int pathvalue = node.PathValue;
                if (right != -1 && down != -1)
                {
                    pathvaluedictionary.Add(node.Number, pathvalue + Math.Min(right, down));
                    return pathvalue + Math.Min(right, down);
                }
                else if (right > 0 && down == -1)
                {
                    pathvaluedictionary.Add(node.Number, pathvalue + right);
                    return pathvalue + right;
                }
                else if (down > 0 && right == -1)
                {
                    pathvaluedictionary.Add(node.Number, pathvalue + down);
                    return pathvalue + down;
                }
                else
                {
                    pathvaluedictionary.Add(node.Number, pathvalue);
                    return pathvalue;
                }

                return node.PathValue;
            }
        }
    }
}
