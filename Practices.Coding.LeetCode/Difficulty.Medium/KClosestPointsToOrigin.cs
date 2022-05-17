using System;
using System.Collections.Generic;
using System.Linq;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class KClosestPointsToOrigin
    {
        public int[][] KClosest(int[][] points, int k)
        {

            Dictionary<int, double> distanceFromOriginDictionary = new Dictionary<int, double>();

            for (int index = 0; index < points.Length; index++)
            {
                int sum = 0;
                for (int colIndex = 0; colIndex < points[index].Length; colIndex++)
                {
                    int value = points[index][colIndex];

                    sum += value * value;
                }

                distanceFromOriginDictionary.Add(index, Math.Sqrt(sum));
                //Console.WriteLine($"Index={index},Distance={Math.Sqrt(sum)}");
            }

            Dictionary<int, double> list = new Dictionary<int, double>();
            var newlist = (Sort(distanceFromOriginDictionary, 0, distanceFromOriginDictionary.Count - 1));
            foreach (var item in newlist)
            {
                list.Add(item.Key, item.Value);
            }

            int[][] minPoints = new int[k][];

            for (int index = 0; index < k; index++)
            {
                int minIndex = list.FirstOrDefault().Key;
                minPoints[index] = new int[2];
                minPoints[index][0] = points[minIndex][0];
                minPoints[index][1] = points[minIndex][1];
                list.Remove(minIndex);
            }

            return minPoints;
        }

        private KeyValuePair<int, double>[] Sort(Dictionary<int, double> distanceDictionary, int start, int last)
        {
            List<KeyValuePair<int, double>> keylist = new List<KeyValuePair<int, double>>();

            if (start == last)
            {
                keylist.Add(new KeyValuePair<int, double>(last, distanceDictionary[last]));
                return keylist.ToArray();
            }
            else if (start + 1 == last)
            {
                if (distanceDictionary[start] > distanceDictionary[last])
                {
                    keylist.Add(new KeyValuePair<int, double>(last, distanceDictionary[last]));
                    keylist.Add(new KeyValuePair<int, double>(start, distanceDictionary[start]));
                }
                else
                {
                    keylist.Add(new KeyValuePair<int, double>(start, distanceDictionary[start]));
                    keylist.Add(new KeyValuePair<int, double>(last, distanceDictionary[last]));
                }
                return keylist.ToArray();
            }
            else
            {
                int mid = (start + last) / 2;
                var left = Sort(distanceDictionary, start, mid);
                var right = Sort(distanceDictionary, mid + 1, last);
                return Merge(left, right);
            }
        }
        private KeyValuePair<int, double>[] Merge(KeyValuePair<int, double>[] left, KeyValuePair<int, double>[] right)
        {
            List<KeyValuePair<int, double>> newList = new List<KeyValuePair<int, double>>();
            int leftindex = 0;
            int rightindex = 0;
            while (leftindex < left.Length && rightindex < right.Length)
            {
                if (left[leftindex].Value > right[rightindex].Value)
                {
                    newList.Add(right[rightindex]);
                    rightindex++;
                }
                else
                {
                    newList.Add(left[leftindex]);
                    leftindex++;
                }
            }

            while (leftindex < left.Length)
            {
                newList.Add(left[leftindex]);
                leftindex++;
            }

            while (rightindex < right.Length)
            {
                newList.Add(right[rightindex]);
                rightindex++;
            }

            return newList.ToArray();
        }
    }
}

