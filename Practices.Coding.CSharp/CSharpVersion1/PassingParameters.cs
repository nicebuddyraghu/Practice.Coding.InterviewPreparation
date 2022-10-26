namespace Practices.Coding.CSharp.CSharpVersion1;
internal class PassingParameters
{
    /*
     *  
     *  Parameters declared for a method without in, ref or out, are passed to the called method by value.
     *  The ref, in, and out modifiers differ in assignment rules:

        The argument for a ref parameter must be definitely assigned. The called method may reassign that parameter.
        The argument for an in parameter must be definitely assigned. The called method can't reassign that parameter.
        The argument for an out parameter needn't be definitely assigned. The called method must assign the parameter.
        This section describes the keywords you can use when declaring method parameters:

        params specifies that this parameter may take a variable number of arguments.
        in specifies that this parameter is passed by reference but is only read by the called method.
        ref specifies that this parameter is passed by reference and may be read or written by the called method.
        out specifies that this parameter is passed by reference and is written by the called method.
    *
    *
    */
}
