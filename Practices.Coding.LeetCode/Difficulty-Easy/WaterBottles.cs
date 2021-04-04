using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class WaterBottles
    {
        /**
         * 
         * https://leetcode.com/problems/water-bottles/submissions/
         * 
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal int NumWaterBottles(int numBottles, int numExchange)
            {

                int totalbottlescandrink = 0;

                //Console.WriteLine(15%4);

                int fullbottlesfromdrinkable = 0;

                int tempBottles = numBottles;
                while (tempBottles > 0 && tempBottles >= numExchange)
                {
                    fullbottlesfromdrinkable += tempBottles / numExchange;

                    Console.WriteLine($"Drinkable bottles: {fullbottlesfromdrinkable}");
                    tempBottles = (tempBottles / numExchange) + (tempBottles % numExchange);
                    Console.WriteLine(tempBottles);
                }

                totalbottlescandrink = numBottles + fullbottlesfromdrinkable;

                return totalbottlescandrink;
            }
        }
    }
}
