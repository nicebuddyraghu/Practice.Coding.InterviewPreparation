using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp.CSharpVersion8
{
    internal class NullCoalescing
    {
        public void Test()
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();

            Console.WriteLine(string.Join("", numbers));
            Console.Write(i);
        }
    }
}
