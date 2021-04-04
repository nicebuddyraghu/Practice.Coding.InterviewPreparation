using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    //Easy but for me took time.
    /***
     * 
     * https://leetcode.com/problems/min-stack/
     */
    public class MinStack
        {

            /** initialize your data structure here. */

            public class ListNode
            {
                public int val { get; set; }
                public ListNode next { get; set; }
                public ListNode prev { get; set; }
                public ListNode(int nodeval, ListNode nextnode = null, ListNode prevnode = null)
                {
                    val = nodeval;
                    next = nextnode;
                    prev = prevnode;
                }
            }

            public MinStack.ListNode head;
            private int min;
            private int count;

            public MinStack()
            {
                head = null;
                min = 0;
                count = 0;
            }

            public void Push(int x)
            {

                if (head == null)
                {
                    var newnode = new ListNode(x, null, null);
                    head = newnode;
                    min = x;
                }
                else
                {
                    var newnode = new ListNode(x, null, head);
                    head.next = newnode;
                    head = head.next;
                    if (min > x)
                        min = x;
                }
                count++;
                Console.WriteLine($"Pushed :{head.val}");
            }

            public void Pop()
            {

                Console.WriteLine($"Going to Pop:{head.val}");

                if (min != head.val)
                {
                    head = head.prev;
                    head.next = null;
                }
                else if (min == head.val)
                {
                    if (head.prev == null)
                    {
                        min = 0;
                        head = null;
                    }
                    else
                    {

                        head = head.prev;
                        head.next = null;
                        min = head.val;

                        while (head.prev != null)
                        {
                            if (min >= head.prev.val)
                                min = head.prev.val;
                            head = head.prev;
                        }

                        while (head.next != null)
                            head = head.next;
                    }
                }

                if (head != null)
                {
                    Console.WriteLine($"Top Element:{head.val}");
                    count--;
                }
            }

            public int Top()
            {

                if (head != null)
                    return head.val;
                else
                    return 0;
            }

            public int GetMin()
            {
                return min;
            }
        }


        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(x);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
