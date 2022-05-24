namespace Practices.Coding.Algorithms.Heap
{
    public class HeapSort
    {
        public void Sort(int[] unsorted)
        {
            MinHeapPq minheap = new MinHeapPq();
            minheap = minheap.Build(unsorted);

            for(int index=0;index<unsorted.Length;index++)
            {
                var min = minheap.RemoveMin();
                unsorted[index] = min;
            }

            for (int index = 0; index < unsorted.Length; index++)
            {
                System.Console.Write($"=>{unsorted[index]}");
            }
        }
    }
}


