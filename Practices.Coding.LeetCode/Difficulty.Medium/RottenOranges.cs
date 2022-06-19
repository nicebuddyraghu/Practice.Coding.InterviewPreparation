using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class RottenOranges
    {
        public class Orange
        {
            public int State { get; set; }
            public int Number { get; set; }
            public List<Orange> AdjacentOranges { get; set; }
            public Orange(int state, int number)
            {
                AdjacentOranges = new List<Orange>();
                State = state;
                Number = number;
            }
        }
        public class Solution
        {
            public int OrangesRotting(int[][] grid)
            {

                Dictionary<int, Orange> oranges = new Dictionary<int, Orange>();
                int count = 1;
                for (int row = 0; row < grid.Length; row++)
                {
                    for (int column = 0; column < grid[row].Length; column++)
                    {
                        if (grid[row][column] == 2 || grid[row][column] == 1)
                        {
                            var orange = new Orange(grid[row][column], count);
                            oranges.Add(count, orange);
                        }
                        else
                        {
                            oranges.Add(count, null);
                        }
                        count++;
                    }
                }

                count = 1;
                for (int row = 0; row < grid.Length; row++)
                {
                    for (int column = 0; column < grid[row].Length; column++)
                    {
                        if (oranges[count] != null)
                        {
                            //Left orange
                            if (column - 1 >= 0)
                            {
                                oranges[count].AdjacentOranges.Add(oranges[count - 1]);
                            }
                            //Right Orange.
                            if (column + 1 < grid[row].Length)
                            {
                                oranges[count].AdjacentOranges.Add(oranges[count + 1]);
                            }
                            //Up Orange.
                            if (row - 1 >= 0)
                            {
                                oranges[count].AdjacentOranges.Add(oranges[count - grid[row].Length]);
                            }
                            //Down Orange.
                            if (row + 1 < grid.Length)
                            {
                                oranges[count].AdjacentOranges.Add(oranges[count + grid[row].Length]);
                            }
                        }
                        count++;
                    }
                }


                Queue<Orange> orangeQueue = new Queue<Orange>();

                int totalrottenorangescount = 0;
                int timelapse = -1;
                int orangescount = 0;
                foreach (var orange in oranges.Values)
                {
                    if (orange != null)
                    {
                        orangescount++;
                    }
                    if (orange != null && orange.State == 2)
                    {
                        orangeQueue.Enqueue(orange);
                        totalrottenorangescount++;
                    }
                }

                if (orangescount == 0)
                {
                    return ++timelapse;
                }
                else if (totalrottenorangescount == 0)
                {
                    return timelapse;
                }
                else if (totalrottenorangescount == orangescount)
                {
                    return ++timelapse;
                }

                ++timelapse;
                int timelapsedecrement = totalrottenorangescount;
                while (orangeQueue.Count > 0)
                {
                    var rottenOrange = orangeQueue.Dequeue();

                    foreach (var adjorange in rottenOrange.AdjacentOranges)
                    {
                        if (adjorange != null && adjorange.State != 2)
                        {
                            adjorange.State = 2;
                            orangeQueue.Enqueue(adjorange);
                            totalrottenorangescount++;
                        }
                    }

                    timelapsedecrement--;
                    if (timelapsedecrement == 0)
                    {
                        timelapse++;
                        timelapsedecrement = orangeQueue.Count;
                    }

                }

                Console.WriteLine($"total oranges : {orangescount} and rotten oranges: {totalrottenorangescount} and timelapse: {timelapse}");

                return (totalrottenorangescount == orangescount) ? timelapse - 1 : -1;
            }
        }
    }
}
