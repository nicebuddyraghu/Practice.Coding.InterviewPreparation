namespace Practices.Coding.Algorithms.StringMatching
{
    public class StringMatchingBruteForceMethod
    {
        public int Match(string str, string pattern)
        {
            for (int stringindex = 0; stringindex < str.Length; stringindex++)
            {
                bool patternmatched = true;
                for (int patternindex = 0; patternindex < pattern.Length; patternindex++)
              {
                    if (pattern[patternindex] != str[stringindex + patternindex])
                    {
                        patternmatched = false;
                        break;
                    }
                }
                if (patternmatched)
                    return stringindex;
            }

            return -1;
        }
    }

}
