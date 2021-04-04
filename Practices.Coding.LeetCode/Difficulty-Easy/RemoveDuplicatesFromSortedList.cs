using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class RemoveDuplicatesFromSortedList
    {
        /****
         * https://leetcode.com/problems/remove-duplicates-from-sorted-list/
         * 
         */

        internal class Solution
        {
            internal class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
            }
            internal ListNode DeleteDuplicates(ListNode head)
            {

                if (head == null)
                {
                    return null;
                }
                Stack<ListNode> nodeStack = new Stack<ListNode>();

                while (head != null)
                {
                    if (nodeStack.Count == 0)
                    {
                        var newNode = new ListNode(head.val, null);
                        nodeStack.Push(newNode);
                    }
                    else if (nodeStack.Count > 0 && nodeStack.Peek() != null && nodeStack.Peek().val < head.val)
                    {
                        var newNode = new ListNode(head.val, null);
                        nodeStack.Peek().next = newNode;
                        nodeStack.Push(newNode);
                    }
                    head = head.next;
                }

                while (nodeStack.Count != 1)
                {
                    nodeStack.Pop();
                }

                return nodeStack.Pop();
            }
        }
    }
}
