using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ReverseLinkedList
    {

        /***
         * 
         * https://leetcode.com/problems/reverse-linked-list/
         * 
         */
        internal class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
          }
 
        internal class Solution
        {
            internal ListNode ReverseList(ListNode head)
            {

                Stack<ListNode> nodestack = new Stack<ListNode>();

                if (head == null)
                    return head;

                while (head != null)
                {
                    var nextnode = head.next;

                    if (nodestack.Count == 0)
                    {
                        head.next = null;
                        nodestack.Push(head);
                        Console.WriteLine($"Pushed Node Element:{head.val}");
                    }
                    else
                    {
                        head.next = nodestack.Peek();
                        Console.WriteLine($"Pushed Node Element:{head.val}");
                        nodestack.Push(head);
                    }

                    head = nextnode;
                    if (head != null)
                        Console.WriteLine($"Head Node: {head.val}");
                    if (head == null)
                        break;
                }


                head = nodestack.Pop();

                return head;
            }
        }
    }
}
