using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{ 
    internal class BinaryTreeLevelOrderTraversal
    {
        internal class Solution
        {
           public class TreeNode {
                 public int val;
                 public TreeNode left;
                 public TreeNode right;
                 public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                     this.val = val;
                     this.left = left;
                     this.right = right;
                 }
             }


            Dictionary<int, IList<int>> levelorderdic = new Dictionary<int, IList<int>>();

            internal IList<IList<int>> LevelOrder(TreeNode root)
            {
                TraverseTree(root, 1);

                IList<IList<int>> list = new List<IList<int>>();

                foreach (var pair in levelorderdic)
                {
                    list.Add(pair.Value);
                }

                return list;
            }

            internal int TraverseTree(TreeNode node, int height)
            {
                int lefttreeheight = height;
                int righttreeheight = height;

                if (levelorderdic.ContainsKey(height))
                {
                    levelorderdic[height].Add(node.val);
                }
                else
                {
                    if (node != null)
                        levelorderdic.Add(height, new List<int>() { node.val });
                }

                if (node != null && node.left != null)
                {
                    lefttreeheight = TraverseTree(node.left, ++lefttreeheight);
                }
                if (node != null && node.right != null)
                {
                    righttreeheight = TraverseTree(node.right, ++righttreeheight);
                }

                return lefttreeheight > righttreeheight ? lefttreeheight : righttreeheight;
            }


        }
    }
}
