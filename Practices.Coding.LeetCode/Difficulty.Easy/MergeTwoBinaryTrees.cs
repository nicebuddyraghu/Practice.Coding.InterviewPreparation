using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class MergeTwoBinaryTrees
    {
        /***
         * 
         * 
         * 
         * https://leetcode.com/problems/merge-two-binary-trees/submissions/
         * 
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
            public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
            {

                if (root1 == null && root2 == null)
                    return null;

                TreeNode node = null;

                if (root1 != null && root2 != null)
                {
                    node = new TreeNode(root1.val + root2.val, null, null);

                    if (root1.left != null && root2.left != null)
                        node.left = MergeTrees(root1.left, root2.left);
                    else if (root1.left != null && root2.left == null)
                        node.left = MergeTrees(root1.left, null);
                    else if (root1.left == null && root2.left != null)
                        node.left = MergeTrees(null, root2.left);

                    if (root1.right != null && root2.right != null)
                        node.right = MergeTrees(root1.right, root2.right);
                    else if (root1.right != null && root2.right == null)
                        node.right = MergeTrees(root1.right, null);
                    else if (root1.right == null && root2.right != null)
                        node.right = MergeTrees(null, root2.right);
                }
                else if (root1 != null && root2 == null)
                {
                    node = new TreeNode(root1.val, null, null);

                    if (root1.left != null)
                        node.left = MergeTrees(root1.left, null);

                    if (root1.right != null)
                        node.right = MergeTrees(null, root1.right);
                }
                else if (root1 == null && root2 != null)
                {
                    node = new TreeNode(root2.val, null, null);

                    if (root2.left != null)
                        node.left = MergeTrees(root2.left, null);

                    if (root2.right != null)
                        node.right = MergeTrees(null, root2.right);
                }

                return node;
            }
        }
    }

    }
}
