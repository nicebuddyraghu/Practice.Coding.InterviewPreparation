using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp.CSharpVersion8
{
    internal class Ranges
    {

        public void TestRanges()
        {
            var words = new string[]
                {
                                // index from start    index from end
                    "The",      // 0                   ^9
                    "quick",    // 1                   ^8
                    "brown",    // 2                   ^7
                    "fox",      // 3                   ^6
                    "jumped",   // 4                   ^5
                    "over",     // 5                   ^4
                    "the",      // 6                   ^3
                    "lazy",     // 7                   ^2
                    "dog"       // 8                   ^1
                };

            var brownfox = words[1..4];

        }
    }
}
