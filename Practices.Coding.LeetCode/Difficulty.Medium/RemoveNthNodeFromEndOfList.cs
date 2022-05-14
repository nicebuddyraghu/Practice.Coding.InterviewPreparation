namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /// <summary>
    /// ListNode
    /// </summary>
    class ListNode
    {
        /// <summary>
        /// val
        /// </summary>
        public int val;
        /// <summary>
        /// next
        /// </summary>
        public ListNode next;
        /// <summary>
        /// ListNode
        /// </summary>
        /// <param name="val">val</param>
        /// <param name="next">next</param>
        public ListNode(int val = 0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }

    /// <summary>
    /// RemoveNthNodeFromEndOfList
    /// </summary>
    class RemoveNthNodeFromEndOfList
    {
        /// <summary>
        /// RemoveNthFromEnd
        /// </summary>
        /// <param name="head">head</param>
        /// <param name="n">n</param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            System.Collections.Generic.Stack<ListNode> nodeStack = new System.Collections.Generic.Stack<ListNode>();

            //Fill the stack.
            var newHead = head;
            while (newHead != null)
            {
                nodeStack.Push(newHead);
                newHead = newHead.next;
            }

            if (nodeStack.Count == 1 && n == 1)
                return null;

            ListNode preNode = null;
            ListNode nextNode = null;
            //Pop the stack.
            for (int index = 1; index <= n; index++)
            {
                //For nth end index
                if (index == n)
                {
                    if (nodeStack.Peek() != null)
                    {
                        var nthNode = nodeStack.Pop();
                        nthNode.next = null;
                        if (nodeStack.Count > 0)
                        {
                            preNode = nodeStack.Pop();
                            preNode.next = nextNode;
                        }
                        else
                        {
                            preNode = nextNode;
                        }
                    }
                    break;
                }
                else
                {
                    if (nodeStack.Count > 0)
                    {
                        nextNode = nodeStack.Pop();
                    }
                }

            }

            while (nodeStack.Count > 0)
            {
                preNode = nodeStack.Pop();
            }

            return preNode;
        }
    }
}
