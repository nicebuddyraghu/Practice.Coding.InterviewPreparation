using System.Collections.Generic;

namespace Practices.Coding.Algorithms.Heap
{
    public class MinHeapPq
    {
        public List<int> heaplist = new List<int>();
        public int size = -1;
        public int Count => size+1;
        public void PrintHeap()
        {
            for (int index = 0; index <=size; index++)
            {
                System.Console.Write($"=> {heaplist[index]}:");
            }
            System.Console.WriteLine();
        }
        //Basic ones
        public int GetParentIndex(int index)
        {
            if (index > size)
                return -1;
            int parentindex = (index - 1) / 2;

            if (parentindex > size)
                return -1;

            return parentindex;
        }

        public int GetLeftChildIndex(int index)
        {
            int leftindex = (index * 2) + 1;

            return leftindex;
        }

        public int GetRightChildIndex(int index)
        {
            int rightindex = (index * 2) + 2;

            return rightindex;
        }

        public void Swap(int index1, int index2)
        {
            var temp = heaplist[index1];
            heaplist[index1] = heaplist[index2];
            heaplist[index2] = temp;
        }

        public int GetMinimum()
        {
            if (heaplist.Count > 0)
              return heaplist[0];

            return -1;
        }

        public void ShiftUp(int index)
        {
            while (index > 0 && heaplist[GetParentIndex(index)] > heaplist[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        public void ShiftDown(int index)
        {
            int maxindex = index;
            int leftchildindex = GetLeftChildIndex(index);
            int rightchildindex = GetRightChildIndex(index);

            if (leftchildindex < heaplist.Count && heaplist[leftchildindex] < heaplist[index])
            {
                maxindex = leftchildindex;
            }

            if (rightchildindex < heaplist.Count && heaplist[rightchildindex] < heaplist[maxindex])
            {
                maxindex = rightchildindex;
            }

            if (maxindex != index)
            {
                Swap(maxindex, index);
                ShiftDown(maxindex);
            }
        }

        public void ChangePriority(int newvalue, int index)
        {
            var oldval = heaplist[index];
            heaplist[index] = newvalue;
            if (oldval > newvalue)
            {
                ShiftUp(index);
            }
            else
            {
                ShiftDown(index);
            }

        }
        public void Insert(int value)
        {
            size = size + 1;
            heaplist.Add(value);

            ShiftUp(size);
        }

        public int RemoveMin()
        {
            var result = heaplist[0];
            heaplist[0] = heaplist[size];
            size = size - 1;
            ShiftDown(0);
            return result;
        }

        public int Remove(int index)
        {
            var result = heaplist[index];
            heaplist[index] = heaplist[0] - 1;
            ShiftUp(index);
            RemoveMin();
            return result;
        }

        public MinHeapPq Build(int[] list)
        {
            var minHeap = new MinHeapPq();
            minHeap.size = list.Length-1;
            for (int index = 0; index < list.Length; index++)
            {
                minHeap.heaplist.Add(list[index]);
            }

            for (int index = ((list.Length) /2)-1; index >= 0; index--)
            {
                minHeap.ShiftDown(index);
                minHeap.PrintHeap();
                System.Console.WriteLine();
            }
            
            return minHeap;
        }
    }
}
