using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp.CSharpVersion8
{
    //C# 8 has recursive patterns. 
    internal class PatternMatchingVersion8
    {
        //Switch Expressions.
        public record RGBColor
        {
            public RGBColor(string color)
            {

            }
        }
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }
        public static RGBColor FindRainbow_SwitchExpressions(Rainbow colorBand) =>
            colorBand switch
            {
                Rainbow.Red => new RGBColor("Red"),
                Rainbow.Green => new RGBColor("Red"),
                Rainbow.Blue => new RGBColor("Red"),
                Rainbow.Indigo => new RGBColor("Red"),
                Rainbow.Violet => new RGBColor("Red"),
                _ => throw new ArgumentNullException("invalid enum")
            };

        //Property Expression.

        public class Address
        {
            public string State { get; set; }
        }

        public static decimal ComputerSalesTax(Address location, decimal salesPrice) =>
            location switch
            {
                { State: "WA" } => 1M,
                { State: "MN" } => 2M,
                { State: "MI" } => 3M,
                _ => 0M
            };

        public static string RockPaperScissors(string first, string second) =>
            (first, second) switch
            {
                { first: "rock", second: "test" } => "rock is rock",
                { first: "test", second: "rock" } => "test rock",
                (_,_) => ""
            };
    }
}
