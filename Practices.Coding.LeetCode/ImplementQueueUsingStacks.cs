using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ImplementQueueUsingStacks
    {
        /****
         * 
         * 
         * https://leetcode.com/problems/implement-queue-using-stacks/submissions/
         * 
         */
        internal class MyQueue
        {

            Stack<int> firststack = new Stack<int>();
            Stack<int> secondstack = new Stack<int>();
            int peek = 0;
            bool isempty = true;

            /** Initialize your data structure here. */
            public MyQueue()
            {
                peek = 0;
                isempty = true;
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                if (secondstack.Count > 0 && firststack.Count == 0)
                {
                    peek = secondstack.Peek();

                    while (secondstack.Count > 0)
                    {
                        firststack.Push(secondstack.Pop());
                    }
                }
                else if (secondstack.Count == 0 && firststack.Count == 0)
                {
                    peek = x;
                }

                firststack.Push(x);
                isempty = false;
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {

                int pop = -1;

                if (firststack.Count > 0 && secondstack.Count == 0)
                {
                    Console.WriteLine($"First Stack Count {firststack.Count}");

                    while (firststack.Count > 1)
                    {
                        secondstack.Push(firststack.Pop());
                        peek = secondstack.Peek();
                    }

                    pop = firststack.Pop();

                    Console.WriteLine($"Second Stack Count {secondstack.Count}");

                    if (secondstack.Count == 0)
                    {
                        isempty = true;
                    }
                }
                else if (firststack.Count == 0 && secondstack.Count > 0)
                {
                    pop = secondstack.Pop();

                    if (secondstack.Count == 0)
                        isempty = true;
                    else
                        peek = secondstack.Peek();
                }

                return pop;
            }

            /** Get the front element. */
            public int Peek()
            {
                return peek;
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return isempty;
            }
        }

        /**
         * Your MyQueue object will be instantiated and called as such:
         * MyQueue obj = new MyQueue();
         * obj.Push(x);
         * int param_2 = obj.Pop();
         * int param_3 = obj.Peek();
         * bool param_4 = obj.Empty();
         */
    }
}
