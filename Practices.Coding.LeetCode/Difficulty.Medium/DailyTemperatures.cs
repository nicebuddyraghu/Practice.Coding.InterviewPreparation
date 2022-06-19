using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class DailyTemperatures
    {
        public class Temperature
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }

        public class Solution
        {

            public int[] DailyTemperatures(int[] temperatures)
            {
                int[] daystogetwarmertemperatures = new int[temperatures.Length];
                Stack<Temperature> temperatureStack = new Stack<Temperature>();

                for (int temperatureindex = 0; temperatureindex < temperatures.Length; temperatureindex++)
                {
                    var presenttemperature = temperatures[temperatureindex];
                    if (temperatureStack.Count == 0)
                    {
                        temperatureStack.Push(new Temperature() { Index = temperatureindex, Value = presenttemperature });
                    }
                    else
                    {
                        while (temperatureStack.Count > 0 && (temperatureStack.Peek().Value < temperatures[temperatureindex]))
                        {
                            daystogetwarmertemperatures[temperatureStack.Peek().Index] = temperatureindex - temperatureStack.Peek().Index;
                            temperatureStack.Pop();
                        }

                        temperatureStack.Push(new Temperature() { Index = temperatureindex, Value = presenttemperature });
                    }
                }

                return daystogetwarmertemperatures;
            }
        }

    }
}
