using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    class CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {

            System.Collections.Generic.Queue<string> version1Stack = new System.Collections.Generic.Queue<string>();
            System.Collections.Generic.Queue<string> version2Stack = new System.Collections.Generic.Queue<string>();

            var version1List = version1.Split('.');
            var version2List = version2.Split('.');

            foreach (string version in version1List)
            {
                version1Stack.Enqueue(version);
            }
            foreach (string version in version2List)
            {
                version2Stack.Enqueue(version);
            }

            int compareValue = 0;
            while (version1Stack.Count > 0 && version2Stack.Count > 0)
            {
                var version01 = Convert.ToInt32(version1Stack.Dequeue());
                var version02 = Convert.ToInt32(version2Stack.Dequeue());

                Console.WriteLine($"Version1: {version01}, Version2: {version02}");
                if (version01 < version02)
                {
                    compareValue = -1;
                    break;
                }
                else if (version01 > version02)
                {
                    compareValue = 1;
                    break;
                }
            }

            Console.WriteLine(compareValue);
            if (compareValue != 0)
                return compareValue;

            while (version1Stack.Count > 0)
            {
                var version01 = Convert.ToInt32(version1Stack.Dequeue());
                if (version01 > 0)
                    compareValue = 1;
            }

            while (version2Stack.Count > 0)
            {
                var version02 = Convert.ToInt32(version2Stack.Dequeue());
                if (version02 > 0)
                    compareValue = -1;
            }


            return compareValue;
        }
    }
}
