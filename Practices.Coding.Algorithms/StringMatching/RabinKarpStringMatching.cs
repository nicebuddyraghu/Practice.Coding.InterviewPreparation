using System;

namespace Practices.Coding.Algorithms.StringMatching
{
    public class RabinKarpStringMatching
    {
        public int Match(string str, string pattern)
        {
            int patternhash = CalculateHash(pattern);
            for (int stringindex = 0; stringindex < str.Length- pattern.Length+1; stringindex++)
            {
                var strval = str.Substring(stringindex, pattern.Length);
                int stringhash = CalculateHash(strval);
                if(stringhash == patternhash)
                {
                    bool ismatched = true;
                    for (int patternindex = 0; patternindex < pattern.Length; patternindex++)
                    {
                        if(pattern[patternindex] != strval[patternindex])
                        {
                            ismatched = false;
                            break;
                        }
                    }

                    if (ismatched)
                    {
                        return stringindex;
                    }
                }
            }

            return -1;
        }

        public int CalculateHash(string pattern)
        {
            int multiply = 1;
            int sum = 0;
            for(int index= pattern.Length - 1;index>=0;index--)
            {
                var ch = pattern[index];
                int num = 26 - ch;
                num = num<0?(-1*num):num;
                sum += num * multiply;
                multiply *= 10;
            }

            int hash = 0;
            int power = 1;
            int prime = 1231;
            while (sum / 10 > 0)
            {
                int num = sum % 10;
                hash+= (int)(Math.Pow(num, power) * prime);
                sum /= 10;
            }

            return hash;
        }
    }
}

