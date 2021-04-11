using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class FindTheLargestInEachTreeLevel
    {
        /**
 * Definition for a binary tree node.
    https://leetcode.com/problems/find-largest-value-in-each-tree-row/submissions/
 */

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {

            Dictionary<int, int> levelorderdic = new Dictionary<int, int>();
            public IList<int> LargestValues(TreeNode root)
            {

                TraverseTree(root, 1);

                IList<int> list = new List<int>();
                foreach (var pair in levelorderdic)
                {
                    list.Add(pair.Value);
                }

                return list;
            }

            public int TraverseTree(TreeNode node, int height)
            {
                int lefttreeheight = height;
                int righttreeheight = height;

                if (levelorderdic.ContainsKey(height))
                {
                    if (levelorderdic[height] < node.val)
                        levelorderdic[height] = node.val;
                }
                else
                {
                    if (node != null)
                        levelorderdic.Add(height, node.val);
                }

                if (node != null && node.left != null)
                {
                    lefttreeheight = TraverseTree(node.left, ++lefttreeheight);
                }
                if (node != null && node.right != null)
                {
                    righttreeheight = TraverseTree(node.right, ++righttreeheight);
                }

                return lefttreeheight > righttreeheight ? lefttreeheight : righttreeheight;
            }
        }
    }
}
