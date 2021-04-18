using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class SearchInABinarySearchTree
    {
        /**
         * 
         * 
         * 
         * 
         * https://leetcode.com/problems/search-in-a-binary-search-tree/submissions/
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
            public TreeNode SearchBST(TreeNode root, int val)
            {

                if (root == null)
                    return null;

                if (root.val == val)
                    return root;

                TreeNode node = null;
                if (root.left != null)
                    node = SearchBST(root.left, val);

                if (node != null)
                    return node;

                if (root.right != null)
                    node = SearchBST(root.right, val);

                if (node != null)
                    return node;

                return null;

            }
        }
    }
}
