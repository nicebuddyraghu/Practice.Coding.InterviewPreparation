using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class ReorganizeString
    {
        public class Node<T>
        {
            public T Data { get; set; }
            public int Count { get; set; }
            public Node(T data, int count)
            {
                Data = data;
                Count = count;
            }
        }

        public class MinHeap<T>
        {
            List<Node<T>> heapList = new List<Node<T>>();

            public int Size()
            {
                return heapList.Count;
            }

            public void Print()
            {
                foreach (var item in heapList)
                {
                    Console.Write($"=>{item.Data}");
                }
                Console.WriteLine();
            }
            public int GetParentIndex(int index)
            {
                return (index - 1) / 2;
            }

            public int GetLeftChildIndex(int index)
            {
                return index * 2 + 1;
            }

            public int GetRightChildIndex(int index)
            {
                return index * 2 + 2;
            }

            public void Insert(T data, int count)
            {
                heapList.Add(new Node<T>(data, count));
                if (Size() > 1)
                {
                    ShiftUp(Size() - 1);
                }
            }

            public void Swap(int index1, int index2)
            {
                var temp = heapList[index1];
                heapList[index1] = heapList[index2];
                heapList[index2] = temp;
            }

            public void ShiftUp(int index)
            {
                while ((index >= 0 && index <= Size()) && (GetParentIndex(index) >= 0) && heapList[index].Count > heapList[GetParentIndex(index)].Count)
                {
                    Swap(index, GetParentIndex(index));
                    index = GetParentIndex(index);
                }
            }

            public Node<T> RemoveMin()
            {
                if (Size() == 1)
                {
                    var min = heapList[0];
                    heapList.RemoveAt(0);
                    return min;
                }
                else if (Size() > 1)
                {
                    var min = heapList[0];
                    heapList[0] = heapList[Size() - 1];
                    heapList.RemoveAt(Size() - 1);
                    ShiftDown(0);
                    return min;
                }
                else
                {
                    return null;
                }
            }

            public void ShiftDown(int index)
            {
                int maxindex = index;
                int leftChildIndex = GetLeftChildIndex(index);
                int rightChildIndex = GetRightChildIndex(index);

                if ((leftChildIndex >= 0 && leftChildIndex <= Size() - 1) && heapList[leftChildIndex].Count > heapList[maxindex].Count)
                {
                    maxindex = leftChildIndex;
                }

                if ((rightChildIndex >= 0 && rightChildIndex <= Size() - 1) &&
      heapList[rightChildIndex].Count > heapList[maxindex].Count)
                {
                    maxindex = rightChildIndex;
                }
                if (maxindex != index)
                {
                    Swap(index, maxindex);
                    ShiftDown(maxindex);
                }
            }
        }

        public class Solution
        {

            public string ReorganizeString(string s)
            {

                Dictionary<char, int> charCountDictionary = new Dictionary<char, int>();
                Queue<Node<char>> charQueue = new Queue<Node<char>>();

                StringBuilder stringBuilder = new StringBuilder();
                MinHeap<char> minHeap = new MinHeap<char>();

                foreach (var ch in s)
                {
                    if (charCountDictionary.ContainsKey(ch))
                    {
                        charCountDictionary[ch] = charCountDictionary[ch] + 1;
                    }
                    else
                    {
                        charCountDictionary.Add(ch, 1);
                    }
                }

                foreach (var ch in charCountDictionary.Keys)
                {
                    minHeap.Insert(ch, charCountDictionary[ch]);
                }

                int totalcount = s.Length;
                char lastchar = ' ';
                minHeap.Print();
                while (totalcount > 0)
                {
                    var node = minHeap.RemoveMin();
                    minHeap.Print();
                    if ((node == null && charQueue.Count > 0) || (node != null && node.Data != lastchar && charQueue.Count > 0))
                    {
                        while (charQueue.Count > 0)
                        {
                            var tempnode = charQueue.Dequeue();
                            if (tempnode.Count > 0)
                                minHeap.Insert(tempnode.Data, tempnode.Count);
                        }
                        if (node == null)
                        {
                            node = minHeap.RemoveMin();
                        }
                    }

                    if (lastchar == node.Data)
                    {
                        stringBuilder.Clear();
                        break;
                    }

                    Console.WriteLine(node.Data);

                    if (node.Count > 0)
                    {
                        node.Count = node.Count - 1;
                        charQueue.Enqueue(node);
                    }

                    stringBuilder.Append(node.Data.ToString());
                    totalcount--;
                    lastchar = node.Data;
                }

                return stringBuilder.ToString();
            }
        }


    }
}
