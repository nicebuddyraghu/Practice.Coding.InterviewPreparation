using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp
{
    internal class CSharpVersion4
    {
        public void LearnDynamicType()
        {
            dynamic z = "test";
            z = z - 10;
            Console.WriteLine(z);
        }
    }
}
