namespace Practices.Coding.CSharp.CSharpVersion9;

//Records are designed for immutable data models.
//Record class is introduced in C# 9. Record struct is introduced in C#10.
//Begingin with C# 9 record keyword to define a reference type.
internal record class RecordTypeClassExample //Reference type
{
}

internal record class RecordTypeStructExample //Struct Type.
{ 
}

//Positional parameters to declare properts of a record and to intialize the property values when you create an instance.
public record PersoneExample3 (string FirstName, string SecondName);

//record reference types
public record Person(string FirstName, string LastName);
public record PersonRecord
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;

}

//record struct types.
public readonly record struct Point(double X, double Y, double Z);

public record struct PointExample //This is introduced in C# 10.
{
    public double X { get; init; } = default!;
    public double Y { get; init; } = default!;
    public double Z { get; init; } = default!;

}

//Record with mutable fields.
public record PersonExample2
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}

public readonly record struct ReadonlyStruct1(string Arg1, string Arg2);
public record struct ReadonlyStruct2(string Arg1, string Arg2);

public class ReadonlyStructExample
{
    public void ReadonlyStructExampleFields()
    {
        _ = new ReadonlyStruct1();
        //For readonly record sturct init accessor is defined. cannot update the value after object is initalized.
        //readonlyStruct.Arg1 = "Test"; 
        //readonlyStruct.Arg2 = "Test";

        //For non readonly record struct can be assigned values.
        var readonlyStruct2 = new ReadonlyStruct2();
        readonlyStruct2.Arg1 = "test";
        readonlyStruct2.Arg2 = "test;";
    }
}
