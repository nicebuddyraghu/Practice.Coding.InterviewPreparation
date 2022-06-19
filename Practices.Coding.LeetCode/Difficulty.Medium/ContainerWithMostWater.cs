namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class ContainerWithMostWater
    {
        public class Solution
        {

            public int MaxArea(int[] height)
            {

                int maxArea = 0;
                for (int i = 0, j = height.Length - 1; i <= height.Length - 1 && j >= 0;)
                {
                    int width = (j - i);

                    int leftheight = height[i];
                    int rightheight = height[j];
                    if (leftheight < rightheight)
                    {
                        maxArea = leftheight * width > maxArea ? (leftheight * width) : maxArea;
                        i++;
                    }
                    else
                    {
                        maxArea = rightheight * width > maxArea ? (rightheight * width) : maxArea;
                        j--;
                    }
                }

                return maxArea;
            }



        }
    }
}
