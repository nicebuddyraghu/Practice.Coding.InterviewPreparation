using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class LevelOrderOfTreeInReverseOrder
    {
        public void LevelOrderInReverseOrder(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            Stack<TreeNode> nodeStack = new Stack<TreeNode>();

            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                nodeStack.Push(node);

                if (node.left != null)
                    nodeQueue.Enqueue(node.left);

                if (node.right != null)
                    nodeQueue.Enqueue(node.right);
            }

            while(nodeStack.Count>0)
            {
                var node = nodeStack.Pop();
                System.Console.Write($"=>: {node.val}");
            }
        }
    }
}
