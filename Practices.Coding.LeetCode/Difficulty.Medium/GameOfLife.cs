namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class GameOfLife
    {
        public class Solution
        {
            public void GameOfLife(int[][] board)
            {
                for (int rowindex = 0; rowindex < board.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < board[rowindex].Length; columnindex++)
                    {
                        int totallives = 0;
                        //Right Node.
                        if (columnindex + 1 <= board[rowindex].Length - 1)
                        {
                            var lives = (board[rowindex][columnindex + 1] == 2 || board[rowindex][columnindex + 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }
                        //Left Node.
                        if (columnindex - 1 >= 0)
                        {
                            var lives = (board[rowindex][columnindex - 1] == 2 || board[rowindex][columnindex - 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }
                        //Top Node. 
                        if (rowindex - 1 >= 0)
                        {
                            var lives = (board[rowindex - 1][columnindex] == 2 || board[rowindex - 1][columnindex] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }
                        //Down Node.
                        if (rowindex + 1 <= board.Length - 1)
                        {
                            var lives = (board[rowindex + 1][columnindex] == 2 || board[rowindex + 1][columnindex] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }

                        //Top Left Node. 
                        if (rowindex - 1 >= 0 && columnindex - 1 >= 0)
                        {
                            var lives = (board[rowindex - 1][columnindex - 1] == 2 || board[rowindex - 1][columnindex - 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }

                        //Top Right Node. 
                        if (rowindex - 1 >= 0 && columnindex + 1 <= board[rowindex].Length - 1)
                        {
                            var lives = (board[rowindex - 1][columnindex + 1] == 2 || board[rowindex - 1][columnindex + 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }

                        //Down Left Node.
                        if (rowindex + 1 <= board.Length - 1 && columnindex - 1 >= 0)
                        {
                            var lives = (board[rowindex + 1][columnindex - 1] == 2 || board[rowindex + 1][columnindex - 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }

                        //Down Right Node.
                        if (rowindex + 1 <= board.Length - 1 && columnindex + 1 <= board[rowindex].Length - 1)
                        {
                            var lives = (board[rowindex + 1][columnindex + 1] == 2 || board[rowindex + 1][columnindex + 1] == 1) ? 1 : 0;
                            totallives = totallives + lives;
                        }

                        if (totallives == 3 && board[rowindex][columnindex] == 0)
                        {
                            board[rowindex][columnindex] = 3;
                        }
                        else if ((totallives == 3 || totallives == 2) && board[rowindex][columnindex] == 1)
                        {
                            board[rowindex][columnindex] = 2;
                        }

                        // Console.WriteLine($"Cell number {count} has totallives {totallives}");
                    }

                }



                for (int rowindex = 0; rowindex < board.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < board[rowindex].Length; columnindex++)
                    {
                        if (board[rowindex][columnindex] == 1)
                            board[rowindex][columnindex] = 0;
                        else if (board[rowindex][columnindex] > 1)
                            board[rowindex][columnindex] = 1;
                    }
                }
            }
        }
    }
}
