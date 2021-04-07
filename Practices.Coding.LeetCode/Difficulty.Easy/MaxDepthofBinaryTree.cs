using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MaxDepthofBinaryTree
    {
        /**
         * https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/
         * 
         * 
         * 
         * 
         */

        // Definition for a binary tree node.
        internal class TreeNode
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
         
        internal class Solution
        {
            internal int MaxDepth(TreeNode root)
            {
                int parentDepth = 1;
                int leftChildrenDepth = 0;
                int rightChildrenDepth = 0;

                if (root == null)
                    return 0;

                if (root != null && root.left == null && root.right == null)
                {
                    return parentDepth;
                }
                if (root != null && root.left != null)
                {
                    leftChildrenDepth = MaxDepth(root.left);
                }
                if (root != null && root.right != null)
                {
                    rightChildrenDepth = MaxDepth(root.right);
                }

                return parentDepth + ((leftChildrenDepth > rightChildrenDepth) ? leftChildrenDepth : rightChildrenDepth);
            }
        }
    }
}
