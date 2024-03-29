﻿using System.Collections.Generic;
using System;

namespace Practices.Coding.Algorithms.Heap
{
    public class MaxHeap
    {
        public List<int> heaplist = new List<int>();
        public int size = -1;

        public void PrintHeap()
        {
            for(int index=0;index<heaplist.Count;index++)
            {
                System.Console.Write($"=>{heaplist[index]}");
            }
            System.Console.WriteLine();
        }
     
        //Basic ones
        public int GetParentIndex(int index)
        {
            if (index > size)
                return -1;

            return (index - 1) / 2;
        }

        public int GetLeftChildIndex(int index)
        {
            if (index < 0 || index > size)
                return -1;

            return (index * 2) + 1;
        }

        public int GetRightChildIndex(int index)
        {
            if (index < 0 || index > size)
                return -1;

            return (index * 2) + 2;
        }
        
        public void Swap(int index1, int index2)
        {
            var temp = heaplist[index1];
            heaplist[index1] = heaplist[index2];
            heaplist[index2] = temp;
        }

        public int GetMaximum()
        {
            if (heaplist.Count > 0)
                return heaplist[0];
            else
                return -1;
        }

        public void ShiftUp(int index)
        {
            while(index>0 && heaplist[GetParentIndex(index)]<heaplist[index])
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
            
            if( leftchildindex<=size && leftchildindex>=0 && heaplist[leftchildindex]>heaplist[index])
            {
                maxindex = leftchildindex;
            }

            if (rightchildindex <= size && rightchildindex>=0 && heaplist[rightchildindex] > heaplist[maxindex] )
            {
                maxindex = rightchildindex;
            }

            if(maxindex!=index)
            {
                Swap(maxindex, index);
                ShiftDown(maxindex);
            }
        }

        public void ChangePriority(int newvalue,int index)
        {
            var oldval = heaplist[index];
            heaplist[index] = newvalue;
            if (oldval < newvalue)
            {
                ShiftUp(index);
            }
            else
            {
                ShiftDown(index);
            }

        }
     
        public void Insert(int val)
        {
            size=size + 1;
            heaplist.Add(val);
            Console.WriteLine($"Size: {size}");
            ShiftUp(size);
        }

        public int RemoveMax()
        {
            if(size == 0)
            {
              var item= heaplist[0];
              heaplist.RemoveAt(0);
              return item;
            }
            
            int result = heaplist[0];
            heaplist[0] = heaplist[size];
            heaplist.RemoveAt(size);
            size = size - 1;
            ShiftDown(0);
            
            return result;
        }

        public int Remove(int index)
        {
            int result = heaplist[index];
            heaplist[index] = heaplist[0] + 1;
            ShiftUp(index);
            RemoveMax();
            return result;
        }
    }
}
