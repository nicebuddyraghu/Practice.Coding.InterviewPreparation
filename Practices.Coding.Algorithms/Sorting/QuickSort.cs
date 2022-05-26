using System;

namespace Practices.Coding.Algorithms.Sorting
{
    public class QuickSort
    {
        public void RandamizedQuickSort(int[] nums, int low, int high)
        {
            if(high>low)
            {
                Random randdom = new Random();
                var pivot=randdom.Next(low, high);
                var right= Partition(nums, low, high, pivot);
                Sort(nums, low, right - 1);
                Sort(nums, right + 1, high);
            }
        }

        public int Partition(int[] nums, int left, int right, int pivotindex)
        {
            int pivot = nums[pivotindex];
            while (left < right)
            {
                while (nums[left] < pivot)
                {
                    left++;
                }
                while (nums[right] > pivot)
                {
                    right--;
                }

                if (left < right)
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
