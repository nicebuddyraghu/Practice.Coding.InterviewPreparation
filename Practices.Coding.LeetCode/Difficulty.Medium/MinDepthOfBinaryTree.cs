using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class MinDepthOfBinaryTree
    {

        /**
         *
         *
         *https://leetcode.com/problems/minimum-depth-of-binary-tree/submissions/
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
            public int MinDepth(TreeNode root)
            {

                List<int> list = new List<int>();
                GetTreeHeighWithMinDepth(root, 0, list);

                if (root == null) return 0;

                return list.Min();
            }

            public int GetTreeHeighWithMinDepth(TreeNode node, int height, List<int> list)
            {
                if (node == null) return 0;

                int lth = height;
                int rth = height;

                if (node.left != null)
                    lth = GetTreeHeighWithMinDepth(node.left, ++lth, list);
                if (node.right != null)
                    rth = GetTreeHeighWithMinDepth(node.right, ++rth, list);

                if (node.left == null && node.right == null)
                    list.Add(++height);

                return lth > rth ? lth : rth;
            }
        }
    }
}
