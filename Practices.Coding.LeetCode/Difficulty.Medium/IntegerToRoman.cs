using System.Collections.Generic;
using System.Text;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class IntegerToRoman
    {
        public class Solution
        {
            public string IntToRoman(int num)
            {

                Dictionary<int, string> intToRomanDictionary = new Dictionary<int, string>();

                intToRomanDictionary.Add(1000, "M");
                intToRomanDictionary.Add(500, "D");
                intToRomanDictionary.Add(100, "C");
                intToRomanDictionary.Add(50, "L");
                intToRomanDictionary.Add(10, "X");
                intToRomanDictionary.Add(5, "V");
                intToRomanDictionary.Add(1, "I");
                intToRomanDictionary.Add(900, "CM");
                intToRomanDictionary.Add(90, "XC");
                intToRomanDictionary.Add(9, "IX");
                intToRomanDictionary.Add(400, "CD");
                intToRomanDictionary.Add(40, "XL");
                intToRomanDictionary.Add(4, "IV");

                StringBuilder stringbuilder = new StringBuilder();
                int tempnumber = num;

                while (tempnumber > 0)
                {
                    int divider = GetDivider(tempnumber);
                    int dividend = tempnumber / divider;
                    int remainder = tempnumber % (dividend * divider);

                    tempnumber = remainder;
                    for (int i = 0; i < dividend; i++)
                    {
                        stringbuilder.Append(intToRomanDictionary[divider]);
                    }
                }

                return stringbuilder.ToString();
            }

            public int GetDivider(int num)
            {
                int divider = 0;
                if (num >= 1000)
                {
                    divider = 1000;
                }
                else if (num < 1000 && num >= 900)
                {
                    divider = 900;
                }
                else if (num >= 500)
                {
                    divider = 500;
                }
                else if (num < 500 && num >= 400)
                {
                    divider = 400;
                }
                else if (num >= 100)
                {
                    divider = 100;
                }
                else if (num < 100 && num >= 90)
                {
                    divider = 90;
                }
                else if (num >= 50)
                {
                    divider = 50;
                }
                else if (num < 50 && num >= 40)
                {
                    divider = 40;
                }
                else if (num >= 10)
                {
                    divider = 10;
                }
                else if (num < 10 && num >= 9)
                {
                    divider = 9;
                }
                else if (num >= 5)
                {
                    divider = 5;
                }
                else if (num < 5 && num >= 4)
                {
                    divider = 4;
                }
                else if (num >= 1)
                {
                    divider = 1;
                }

                return divider;
            }


        }
    }
}
