namespace Practices.Coding.LeetCode.Heap
{
    //This code is incomplete. Focus more on other things.
    public enum HeapType
    {
        Min,
        Max
    }
    internal class Heap
    {
        public int[] elements { get; set; }
        public int Count;
        public int Capacity;
        public HeapType Heap_Type { get;}

        public Heap(int size, HeapType type)
        {
            elements = new int[size];
            Count = 0;
            Capacity = size;
            Heap_Type = type;
        }

        public int GetParentIndex(Heap heap,int index)
        {
            if(index<0 || index>heap.elements.Length-1)
            {
                return -1;
            }
            return (index-1) / 2;
        }

        public int GetLeftChildIndex(Heap heap, int index)
        {
            int left = (2 * index) + 1;
            if(left> heap.elements.Length-1)
            {
                return -1;
            }
            return left;
        }

        public int GetRightChildIndex(Heap heap, int index)
        {
            int right = (2 * index) + 2;
            if(right> heap.elements.Length-1)
            {
                return -1;
            }
            return right;
        }

        public int PopElement(Heap heap)
        {
            if(heap.Count==0)
            {
                return -1;
            }
            return heap.elements[0];
        }

        public void Heapify(Heap heap, int index)
        {
            int leftindex = GetLeftChildIndex(heap, index);
            int rightindex = GetRightChildIndex(heap, index);
            
            int maxindex = -1;
            if (leftindex != -1 && heap.elements[leftindex] > heap.elements[index])
            {
                maxindex = leftindex;
            }
            else
            {
                maxindex = index;
            }

            if (rightindex != -1 && heap.elements[rightindex] > heap.elements[maxindex])
            {
                maxindex = rightindex;
            }

            if (maxindex != index)
            {
                var temp = heap.elements[index];
                heap.elements[index] = heap.elements[maxindex];
                heap.elements[maxindex] = temp;
                Heapify(heap, maxindex);
            }
        }

        public void Insert(Heap heap, int keyvalue)
        {
            int index = heap.elements.Length-1;

            int parentIndex = (index-1)/2;
            while(keyvalue > heap.elements[parentIndex] && index >= 0)
            {
                heap.elements[index] = heap.elements[parentIndex];
                parentIndex = (index - 1) / 2;
                index = parentIndex;
            }
            heap.elements[index] = keyvalue;
        }

       public void BuildHeap(Heap heap, int[] elements, int capacity)
        {
            for(int i=0;i<capacity;i++)
            {
                heap.elements[i] = elements[i];
            }

            heap.Count = capacity;
            for(int i=(capacity-1)/2;i>=0;i--)
            {
                Heapify(heap, i);
            }
        }


    }
}
