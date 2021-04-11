using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class DeepestLeavesSum
    {
        /**
         *
         *https://leetcode.com/problems/deepest-leaves-sum/submissions/
         *
         *
         *
         */
        internal class Solution
        {
            internal class TreeNode {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                 this.val = val;
                 this.left = left;
                 this.right = right;
             }
         }

            internal int DeepestLeavesSum(TreeNode root)
            {
                int sum = 0;
                var deepestheight = TreeHieght(root, 1);
                Console.WriteLine($"Tree Hieght: {deepestheight}");
                SumDeepestLeaves(root, deepestheight, 1, ref sum);
                return sum;
            }

            internal int TreeHieght(TreeNode root, int treehieght)
            {
                int lefttreehieght = treehieght;
                int rightreehieght = treehieght;

                if (root.left != null)
                    lefttreehieght = TreeHieght(root.left, ++lefttreehieght);

                if (root.right != null)
                    rightreehieght = TreeHieght(root.right, ++rightreehieght);

                return lefttreehieght > rightreehieght ? lefttreehieght : rightreehieght;
            }

            internal int SumDeepestLeaves(TreeNode root, int leafheight, int treeheight, ref int sum)
            {
                if (treeheight == leafheight)
                    sum += root.val;

                int lefttreehieght = treeheight;
                int rightreehieght = treeheight;

                if (root.left != null)
                    lefttreehieght = SumDeepestLeaves(root.left, leafheight, ++lefttreehieght, ref sum);
                if (root.right != null)
                    rightreehieght = SumDeepestLeaves(root.right, leafheight, ++rightreehieght, ref sum);

                return lefttreehieght > rightreehieght ? lefttreehieght : rightreehieght;
            }
        }
    }
}
