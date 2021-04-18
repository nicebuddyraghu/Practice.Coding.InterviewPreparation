using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaxLevelSumBinaryTree
    {
        /*
         * 
         * 
         * https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/submissions/
         * 
         * 
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

            Dictionary<int, int> sumdictionary = new Dictionary<int, int>();
            public int MaxLevelSum(TreeNode root)
            {

                if (root == null) return 0;

                int height = 1;

                TraverseTree(root, height);

                int max = sumdictionary[1];
                int maxlevel = 1;
                foreach (var pair in sumdictionary)
                {
                    if (pair.Value > max)
                    {
                        max = pair.Value;
                        maxlevel = pair.Key;
                    }
                }

                return maxlevel;
            }

            public void TraverseTree(TreeNode root, int height)
            {
                if (root == null)
                    return;

                int tempheight = height;

                if (sumdictionary.ContainsKey(height))
                {
                    sumdictionary[height] += root.val;
                }
                else
                {
                    sumdictionary[height] = root.val;
                }

                if (root.left != null)
                    TraverseTree(root.left, ++tempheight);

                tempheight = height;

                if (root.right != null)
                    TraverseTree(root.right, ++tempheight);
            }
        }
    }
}
