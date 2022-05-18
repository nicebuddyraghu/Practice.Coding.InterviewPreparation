using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InOrderTraversalNonRecurisve
    {
        public void Traverse(BinaryTree root)
        {
            Stack<BinaryTree> treeStack = new Stack<BinaryTree>();

            while (true)
            {
                while (root != null)
                {
                    treeStack.Push(root);
                    root = root.LeftTree;
                }

                if (treeStack.Count == 0) break;
                root = treeStack.Pop();
                System.Console.Write($"=>: {root.Data}");
                root = root.RighTree;
            }


        }
    }
}
