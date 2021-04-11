using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class ConvertBstToGreaterTree
    {
        /**
        * Definition for a binary tree node.
        https://leetcode.com/problems/convert-bst-to-greater-tree/submissions/
        */

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
            public TreeNode ConvertBST(TreeNode root)
            {

                int totalsum = 0;
                CalculateGreaterSumAtNodeLevel(root, 0);

                return root;
            }


            internal int CalculateGreaterSumAtNodeLevel(TreeNode node, int totalsum)
            {

                int rightsum = 0;
                int leftsum = 0;
                int nodeval = 0;

                if (node == null)
                    return 0;

                nodeval = node.val;

                if (node.right != null)
                {
                    rightsum = CalculateGreaterSumAtNodeLevel(node.right, totalsum);
                }

                int greatvalue = rightsum + totalsum + nodeval;
                node.val = greatvalue;

                if (node.left != null)
                {
                    leftsum = CalculateGreaterSumAtNodeLevel(node.left, greatvalue);
                }

                return rightsum + leftsum + nodeval;
            }
        }
    }
}
