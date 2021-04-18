using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class PsedoPolindromePaths
    {
        /**
         * 
         * 
         * https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/
         */


        //Pending
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            Stack<int> nodestack = new Stack<int>();
            int polindromecount = 0;

            public int PseudoPalindromicPaths(TreeNode root)
            {

                TraverseTree(root);
                return polindromecount;
            }

            public void TraverseTree(TreeNode node)
            {
                if (node == null)
                    return;

                nodestack.Push(node.val);

                bool isLeaf = false;
                if (node.left == null && node.right == null)
                {
                    CheckPolindrome();
                    isLeaf = true;
                }

                if (node.left != null)
                    TraverseTree(node.left);
                if (node.right != null)
                    TraverseTree(node.right);

                if (nodestack.Count > 0 && !isLeaf)
                    nodestack.Pop();
            }

            public void CheckPolindrome()
            {
                Dictionary<int, int> numbercountdic = new Dictionary<int, int>();

                Stack<int> tempnodestack = new Stack<int>();

                Console.WriteLine($"Stack Count: {nodestack.Count}");

                int count = nodestack.Count;
                for (int index = 0; index < count; index++)
                {
                    if (numbercountdic.ContainsKey(nodestack.Peek()))
                        numbercountdic[nodestack.Peek()]++;
                    else
                        numbercountdic.Add(nodestack.Peek(), 1);

                    tempnodestack.Push(nodestack.Pop());
                }

                bool onealreadyexists = false;
                bool isPolindrome = true;
                foreach (var pair in numbercountdic)
                {
                    if (pair.Value == 1)
                        if (!onealreadyexists)
                            onealreadyexists = true;
                        else
                            isPolindrome = false;

                    if (pair.Value != 1 && pair.Value % 2 != 0 && numbercountdic.Count > 1)
                        isPolindrome = false;
                }

                if (isPolindrome)
                {
                    polindromecount++;
                    Console.WriteLine($"PolinDrom Counted: {polindromecount}");
                }

                for (int index = 0; index < count; index++)
                {
                    Console.Write($"-->:{tempnodestack.Peek()}");
                    nodestack.Push(tempnodestack.Pop());
                }

                Console.WriteLine();

                nodestack.Pop();
            }
        }
    }
}
