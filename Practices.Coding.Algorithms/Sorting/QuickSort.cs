using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Sorting
{
    public class QuickSort
    {
        public void Sort(int[] nums, int low, int high)
        {
            
            if(high>low)
            {
                int pivot = Partition(nums, low, high);
                Sort(nums, low, pivot - 1);
                Sort(nums, pivot + 1, high);
            }
        }

        public int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[left];
            while(left<right)
            {
                while(nums[left]<pivot)
                {
                    left++;
                }
                while(nums[right]>pivot)
                {
                    right--;
                }

                if(left<right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }

            nums[left] = nums[right];
            nums[right] = pivot;
            return right;
        }
    }
}
