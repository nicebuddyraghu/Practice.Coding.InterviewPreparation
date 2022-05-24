using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Heap
{
    public class GraphVertex<T> 
    {
        public int Weight { get; set; }
        public T Node { get; set; }
    }
    public class MinHeapPq<T>
    {
        List<GraphVertex<T>> heaplist = new List<GraphVertex<T>>();
        int size = -1;
        public int Count => size+1;
        public void PrintHeap()
        {
            for (int index = 0; index <= size; index++)
            {
                System.Console.WriteLine($"=>Node: {heaplist[index].Node} Weight:{heaplist[index].Weight}");
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

        public GraphVertex<T> GetMinimum()
        {
            if (heaplist.Count > 0)
              return heaplist[0];

            return null;
        }

        public void ShiftUp(int index)
        {
            while (index > 0 && heaplist[GetParentIndex(index)].Weight > heaplist[index].Weight)
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

            if (heaplist[leftchildindex].Weight < heaplist[index].Weight && leftchildindex < size)
            {
                maxindex = leftchildindex;
            }

            if (maxindex == index)
            {
                if (heaplist[rightchildindex].Weight < heaplist[index].Weight && rightchildindex < size)
                {
                    maxindex = rightchildindex;
                }
            }

            if (maxindex != index)
            {
                Swap(maxindex, index);
                ShiftDown(maxindex);
            }
        }

        public void ChangePriority(int newvalue, GraphVertex<T> node)
        {
            int index = 0;
            foreach(var innode in heaplist)
            {
                if(innode.Weight ==node.Weight && innode.Node.ToString() == node.Node.ToString())
                {
                    break;
                }
                index++;
            }
            var oldval = heaplist[index].Weight;
            heaplist[index].Weight = newvalue;
            if (oldval > newvalue)
            {
                ShiftUp(index);
            }
            else
            {
                ShiftDown(index);
            }

        }
        public void Insert(int weight,T node)
        {
            size = size + 1;
            heaplist.Add(new GraphVertex<T>() { Weight=weight,Node = node});

            ShiftUp(size);
        }

        public GraphVertex<T> RemoveMin()
        {
            GraphVertex<T> result = heaplist[0];
            heaplist[0] = heaplist[size];
            size = size - 1;
            ShiftDown(0);
            return result;
        }

        public GraphVertex<T> Remove(int index)
        {
            GraphVertex<T> result = heaplist[index];
            heaplist[index].Weight = heaplist[0].Weight - 1;
            ShiftUp(index);
            RemoveMin();
            return result;
        }
    }
}
