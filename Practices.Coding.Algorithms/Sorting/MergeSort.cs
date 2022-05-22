namespace Practices.Coding.Algorithms.Sorting
{
    internal class MergeSort
    {
        internal int[] Sort(int[] elements, int[] temp, int left, int right)
        {
            if(right>left)
            {
                int mid = (left + right) / 2;
                Sort(elements, temp, left, mid);
                Sort(elements, temp, mid + 1, right);
                elements=Merge(elements, temp, left, mid + 1, right);
            }

            return elements;
        }

        internal int[] Merge(int[] elements, int[] temp, int left, int mid, int right)
        {
            int leftend = mid - 1;
            int tempIndex = left;
            while((left<=leftend) && (mid<=right))
            {
                if(elements[left]<=elements[mid])
                {
                    temp[tempIndex] = elements[left];
                    left++;
                }
                else
                {
                    temp[tempIndex] = elements[mid];
                    mid++;
                }
                tempIndex++;
            }

            while(left<=leftend)
            {
                temp[tempIndex] = elements[left];
                tempIndex++;
                left++;
            }

            while (mid <= right)
            {
                temp[tempIndex] = elements[mid];
                tempIndex++;
                mid++;
            }

            for(;right>=0; right--)
            {
                elements[right] = temp[right];
            }

            return elements;
        }
    }
}
