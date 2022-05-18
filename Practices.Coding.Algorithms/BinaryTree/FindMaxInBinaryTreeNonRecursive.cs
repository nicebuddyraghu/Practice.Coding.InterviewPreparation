using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindMaxInBinaryTreeNonRecursive
    {
        public int Traverse(BinaryTree root, int max)
        {
            Stack<BinaryTree> treeStack = new Stack<BinaryTree>();
            treeStack.Push(root);
            while(treeStack.Count>0)
            {
                var node = treeStack.Pop();
                if(node.Data>max)
                {
                    max = node.Data;
                }

                if(node.RighTree!=null)
                {
                    treeStack.Push(node.RighTree);
                }
                if(node.LeftTree!=null)
                {
                    treeStack.Push(node.LeftTree);
                }
            }

            return max;
        }
    }
}
