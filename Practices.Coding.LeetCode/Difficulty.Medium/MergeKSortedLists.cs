using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /***
     * 
     * 
     * 
     * 
     * https://leetcode.com/problems/merge-k-sorted-lists/submissions/
     * 
     */
    public class MergeKSortedLists
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

        public class Solution
        {
            public ListNode MergeKLists(ListNode[] lists)
            {
                return Merge(lists, 0, lists.Length - 1);
            }

            public ListNode Merge(ListNode[] lists, int start, int end)
            {
                Console.WriteLine($"^start:{start}^ ^end:{end}^");
                if (start == end)
                {
                    return lists[start];
                }
                else if (start < end)
                {
                    int mid = (end + start) / 2;

                    var list1 = Merge(lists, start, mid);
                    var list2 = Merge(lists, mid + 1, end);

                    if (list1 == null)
                        return list2;
                    if (list2 == null)
                        return list1;

                    if (list1 == null && list2 == null)
                    {
                        return null;
                    }

                    ListNode tempnode = null;
                    ListNode startnode = null;

                    while (list1 != null && list2 != null)
                    {
                        ListNode newnode = null;
                        if (list1.val > list2.val)
                        {
                            newnode = new ListNode(list2.val);
                            list2 = list2.next;
                        }
                        else
                        {
                            newnode = new ListNode(list1.val);
                            list1 = list1.next;
                        }

                        if (newnode != null)
                        {
                            tempnode = GetTempNode(tempnode, newnode, ref startnode);
                        }
                    }

                    while (list1 == null && list2 != null)
                    {
                        var newnode = new ListNode(list2.val);
                        tempnode = GetTempNode(tempnode, newnode, ref startnode);
                        list2 = list2.next;
                    }

                    while (list2 == null && list1 != null)
                    {
                        var newnode = new ListNode(list1.val);
                        tempnode = GetTempNode(tempnode, newnode, ref startnode);
                        list1 = list1.next;
                    }

                    return startnode;
                }

                return null;
            }

            public ListNode GetTempNode(ListNode tempnode, ListNode newnode, ref ListNode startnode)
            {
                if (tempnode == null)
                {
                    tempnode = newnode;
                    startnode = tempnode;
                }
                else
                {
                    tempnode.next = newnode;
                    tempnode = tempnode.next;
                }

                return tempnode;
            }
        }

    }
}
