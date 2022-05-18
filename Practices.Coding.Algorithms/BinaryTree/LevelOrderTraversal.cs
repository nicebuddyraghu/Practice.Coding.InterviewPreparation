using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    class LevelOrderTraversal
    {
        public void Travers(BinaryTree root)
        {
            Queue<BinaryTree> queue = new Queue<BinaryTree>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                var node = queue.Dequeue();
                System.Console.Write($"=>: {node.Data}");

                if(node.LeftTree!=null)
                {
                    queue.Enqueue(node.LeftTree);
                }

                if(node.RighTree!=null)
                {
                    queue.Enqueue(node.RighTree);
                }
            }

        }
    }
}
