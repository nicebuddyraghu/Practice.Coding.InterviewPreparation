using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class BinaryLinkedListToInteger
    {
        /**
         * 
         * https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/submissions/
         * 
         * 
         */
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

        public class Solution
        {
            public int GetDecimalValue(ListNode head)
            {

                if (head == null) return 0;

                Stack<int> liststack = new Stack<int>();

                int sum = 0;
                while (head != null)
                {
                    liststack.Push(head.val);
                    head = head.next;
                }

                int count = 0;
                Console.WriteLine($"Count:{liststack.Count}");
                while (liststack.Count > 0)
                {
                    sum += liststack.Peek() * ((int)Math.Pow(2, count));
                    liststack.Pop();
                    count++;
                }

                return sum;
            }
        }
    }
}
