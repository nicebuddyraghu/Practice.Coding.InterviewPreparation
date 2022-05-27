using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.StringMatching
{
    public class KMPAlgorithm
    {
        public int[] PrefixTable(string pattern)
        {
            int index = 0;
            int increment = 1;
            var prefixtable = new int[pattern.Length];
            while(increment<pattern.Length)
            {
                if(pattern[increment]!=pattern[index])
                {
                    prefixtable[increment] = index + 1;
                    increment++;
                    index++;
                }
                else if(index>0)
                {
                    index = prefixtable[index - 1];
                }
                else
                {
                    increment++;
                }
            }

            return prefixtable;
        }

        public int Match(string str, string pattern)
        {
            var prefixtable = PrefixTable(pattern);

            int increment = 0;
            int index = 0;
            while(increment<str.Length)
            {
                if(pattern[index] == str[increment])
                {
                    if(index==pattern.Length-1)
                    {
                        return increment-index;
                    }
                    index++;
                    increment++;
                }
                else if(index>0)
                {
                    index = prefixtable[index - 1];
                }
                else
                {
                    increment++;
                }
            }
            return -1;
        }
    }
}
