using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class FlippingAnImage
    {
        /***
         * 
         * 
         * 
         * https://leetcode.com/problems/flipping-an-image/submissions/
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal int[][] FlipAndInvertImage(int[][] image)
            {

                int[][] flippedimage = new int[image.Length][];

                int flipfirstindex = 0;

                for (int index = 0; index < image.Length; index++)
                {
                    int flipsecondindex = 0;
                    flippedimage[flipfirstindex] = new int[image[index].Length];
                    for (int jindex = image[index].Length - 1; jindex >= 0; jindex--)
                    {
                        flippedimage[flipfirstindex][flipsecondindex] = image[index][jindex];
                        flipsecondindex++;
                    }
                    flipfirstindex++;
                }

                for (int index = 0; index < image.Length; index++)
                {
                    for (int jindex = image[index].Length - 1; jindex >= 0; jindex--)
                    {
                        var val = flippedimage[index][jindex];

                        flippedimage[index][jindex] = val == 1 ? 0 : 1;
                    }
                }

                return flippedimage;
            }
        }
    }
}
