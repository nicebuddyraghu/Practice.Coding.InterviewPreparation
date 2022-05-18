using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PostOrderTraversalNonRecurisve
    {
        //Using Two Stack Approach.
        public void Traverse(BinaryTree root)
        {
            Stack<BinaryTree> treeStack = new Stack<BinaryTree>();
            Stack<BinaryTree> tempStack = new Stack<BinaryTree>();

            treeStack.Push(root);
            while(treeStack.Count>0)
            {
                var node = treeStack.Pop();
                tempStack.Push(node);

                if (node.LeftTree != null)
                {
                    treeStack.Push(node.LeftTree);
                }

                if(node.RighTree!=null)
                {
                    treeStack.Push(node.RighTree);
                }
            }

            while(tempStack.Count>0)
            {
                var node = tempStack.Pop();
                System.Console.Write($"=>: {node.Data}");
            }

        }
    }
}
