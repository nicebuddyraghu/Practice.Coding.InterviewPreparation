using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SearchElementinBinaryTreeNonRecursive
    {

        public bool Search(BinaryTree root, int value)
        {
            Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();
            nodeQueue.Enqueue(root);
            bool exists = false;
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();
                if (node.Data == value)
                {
                    exists= true;
                }

                if(node.LeftTree!=null)
                {
                    nodeQueue.Enqueue(node.LeftTree);
                }

                if(node.RighTree!=null)
                {
                    nodeQueue.Enqueue(node.RighTree);
                }
            }

            return exists;
        }
    }
}
