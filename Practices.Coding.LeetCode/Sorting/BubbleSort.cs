namespace Practices.Coding.LeetCode.Sorting
{
    internal class BubbleSort
    {
        internal int[] Sort(int[] elements)
        {
            for(int step=0;step<elements.Length;step++)
            {
                for(int index=0;index<elements.Length-step-1;index++)
                {
                    if(elements[index]>elements[index+1])
                    {
                        var temp = elements[index];
                        elements[index] = elements[index + 1];
                        elements[index + 1] = temp;
                    }
                }
            }
            return elements;
        }

        internal int[] SortImproved(int[] elements)
        {
            var isSwapped = false;
            for (int step = 0; step < elements.Length; step++)
            {
                isSwapped = false;
                for (int index = 0; index < elements.Length - step - 1; index++)
                {
                    if (elements[index] > elements[index + 1])
                    {
                        var temp = elements[index];
                        elements[index] = elements[index + 1];
                        elements[index + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;
            }
            return elements;
        }
    }
}
