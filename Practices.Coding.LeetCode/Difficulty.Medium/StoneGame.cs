using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class StoneGame
    {
        public class Solution
        {
            public bool StoneGame(int[] piles)
            {
                GetStones(piles, 0, piles.Length - 1, new List<int>(), new List<int>(), true);

                int maxalicestones = 0;
                //Console.WriteLine("Alice List");
                foreach (var pilelist in alicestonesList)
                {
                    int stonescount = 0;
                    foreach (var pile in pilelist)
                    {
                        stonescount += pile;
                        // Console.Write(pile);
                        // Console.Write(" ");
                    }
                    //Console.WriteLine();
                    if (stonescount > maxalicestones)
                    {
                        maxalicestones = stonescount;
                    }
                }


                int maxbobstones = 0;
                //Console.WriteLine("Bob List");
                foreach (var pilelist in bobstonesList)
                {
                    int stonescount = 0;
                    foreach (var pile in pilelist)
                    {
                        stonescount += pile;
                        //  Console.Write(pile);
                        // Console.Write(" ");
                    }
                    //Console.WriteLine();
                    if (stonescount > maxalicestones)
                    {
                        maxbobstones = stonescount;
                    }
                }

                if (maxalicestones > maxbobstones)
                    return true;
                else
                    return false;
            }

            List<List<int>> alicestonesList = new List<List<int>>();
            List<List<int>> bobstonesList = new List<List<int>>();
            Dictionary<string, bool> processdictionary = new Dictionary<string, bool>();

            public void GetStones(int[] piles, int left, int right, List<int> alicestones, List<int> bobstones, bool aliceturn)
            {
                if (left == right)
                {
                    if (aliceturn)
                    {
                        if ((alicestones.Count + 1) <= (piles.Length / 2))
                            alicestones.Add(piles[left]);
                    }
                    else
                    {
                        if ((bobstones.Count + 1) <= (piles.Length / 2))
                            bobstones.Add(piles[left]);
                    }

                    alicestonesList.Add(alicestones);
                    bobstonesList.Add(bobstones);
                }
                else if (left < right)
                {
                    if (aliceturn)
                    {
                        var leftstones = new List<int>();
                        leftstones.AddRange(alicestones);
                        if ((leftstones.Count + 1) <= (piles.Length / 2))
                            leftstones.Add(piles[left]);
                        var leftkey = GetKey(left + 1, right, aliceturn);
                        if (!processdictionary.ContainsKey(leftkey))
                        {
                            processdictionary.Add(leftkey, true);
                            GetStones(piles, left + 1, right, leftstones, bobstones, aliceturn == true ? false : true);
                        }

                        var rightstones = new List<int>();
                        rightstones.AddRange(bobstones);
                        if ((rightstones.Count + 1) <= (piles.Length / 2))
                            rightstones.Add(piles[right]);

                        var rightkey = GetKey(left, right - 1, aliceturn);
                        if (!processdictionary.ContainsKey(rightkey))
                        {
                            processdictionary.Add(rightkey, true);
                            GetStones(piles, left, right - 1, rightstones, bobstones, aliceturn == true ? false : true);
                        }
                    }
                    else
                    {
                        var leftstones = new List<int>();
                        leftstones.AddRange(bobstones);
                        if ((leftstones.Count + 1) <= (piles.Length / 2))
                            leftstones.Add(piles[left]);

                        var leftkey = GetKey(left + 1, right, aliceturn);
                        if (!processdictionary.ContainsKey(leftkey))
                        {
                            processdictionary.Add(leftkey, true);
                            GetStones(piles, left + 1, right, alicestones, leftstones, aliceturn == true ? false : true);
                        }
                        var rightstones = new List<int>();
                        rightstones.AddRange(bobstones);
                        if ((rightstones.Count + 1) <= (piles.Length / 2))
                            rightstones.Add(piles[right]);
                        var rightkey = GetKey(left, right - 1, aliceturn);
                        if (!processdictionary.ContainsKey(rightkey))
                        {
                            processdictionary.Add(rightkey, true);
                            GetStones(piles, left, right - 1, alicestones, rightstones, aliceturn == true ? false : true);
                        }
                    }
                }
            }

            public string GetKey(int left, int right, bool aliceturn)
            {
                if (aliceturn)
                {
                    return $"alice_{left}_{right}";
                }
                else
                {
                    return $"bob_{left}_{right}";
                }
            }

        }

    }
}
