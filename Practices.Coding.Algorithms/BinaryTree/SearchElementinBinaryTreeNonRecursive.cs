using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SearchElementinBinaryTreeNonRecursive
    {

        public bool Search(TreeNode root, int value)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            bool exists = false;
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                if (node.val == value)
                {
                    exists= true;
                }

                if(node.left!=null)
                {
                    nodeQueue.Enqueue(node.left);
                }

                if(node.right!=null)
                {
                    nodeQueue.Enqueue(node.right);
                }
            }

            return exists;
        }
    }
}
