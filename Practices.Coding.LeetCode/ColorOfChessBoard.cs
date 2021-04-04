using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ColorOfChessBoard
    {
        /**
         * 
         * https://leetcode.com/problems/determine-color-of-a-chessboard-square/submissions/
         * 
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal bool SquareIsWhite(string coordinates)
            {

                var chessboard = new int[8][];



                int iswhite = 0;
                for (int index = 0; index < chessboard.Length; index++)
                {
                    chessboard[index] = new int[8];
                    if (index == 0)
                        iswhite = 0;
                    else if (index == 1)
                        iswhite = 1;
                    else if (index % 2 == 0)
                        iswhite = 0;
                    else
                        iswhite = 1;

                    for (int jindex = 0; jindex < chessboard[index].Length; jindex++)
                    {
                        chessboard[index][jindex] = iswhite;
                        iswhite = iswhite == 1 ? 0 : 1;
                    }
                }

                int firstindex = 0;
                int secondindex = 0;
                foreach (var ch in coordinates)
                {
                    if (ch == 'a')
                        firstindex = 0;
                    else if (ch == 'b')
                        firstindex = 1;
                    else if (ch == 'c')
                        firstindex = 2;
                    else if (ch == 'd')
                        firstindex = 3;
                    else if (ch == 'e')
                        firstindex = 4;
                    else if (ch == 'f')
                        firstindex = 5;
                    else if (ch == 'g')
                        firstindex = 6;
                    else if (ch == 'h')
                        firstindex = 7;
                    else
                        secondindex = Int32.Parse(ch.ToString());
                }

                return chessboard[firstindex][secondindex - 1] == 0 ? false : true;
            }
        }
    }
}
