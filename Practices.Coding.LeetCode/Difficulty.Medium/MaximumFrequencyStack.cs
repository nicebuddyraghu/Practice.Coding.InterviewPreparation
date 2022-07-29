using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaximumFrequencyStack
    {
        public class FreqStack
        {

            Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
            Dictionary<int, Stack<int>> stackDictionary = new Dictionary<int, Stack<int>>();

            public FreqStack()
            {

            }

            int maxcount = 0;
            public void Push(int val)
            {

                if (frequencyDictionary.ContainsKey(val))
                {
                    frequencyDictionary[val] = frequencyDictionary[val] + 1;
                }
                else
                {
                    frequencyDictionary.Add(val, 1);
                }

                var count = frequencyDictionary[val];
                Console.WriteLine($"count value  {count} for value {val}");
                if (stackDictionary.ContainsKey(count))
                {
                    stackDictionary[count].Push(val);
                }
                else
                {
                    var newstack = new Stack<int>();
                    newstack.Push(val);
                    stackDictionary.Add(count, newstack);
                }

                if (count > maxcount)
                {
                    maxcount = count;
                }
                Console.WriteLine($"max count : {count}");
            }

            public int Pop()
            {

                while (maxcount > 0)
                {
                    if (stackDictionary[maxcount].Count > 0)
                    {
                        var val = stackDictionary[maxcount].Pop();
                        Console.WriteLine($"Popped value {val}");
                        frequencyDictionary[val] = frequencyDictionary[val] - 1;
                        return val;
                    }
                    else
                    {
                        maxcount = maxcount - 1;
                    }
                }

                return -1;
            }

        }

    }
}
