using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InsertIntBinaryTree
    {
        public void Insert(TreeNode root, int value)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

            nodeQueue.Enqueue(root);
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();

                if(node.left==null && node.right==null)
                {
                    node.left = new TreeNode(value, null, null);
                    break;
                }

                if(node.left!=null)
                {
                    nodeQueue.Enqueue(node.left);
                }
                else
                {
                    node.left = new TreeNode(value, null, null);
                    break;
                }

                if(node.right!=null)
                {
                    nodeQueue.Enqueue(node.right);
                }
                else
                {
                    node.left = new TreeNode(value, null, null);
                    break;
                }
            }
        }
    }
}
