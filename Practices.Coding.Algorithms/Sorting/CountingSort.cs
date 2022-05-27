namespace Practices.Coding.Algorithms.Sorting
{
    public class CountingSort
    {
        public int[] Sort(int[] nums, int range)
        {
            int[] rangenums = new int[range];
            int[] output = new int[nums.Length];

            for (int index=0;index<range;index++)
            {
                rangenums[index] = 0;
            }

            for (int index = 0; index < nums.Length; index++)
            {
                rangenums[nums[index]] = rangenums[nums[index]]+1;                   
            }

            for(int index=1;index<range;index++)
            {
                rangenums[index] = rangenums[index - 1] + rangenums[index];
            }

            for (int index = 0; index < nums.Length; index++)
            {
                int value = nums[index];
                int position = rangenums[value];
                if (position < nums.Length)
                {
                    output[position] = nums[index];
                    rangenums[value] = rangenums[value] - 1;
                }
            }

            return output;
        }
    }
}
