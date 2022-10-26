using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp
{
    internal class ParallelProgramming
    {
        public void UseParallel()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });

            //To Cancel th loop.

            ParallelLoopResult result = Parallel.For(0,1000,(int i, ParallelLoopState loopState) =>
            {

            }) ;


            //plinq.

            var numbers1 = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
            }
            catch(AggregateException e)
            {

            }
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException("i");
            return i % 2 == 0;
        }
    }
}
