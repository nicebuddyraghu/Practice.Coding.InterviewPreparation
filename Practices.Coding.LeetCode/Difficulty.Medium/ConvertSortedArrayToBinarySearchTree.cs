using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /****
     * 
     * 
     *
     * https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
     * 
     *
     */
    public class ConvertSortedArrayToBinarySearchTree
    {
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

            public TreeNode SortedArrayToBST(int[] nums)
            {

                if (nums == null || nums.Length == 0)
                    return null;

                return SortedArrayToBst(nums, 0, nums.Length - 1);
            }

            public TreeNode SortedArrayToBst(int[] arr, int start, int end)
            {
                if (start > end)
                    return null;

                int mid = (start + end) / 2;

                TreeNode node = new TreeNode(arr[mid]);

                node.left = SortedArrayToBst(arr, start, mid - 1);

                node.right = SortedArrayToBst(arr, mid + 1, end);

                return node;
            }
        }
    }
}
