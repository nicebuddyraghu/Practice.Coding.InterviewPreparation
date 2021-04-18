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
     * https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/ 
     * 
     * 
     * 
     */
    public class ConvertSortedLinkedListToBinarySearchTree
    {
      
          public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
          }
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

            ListNode rootNode;
            public TreeNode SortedListToBST(ListNode head)
            {

                rootNode = head;

                if (head == null) return null;

                int count = CountNodes(head);

                Console.WriteLine($"Element Count: {count}");

                return ConvertToBst(count);
            }

            public TreeNode ConvertToBst(int count)
            {
                if (count <= 0)
                    return null;

                var left = ConvertToBst(count / 2);

                var root = new TreeNode(rootNode.val);

                root.left = left;

                rootNode = rootNode.next;

                root.right = ConvertToBst(count - count / 2 - 1);

                return root;
            }

            public int CountNodes(ListNode head)
            {
                if (head.next != null)
                    return CountNodes(head.next) + 1;
                else
                    return 1;
            }
        }
    }
}
