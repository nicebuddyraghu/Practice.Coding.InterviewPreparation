using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /***
     * 
     * 
     * 
     * https://leetcode.com/problems/top-k-frequent-elements/
     * 
     */
    class TopKFrequencyElements
    {
        public class Node
        {
            public int Element { get; set; }
            public int Frequency { get; set; }
            public Node NextNode { get; set; }

            public Node(int element, int frequency)
            {
                Element = element;
                Frequency = frequency;
            }
        }


        public class MaxHeap
        {
            public List<Node> heapnodes = new List<Node>();
            public int Size = 0;

            public void Insert(Node node)
            {
                if (Size == 0)
                {
                    heapnodes.Add(node);
                    Size = Size + 1;
                    return;
                }

                heapnodes.Add(node);
                Size = heapnodes.Count;
                ShiftUp(Size - 1);
            }

            public int GetParentIndex(int index)
            {
                return (index - 1) / 2;
            }

            public int GetLeftChildIndex(int index)
            {
                return 2 * index + 1;
            }

            public int GetRightChildIndex(int index)
            {
                return 2 * index + 2;
            }

            public Node RemoveMax()
            {
                Node maxnode = heapnodes[0];
                if (Size - 1 == 0)
                {
                    heapnodes[0] = heapnodes[heapnodes.Count - 1];
                    heapnodes.RemoveAt(heapnodes.Count - 1);
                    Size = heapnodes.Count;
                    return maxnode;
                }
                else
                {
                    //Console.WriteLine($"Count-{heapnodes.Count}");
                    // foreach(var node in heapnodes)
                    // {
                    // Console.WriteLine($"{node.Element} --and {node.Frequency}");
                    // }

                    heapnodes[0] = heapnodes[heapnodes.Count - 1];
                    heapnodes.RemoveAt(heapnodes.Count - 1);

                    Size = heapnodes.Count;
                    ShiftDown(0);
                    return maxnode;
                }
            }

            public void ShiftDown(int index)
            {
                int maxindex = index;
                int leftindex = GetLeftChildIndex(index);
                int rightindex = GetRightChildIndex(index);

                //Console.WriteLine($"{leftindex}-{rightindex}-{Size}");
                if (leftindex < Size && heapnodes[GetLeftChildIndex(index)].Frequency > heapnodes[index].Frequency)
                {
                    maxindex = leftindex;
                }

                if (rightindex < Size && heapnodes[GetRightChildIndex(index)].Frequency > heapnodes[maxindex].Frequency)
                {
                    maxindex = rightindex;
                }

                // Console.WriteLine($"{leftindex}-{rightindex}-{Size}");
                if (maxindex != index)
                {
                    Swap(index, maxindex);
                    ShiftDown(maxindex);
                }
            }

            public void Swap(int index, int swapindex)
            {
                Node tempnode = heapnodes[index];
                heapnodes[index] = heapnodes[swapindex];
                heapnodes[swapindex] = tempnode;
            }

            public void ShiftUp(int index)
            {
                while (index > 0 && heapnodes[GetParentIndex(index)].Frequency < heapnodes[index].Frequency)
                {
                    Swap(GetParentIndex(index), index);
                    index = GetParentIndex(index);
                }
            }
        }

        public class Solution
        {
            public int[] TopKFrequent(int[] nums, int k)
            {

                Dictionary<int, int> countdictionary = new Dictionary<int, int>();

                for (int index = 0; index < nums.Length; index++)
                {
                    if (countdictionary.ContainsKey(nums[index]))
                    {
                        countdictionary[nums[index]] += 1;
                    }
                    else
                    {
                        countdictionary.Add(nums[index], 1);
                    }
                }

                MaxHeap heap = new MaxHeap();
                foreach (var keypair in countdictionary)
                {
                    heap.Insert(new Node(keypair.Key, keypair.Value));
                }

                List<int> kfrequencylist = new List<int>();
                for (int index = 0; index < k; index++)
                {
                    kfrequencylist.Add(heap.RemoveMax().Element);
                }

                return kfrequencylist.ToArray();
            }

        }
    }
}
