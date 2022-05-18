using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class LevelOrderOfTreeInReverseOrder
    {
        public void LevelOrderInReverseOrder(BinaryTree root)
        {
            Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();
            nodeQueue.Enqueue(root);
            Stack<BinaryTree> nodeStack = new Stack<BinaryTree>();

            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                nodeStack.Push(node);

                if (node.LeftTree != null)
                    nodeQueue.Enqueue(node.LeftTree);

                if (node.RighTree != null)
                    nodeQueue.Enqueue(node.RighTree);
            }

            while(nodeStack.Count>0)
            {
                var node = nodeStack.Pop();
                System.Console.Write($"=>: {node.Data}");
            }
        }
    }
}
