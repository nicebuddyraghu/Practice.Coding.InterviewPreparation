using Practices.Coding.Algorithms.BinaryTree;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    /**
     * 
     * https://leetcode.com/problems/invert-binary-tree/
     * 
     */
    public class InvertBinaryTree
    {
        public class Solution
        {
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null) return null;

                var mirronode = new TreeNode(root.val, null, null);

                if (root.left != null)
                {
                    mirronode.right = InvertTree(root.left);
                }
                if (root.right != null)
                {
                    mirronode.left = InvertTree(root.right);
                }

                return mirronode;
            }
        }
    }
}
