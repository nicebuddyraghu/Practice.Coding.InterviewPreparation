using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class KthMinimumNodeInBinaryTree
    {
        /**
 * Definition for a binary tree node.
        https://leetcode.com/problems/kth-smallest-element-in-a-bst/submissions/
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

            Stack<int> minStack = new Stack<int>();

            internal int KthSmallest(TreeNode root, int k)
            {

                KthSmallestWithStack(root, k);

                return minStack.Peek();
            }

            internal void KthSmallestWithStack(TreeNode root, int k)
            {
                if (root == null) return;

                if (root.left != null)
                    KthSmallestWithStack(root.left, k);

                if (minStack.Count < k)
                    minStack.Push(root.val);

                Console.WriteLine($"-->{root.val}");

                if (root.right != null)
                    KthSmallestWithStack(root.right, k);
            }
        }
    }
}
