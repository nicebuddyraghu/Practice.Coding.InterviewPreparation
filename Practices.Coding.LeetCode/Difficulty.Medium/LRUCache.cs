using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class LRUCacheDesign
    {
        public class Node
        {
            public int Val { get; set; }
            public int Key { get; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data, int key)
            {
                Key = key;
                Val = data;
                Left = null;
                Right = null;
            }
        }

        public class LRUCache
        {

            int Capacity = 0;
            int size = 0;
            Dictionary<int, Node> keydictionary = new Dictionary<int, Node>();
            Node rightmost = null;
            Node leftmost = null;
            public LRUCache(int capacity)
            {
                Capacity = capacity;
            }

            public int Get(int key)
            {

                Console.WriteLine($"Getting Key {key}");
                if (!keydictionary.ContainsKey(key))
                {
                    return -1;
                }

                var node = keydictionary[key];

                if (Capacity == 1)
                    return node.Val;

                if (node.Left != null && node.Right != null)
                {
                    node.Left.Right = node.Right;
                    node.Right.Left = node.Left;
                }
                else if (node.Right != null && node.Left == null)
                {
                    node.Right.Left = node.Left;
                    leftmost = node.Right;
                }
                else if (node.Left != null && node.Right == null)
                {
                    return node.Val;
                }

                node.Right = rightmost.Right;
                rightmost.Right = node;
                node.Left = rightmost;
                rightmost = node;

                return node.Val;
            }

            public void Put(int key, int value)
            {

                var newnode = new Node(value, key);

                if (!keydictionary.ContainsKey(key))
                {
                    Console.WriteLine($"Adding {key}:{value}");
                    keydictionary.Add(key, newnode);
                    size++;
                    if (rightmost != null)
                    {
                        rightmost.Right = newnode;
                        rightmost.Right.Left = rightmost;
                        if (leftmost == null)
                        {
                            leftmost = rightmost;
                        }
                        rightmost = newnode;
                        RemoveLeftmostNode();
                    }
                    else
                    {
                        rightmost = newnode;
                    }
                }
                else
                {
                    keydictionary[key].Val = value;
                    Get(key);
                }
            }

            public void RemoveLeftmostNode()
            {
                if (size > Capacity)
                {
                    keydictionary.Remove(leftmost.Key);
                    size--;

                    Console.WriteLine($"Removed {leftmost.Key}:{leftmost.Val} And Total Count {size}");
                    leftmost.Right.Left = leftmost.Left;
                    leftmost = leftmost.Right;
                }
            }
        }

        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */
    }
}
