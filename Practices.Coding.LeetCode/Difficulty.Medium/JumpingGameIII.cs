using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class JumpingGameIII
    {
        /**
         * 
         * 
         * 
         * https://leetcode.com/problems/jump-game-iii/submissions/
         * 
         * 
         * 
         */

        public class Solution
        {


            public bool CanReach(int[] arr, int start)
            {

                var positionvisiteddic = new Dictionary<int, bool>();

                for (int index = 0; index < arr.Length; index++)
                {
                    positionvisiteddic.Add(index, false);
                }

                return CanReach(arr, start, positionvisiteddic);
            }

            public bool CanReach(int[] arr, int index, Dictionary<int, bool> dic)
            {

                if (dic[index] == true)
                    return false;

                if (arr[index] == 0)
                    return true;

                dic[index] = true;
                Console.WriteLine($"Visited Index:Node {index}:{arr[index]}");
                var jumpingindex1 = index - arr[index];
                var jumpingindex2 = index + arr[index];

                var status1 = false;
                var status2 = false;

                if (jumpingindex1 >= 0 && jumpingindex1 < arr.Length)
                    status1 = CanReach(arr, jumpingindex1, dic);

                if (jumpingindex2 >= 0 && jumpingindex2 < arr.Length)
                    status2 = CanReach(arr, jumpingindex2, dic);

                if (status1 || status2)
                    return true;
                else
                    return false;
            }
        }
    }
}
