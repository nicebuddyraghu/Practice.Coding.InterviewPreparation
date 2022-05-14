namespace Practices.Coding.LeetCode.Sorting
{
    internal class SelectionSort
    {
        internal int[] Sort(int[] elements)
        {
            for(int index=0; index<elements.Length;index++)
            {
                int min = int.MaxValue;
                int minSelectionIndex = -1;
                for(int minIndex = index;minIndex<elements.Length;minIndex++)
                {
                    if (elements[minIndex] < min)
                    {
                        min = elements[minIndex];
                        minSelectionIndex = minIndex;
                    }
                }

                //Swapping.
                var temp = elements[index];
                elements[index] = elements[minSelectionIndex];
                elements[minSelectionIndex] = temp;
            }

            return elements;
        }
    }
}
