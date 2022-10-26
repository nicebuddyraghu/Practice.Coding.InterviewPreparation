namespace Practices.Coding.CSharp.CSharpVersion1;

internal class SealedClassesExample
{

    public class Example1
    {
        protected virtual int Function1() => 0;
        protected virtual int Function2() => 1;
    }

    public class Example2 : Example1
    {
        protected sealed override int Function1() => 1;
        protected override int Function2() => 2;
    }

    public class Example3: Example2
    {
        // Attempting to override F causes compiler error CS0239.
       // protected sealed override int Function1() => 3;
        protected sealed override int Function2() => 4;
    }
}


