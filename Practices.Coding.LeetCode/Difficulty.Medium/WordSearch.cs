using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /***
     * 
     * 
     * https://leetcode.com/problems/word-search/
     * 
     * 
     */
    public class WordSearch
    {
        public class WordNode
        {
            public char Letter { get; }
            public int Number { get; }
            public int IsVisited { get; set; }
            public WordNode Right { get; set; }
            public WordNode Left { get; set; }
            public WordNode Top { get; set; }
            public WordNode Down { get; set; }

            public WordNode(char letter, int number)
            {
                Letter = letter;
                IsVisited = 0;
                Number = number;
            }
        }
        public class Solution
        {
            public bool Exist(char[][] board, string word)
            {

                Dictionary<int, WordNode> wordsDictionary = new Dictionary<int, WordNode>();

                int count = 1;
                for (int rowindex = 0; rowindex < board.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < board[rowindex].Length; columnindex++)
                    {
                        bool ischarexists = false;
                        foreach (var ch in word)
                        {
                            if (ch == board[rowindex][columnindex])
                            {
                                ischarexists = true;
                                break;
                            }
                        }
                        if (ischarexists)
                        {
                            wordsDictionary.Add(count, new WordNode(board[rowindex][columnindex], count));
                        }
                        else
                        {
                            wordsDictionary.Add(count, null);
                        }
                        count++;
                    }
                }

                //Assigning Adjustcent nodes.
                count = 1;
                for (int rowindex = 0; rowindex < board.Length; rowindex++)
                {
                    for (int columnindex = 0; columnindex < board[rowindex].Length; columnindex++)
                    {
                        bool ischarexists = false;
                        foreach (var ch in word)
                        {
                            if (ch == board[rowindex][columnindex])
                            {
                                ischarexists = true;
                                break;
                            }
                        }

                        if (ischarexists)
                        {
                            if (wordsDictionary.ContainsKey(count))
                            {
                                var wordnode = wordsDictionary[count];
                                wordnode.Right = null;
                                wordnode.Left = null;
                                wordnode.Top = null;
                                wordnode.Down = null;

                                //Right Node.
                                if (columnindex + 1 <= board[rowindex].Length - 1)
                                {
                                    wordnode.Right = wordsDictionary[count + 1];
                                }
                                if (columnindex - 1 >= 0)
                                {
                                    wordnode.Left = wordsDictionary[count - 1];
                                }
                                if (rowindex - 1 >= 0)
                                {
                                    wordnode.Top = wordsDictionary[count - board[rowindex].Length];
                                }
                                if (rowindex + 1 <= board.Length - 1)
                                {
                                    wordnode.Down = wordsDictionary[count + board[rowindex].Length];
                                    // Console.WriteLine($"For wordnumber:{wordnode.Number},down is {count+board.Length+1}");
                                }
                            }
                        }
                        count++;
                    }
                }

                foreach (var wordnode in wordsDictionary)
                {
                    if (wordnode.Value != null && wordnode.Value.IsVisited == 0)
                    {
                        if (Dfs(wordnode.Value, 0, word))
                            return true;
                    }
                }

                return false;
            }

            public bool Dfs(WordNode wordnode, int index, string word)
            {
                // Console.WriteLine($"Visiting node: {wordnode.Number}");

                wordnode.IsVisited = 1;

                if (index <= word.Length - 1 && word[index] == wordnode.Letter)
                {
                    // Console.WriteLine($"{wordnode.Letter} is matching with {wordnode.Number} and index-{index}");
                    if (index == word.Length - 1)
                    {
                        return true;
                    }
                    if (index >= word.Length - 1)
                    {
                        //Console.WriteLine($"breaking at {wordnode.Number} and index-{index}");
                        return false;
                    }

                    if (wordnode.Right != null && wordnode.Right.IsVisited == 0)
                    {
                        if (Dfs(wordnode.Right, index + 1, word))
                            return true;
                    }
                    if (wordnode.Down != null && wordnode.Down.IsVisited == 0)
                    {
                        if (Dfs(wordnode.Down, index + 1, word))
                            return true;
                    }
                    if (wordnode.Left != null && wordnode.Left.IsVisited == 0)
                    {
                        if (Dfs(wordnode.Left, index + 1, word))
                            return true;
                    }
                    if (wordnode.Top != null && wordnode.Top.IsVisited == 0)
                    {
                        if (Dfs(wordnode.Top, index + 1, word))
                            return true;
                    }


                }

                wordnode.IsVisited = 0;


                return false;
            }
        }


    }
}
