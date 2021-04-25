using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class SymetricTree
    {

        /**
         * 
         * 
         * https://leetcode.com/problems/symmetric-tree/submissions/
         * 
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

            Stack<int?> leftstack = new Stack<int?>();
            Stack<int?> rightstack = new Stack<int?>();

            public bool IsSymmetric(TreeNode root)
            {

                if (root == null) return false;

                if (root.left != null)
                    TraverseLeftTree(root.left);
                else
                    leftstack.Push(null);

                if (root.right != null)
                    TraverseRightTree(root.right);
                else
                    rightstack.Push(null);

                if (leftstack.Count != rightstack.Count)
                    return false;

                bool issymetric = true;
                while (leftstack.Count > 0 && rightstack.Count > 0)
                {
                    if (leftstack.Pop() != rightstack.Pop())
                    {
                        issymetric = false;
                        break;
                    }
                }

                return issymetric;
            }

            public void TraverseLeftTree(TreeNode root)
            {
                if (root == null)
                    return;

                if (root.left != null)
                    TraverseLeftTree(root.left);

                if (root.right != null)
                    TraverseLeftTree(root.right);
                else
                    leftstack.Push(null);

                leftstack.Push(root.val);
            }

            public void TraverseRightTree(TreeNode root)
            {
                if (root == null)
                    return;

                if (root.right != null)
                    TraverseRightTree(root.right);

                if (root.left != null)
                    TraverseRightTree(root.left);
                else
                    rightstack.Push(null);

                rightstack.Push(root.val);
            }


        }
    }
}
