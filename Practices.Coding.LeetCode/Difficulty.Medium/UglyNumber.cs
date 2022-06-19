namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class UglyNumber
    {
        public class Solution
        {
            public bool IsUgly(int n)
            {

                if (n <= 0) return false;

                if (n == 1) return true;

                bool isUgly = true;
                while (n > 1)
                {
                    bool uglycheck = false;
                    if (n % 2 == 0)
                    {
                        uglycheck = true;
                        n = n / 2;
                    }
                    else if (n % 3 == 0)
                    {
                        uglycheck = true;
                        n = n / 3;
                    }
                    else if (n % 5 == 0)
                    {
                        uglycheck = true;
                        n = n / 5;
                    }

                    if (!uglycheck)
                    {
                        isUgly = false;
                        break;
                    }

                }


                return isUgly;
            }
        }
    }
}
