using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class TopKFrequencyWords
    {
        /**
         * 
         * https://leetcode.com/problems/top-k-frequent-words/
         * 
         */
        public class WordNode
        {
            public string Word { get; set; }
            public int Frequency { get; set; }

            public WordNode(string word, int frequency)
            {
                Word = word;
                Frequency = frequency;
            }
        }

        public class WordHeap
        {
            private System.Collections.Generic.List<WordNode> heapnodes = new System.Collections.Generic.List<WordNode>();
            private int size = 0;
            public int Size { get { return size; } }

            public int GetParentIndex(int index)
            {
                return (index - 1) / 2;
            }

            public int GetLeftChildIndex(int index)
            {
                return (2 * index) + 1;
            }

            public int GetRightChildIndex(int index)
            {
                return (2 * index) + 2;
            }

            public void Insert(WordNode node)
            {
                if (size == 0)
                {
                    heapnodes.Add(node);
                    size++;
                    return;
                }

                heapnodes.Add(node);
                size++;
                Shiftup(size - 1);
            }

            public void Swap(int index1, int index2)
            {
                var temp = heapnodes[index1];
                heapnodes[index1] = heapnodes[index2];
                heapnodes[index2] = temp;
            }

            public void Shiftup(int index)
            {
                while (index >= 0 && (heapnodes[GetParentIndex(index)].Frequency < heapnodes[index].Frequency || (heapnodes[GetParentIndex(index)].Frequency == heapnodes[index].Frequency && String.Compare(heapnodes[GetParentIndex(index)].Word, heapnodes[index].Word) == 1)))
                {
                    Swap(index, GetParentIndex(index));
                    index = GetParentIndex(index);
                }
            }

            public WordNode RemoveMax()
            {
                if (size >= 1)
                {
                    var maxnode = heapnodes[0];
                    heapnodes[0] = heapnodes[size - 1];
                    size--;
                    ShiftDown(0);
                    return maxnode;
                }

                return null;
            }

            public void ShiftDown(int index)
            {
                int maxindex = index;
                int leftchildindex = GetLeftChildIndex(index);
                int rightchildindex = GetRightChildIndex(index);

                if (leftchildindex < size && (heapnodes[leftchildindex].Frequency > heapnodes[index].Frequency || (
                heapnodes[leftchildindex].Frequency == heapnodes[index].Frequency && String.Compare(heapnodes[leftchildindex].Word, heapnodes[index].Word) == -1
                )))
                {
                    maxindex = leftchildindex;
                }

                if (rightchildindex < size && (heapnodes[rightchildindex].Frequency > heapnodes[maxindex].Frequency
                                           ||
                (heapnodes[rightchildindex].Frequency == heapnodes[maxindex].Frequency && String.Compare(heapnodes[rightchildindex].Word, heapnodes[maxindex].Word) == -1
                                           )))
                {
                    maxindex = rightchildindex;
                }

                if (maxindex != index)
                {
                    Swap(maxindex, index);
                    ShiftDown(maxindex);
                }
            }
        }


        public class Solution
        {
            public IList<string> TopKFrequent(string[] words, int k)
            {

                Dictionary<string, int> wordsfrequencyDictionary = new Dictionary<string, int>();

                for (int index = 0; index < words.Length; index++)
                {
                    string word = words[index];

                    if (wordsfrequencyDictionary.ContainsKey(word))
                    {
                        wordsfrequencyDictionary[word] += 1;
                    }
                    else
                    {
                        wordsfrequencyDictionary.Add(word, 1);
                    }
                }

                WordHeap heap = new WordHeap();
                foreach (var keypair in wordsfrequencyDictionary)
                {
                    heap.Insert(new WordNode(keypair.Key, keypair.Value));
                }


                List<string> kfrequencyWords = new List<string>();
                for (int index = 0; index < k; index++)
                {
                    var max = heap.RemoveMax();
                    kfrequencyWords.Add(max.Word);
                }

                return kfrequencyWords;
            }

        }
    }
}
