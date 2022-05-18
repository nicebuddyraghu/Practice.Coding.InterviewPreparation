using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PreOrderTraversalNonRecurisve
    {
        public void Traverse(BinaryTree root)
        {
            Stack<BinaryTree> treeStack = new Stack<BinaryTree>();
            var node = root;
            treeStack.Push(root);
            while (treeStack.Count > 0)
            {
                node = treeStack.Pop();
                System.Console.Write($"=>: {node.Data}");

                if (node.RighTree != null)
                {
                    treeStack.Push(node.RighTree);
                }

                if (node.LeftTree != null)
                {
                    treeStack.Push(node.LeftTree);
                }
            }

        }
    }
}
