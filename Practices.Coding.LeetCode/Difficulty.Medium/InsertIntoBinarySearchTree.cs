using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class InsertIntoBinarySearchTree
    {
        /**
         * 
         * 
         * https://leetcode.com/problems/insert-into-a-binary-search-tree/submissions/
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
            public TreeNode InsertIntoBST(TreeNode root, int val)
            {
                TraverseTree(root, val);

                if (root == null)
                    root = new TreeNode(val);
                return root;
            }

            public void TraverseTree(TreeNode root, int val)
            {
                if (root == null)
                    return;

                if (root.val < val)
                {
                    if (root.right != null)
                        TraverseTree(root.right, val);
                    else
                        root.right = new TreeNode(val);
                }
                else
                {
                    if (root.left != null)
                        TraverseTree(root.left, val);
                    else
                        root.left = new TreeNode(val);
                }
            }
        }
    }
}
