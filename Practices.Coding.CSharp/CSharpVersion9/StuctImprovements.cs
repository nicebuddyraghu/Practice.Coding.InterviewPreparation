namespace Practices.Coding.CSharp.CSharpVersion9;
internal struct StructA
{
    public StructA()
    {
    }
}

internal class ClassA
{
}

internal interface IClassA
{
}

//Compiler Error. Cannot inherit from another struct.
//internal struct StructB : StructA
//{
//}

//Compiler Error. Cannot inherit from another struct.
//internal struct StrutA: ClassA
//{

//}

//Compiler Error. Cannot inherit from an Interface.
//internal struct StrutA: ClassA
//{

//}

internal struct StructB: IClassA
{
    
}