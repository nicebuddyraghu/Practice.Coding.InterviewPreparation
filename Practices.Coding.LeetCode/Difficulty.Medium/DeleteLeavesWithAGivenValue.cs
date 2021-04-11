using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class DeleteLeavesWithAGivenValue
    {
        /**
 * Definition for a binary tree node.
        https://leetcode.com/problems/delete-leaves-with-a-given-value/submissions/
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

        internal class Solution
        {
            internal TreeNode RemoveLeafNodes(TreeNode root, int target)
            {

                int count = 0;
                do
                {
                    count = 0;
                    if (DeleteLeafNodes(root, target, ref count))
                        root = null;
                }
                while (count > 0);

                return root;
            }

            internal bool DeleteLeafNodes(TreeNode node, int target, ref int count)
            {
                if (node == null) return false;

                if (node.left == null && node.right == null & node.val == target)
                    return true;

                if (node.left != null)
                    if (DeleteLeafNodes(node.left, target, ref count))
                    {
                        node.left = null;
                        count++;
                    }

                if (node.right != null)
                    if (DeleteLeafNodes(node.right, target, ref count))
                    {
                        node.right = null;
                        count++;
                    }

                return false;
            }
        }

    }
}
