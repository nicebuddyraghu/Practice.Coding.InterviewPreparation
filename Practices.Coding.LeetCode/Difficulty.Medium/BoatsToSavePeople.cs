using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class BoatsToSavePeople
    {
        public class Solution
        {
            public int NumRescueBoats(int[] people, int limit)
            {
                Array.Sort(people); //Merge sort nlogn
                int i = 0;
                int j = people.Length - 1;
                int boatsneeded = 0;
                while (i <= j)
                {
                    boatsneeded++;
                    if (people[i] + people[j] <= limit)
                        i++;
                    j--;
                }

                return boatsneeded;
            }
        }
    }
}
