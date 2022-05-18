using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SizeOfBinaryTreeNonRecursive
    {
        public int GetSize(BinaryTree root)
        {
            Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();
            nodeQueue.Enqueue(root);
            int count = 0;
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                count += 1;
                if(node.LeftTree!=null)
                {
                    nodeQueue.Enqueue(node.LeftTree);
                }
                if (node.RighTree != null)
                {
                    nodeQueue.Enqueue(node.RighTree);
                }
            }

            return count;
        }
    }
}
