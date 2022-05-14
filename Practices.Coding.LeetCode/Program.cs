using Practices.Coding.LeetCode.Sorting;
using System;

namespace Practices.Coding.LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Each Problem is defined in a seperate class with the Link to the leetcode.
            //Please execute or call the particular solution following the guidelines.
            //<ClassName>.<Solution>.<MethodName>

            //ClimbStairs Example
            SelectionSort sorting = new SelectionSort();
            var sortedList = sorting.Sort(new int[] {10,4,43,5,57,91,45,9,7 });
            foreach(var element in sortedList)
            {
                Console.Write($"->{element}");
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue!!");
            Console.ReadLine();
        }
    }
}
