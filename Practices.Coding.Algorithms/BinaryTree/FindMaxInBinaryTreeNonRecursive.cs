using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindMaxInBinaryTreeNonRecursive
    {
        public int Traverse(TreeNode root, int max)
        {
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            treeStack.Push(root);
            while(treeStack.Count>0)
            {
                var node = treeStack.Pop();
                if(node.val>max)
                {
                    max = node.val;
                }

                if(node.right!=null)
                {
                    treeStack.Push(node.right);
                }
                if(node.left!=null)
                {
                    treeStack.Push(node.left);
                }
            }

            return max;
        }
    }
}
