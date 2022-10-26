namespace Practices.Coding.CSharp.CSharpVersion7
{
    internal class UnderstandValueTuple
    {
        //a data structure which consists of the multiple parts”
        //The tupe feature requires the system.ValueType and related Generics in System.ValueType<T1,T2>.
        public void ValueTuple()
        {
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuble values: {t1.Item1}, {t1.Item2}");

            (double sum, int count) t2 = (4.5, 3);
            Console.WriteLine($"Tuple values: {t2.sum},{t2.count}");

            t2.GetHashCode();

            var t = (Sum: 4.5, Count: 3);
            Console.WriteLine($"{t.Sum} {t.Count}");

            var sum = 0;
            var count = 0;
            var t3 = (sum, count);
        }


        //UseCase of Tuple.
        //1. Most use case of tuple is used in method return types. This is, instead of defining out method paratmers, you can grouop method results in tuple return type.

        (int min, int max) FindMinMax()
        {
            return (int.MinValue, int.MaxValue);
        }

        public void TupleEquality()
        {
            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);  // output: False

            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
            Console.WriteLine(t1 == t2);  // output: True
            Console.WriteLine(t1 != t2);  // output: False

        }

    }
}
