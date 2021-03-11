using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MergeTwoSortedLists
    {
        /*
         * 
         * https://leetcode.com/problems/merge-two-sorted-lists/
         * 
         */


        public class Solution
        {
            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
            }
 
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                System.Collections.Generic.Stack<ListNode> nodestack = new System.Collections.Generic.Stack<ListNode>();

                while (l1 != null || l2 != null)
                {
                    int? firstValue = null;
                    int? secondValue = null;

                    if (l1 != null)
                    {
                        firstValue = l1.val;
                        Console.WriteLine($"{firstValue}");
                    }

                    if (l2 != null)
                    {
                        secondValue = l2.val;
                        Console.WriteLine($"{secondValue}");
                    }

                    ListNode newnode = null;
                    if (firstValue.HasValue && secondValue.HasValue)
                    {
                        if (firstValue.Value > secondValue.Value)
                        {
                            newnode = new ListNode(secondValue.Value);

                            if (l2.next != null)
                                l2 = l2.next;
                            else
                                l2 = null;
                        }
                        else if (firstValue.Value < secondValue.Value)
                        {
                            newnode = new ListNode(firstValue.Value);

                            if (l1.next != null)
                                l1 = l1.next;
                            else
                                l1 = null;
                        }
                        else
                        {
                            newnode = new ListNode(firstValue.Value);

                            if (nodestack.Count == 0)
                            {
                                nodestack.Push(newnode);
                                Console.WriteLine($"Empty Stack: Node with value: {newnode.val} is added in the Stack");
                            }
                            else
                            {
                                nodestack.Peek().next = newnode;
                                nodestack.Push(newnode);
                                Console.WriteLine($"Node with value: {newnode.val} is added in the Stack");
                            }

                            newnode = new ListNode(secondValue.Value);

                            if (l1.next != null)
                                l1 = l1.next;
                            else
                                l1 = null;

                            if (l2.next != null)
                                l2 = l2.next;
                            else
                                l2 = null;
                        }


                    }
                    else if (firstValue.HasValue && !secondValue.HasValue)
                    {
                        newnode = new ListNode(firstValue.Value);
                        if (l1.next != null)
                            l1 = l1.next;
                        else
                            l1 = null;
                    }
                    else if (!firstValue.HasValue && secondValue.HasValue)
                    {
                        newnode = new ListNode(secondValue.Value);
                        if (l2.next != null)
                            l2 = l2.next;
                        else
                            l2 = null;
                    }

                    if (nodestack.Count == 0)
                    {
                        nodestack.Push(newnode);
                        Console.WriteLine($"Empty Stack: Node with value: {newnode.val} is added in the Stack");
                    }
                    else
                    {
                        nodestack.Peek().next = newnode;
                        nodestack.Push(newnode);
                        Console.WriteLine($"Node with value: {newnode.val} is added in the Stack");
                    }
                }
                Console.WriteLine($"Stack count: {nodestack.Count}");

                if (nodestack.Count > 0)
                {
                    while (nodestack.Count != 1)
                    {
                        nodestack.Pop();
                    }
                }

                if (nodestack.Count == 1)
                    return nodestack.Pop();
                else
                    return null;
            }
        }
    }
}
