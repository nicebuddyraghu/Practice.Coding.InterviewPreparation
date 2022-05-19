using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SizeOfBinaryTreeNonRecursive
    {
        public int GetSize(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            int count = 0;
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                count += 1;
                if(node.left!=null)
                {
                    nodeQueue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                }
            }

            return count;
        }
    }
}
