namespace Practices.Coding.LeetCode.Sorting
{
    internal class ShellSort
    {
        internal int[] Sort(int[] elements)
        {
            for (int gap = 4; gap > 0; gap = gap / 4)// Gap is the main thing in insertion sort gap is 1.
            {
                for (int index = gap; index < elements.Length; index++)
                {
                    var element = elements[index];
                    var insertionIndex = index;
                    while (insertionIndex >= gap && (elements[insertionIndex - gap] > element))
                    {
                        elements[insertionIndex] = elements[insertionIndex - gap];
                        insertionIndex = insertionIndex - gap;
                    }
                    elements[insertionIndex] = element;
                }
            }

            return elements;
        }
    }
}
