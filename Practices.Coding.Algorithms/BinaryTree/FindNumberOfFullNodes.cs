using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree 
{
    public class FindNumberOfFullNodes
    {
        public int GetFullNodeCount(TreeNode root)
        {
            int fullnodecount = 0;
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                if (node.left != null)
                {
                    nodeQueue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                }

                if (node.left != null && node.right != null)
                    fullnodecount += 1;
            }
            return fullnodecount;
        }
    }
}
