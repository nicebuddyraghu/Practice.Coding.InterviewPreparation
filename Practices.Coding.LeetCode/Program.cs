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
            ClimbStairs.Solution climbStairs = new ClimbStairs.Solution();
            Console.WriteLine($"{climbStairs.ClimbStairs(7)}");
            Console.ReadLine();
        }
    }
}
