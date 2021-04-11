using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class CountCompleteBinaryTreeNodes
    {
        /**
         *
         *https://leetcode.com/problems/count-complete-tree-nodes/submissions/
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
            public int CountNodes(TreeNode root)
            {

                if (root == null) return 0;

                int totalnodes = 0;

                if (root.left != null)
                    totalnodes += CountNodes(root.left);

                totalnodes += 1;

                if (root.right != null)
                    totalnodes += CountNodes(root.right);

                return totalnodes;
            }
        }
    }
}
