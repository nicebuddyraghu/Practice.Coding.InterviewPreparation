namespace Practices.Coding.CSharp.CSharpVersion1;

//Valid
internal abstract class AbstractClassExample
{
}

//Abstract class cannot be sealed or static
//internal sealed abstract class NotaValidAbstractClass
//{
//}

//internal static abstrct class NotaValidAbstractClass
//{
//}

public class ClassA
{
    public virtual void DoWork(int i)
    {
        //Original Implemenation.
    }
}

public abstract class ClassB : ClassA
{
    public abstract override void DoWork(int i); //Can abstract the base implemenation.
} 

public class classC: ClassB
{
    public override void DoWork(int i)
    {
        //New implemenation.
    }
}
