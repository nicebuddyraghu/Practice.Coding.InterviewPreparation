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

/* 
 * Using the with expression to copy the record type.
 *  
 */

public record class PersonCopy(string FirstName, string LastName, string[] PhoneNumbers);

public class PersonCopyExample
{
    public void PersonCopy()
    {
        var personCopy = new PersonCopy("Raghu", "Sunkara", new string[] { "9959001485" });
        var person2 = personCopy with { FirstName = "HelloWorld"};
        var person3 = personCopy with { LastName = "helloworld" };
        //with expression uses the shallow copy, which means that for a reference property, only the reference to an instance is copied. 
        //Both the original record and the copy end up with a reference to the same instance.
    }


    //The sealed override functionaly is added in c# 10 version.
    public sealed override string ToString()
    {
        return "";
    }
}


/*
 * Inheritance is only applied to record class types.
 * A record can inherit from another record. However, a record can't inherit from a class, and a class can't inhert from a record. 
 *
 */


public record PointInherit(int X, int Y)
{
    public int Zbase { get; set; }
}

public record NamedPointInherit(string Name, int X, int Y) : PointInherit(X,Y)
{
    public int Zderived { get; set; }
}

public class PointExampleInherit
{
    public void PointExampleInheritExample()
    {
        PointInherit p1 = new NamedPointInherit("A", 1, 2) { Zbase=3, Zderived=4};
        NamedPointInherit p2 = new NamedPointInherit("A", 1, 2) { Zbase = 3, Zderived = 4 };

        var p3 = p1 with { X = 5, Y = 6, Zbase = 7 };
        var p4 = p2 with { X = 1, Y = 2, Name = "A", Zbase = 3, Zderived = 4 };

    }
}


/*
 * Destructor behaviour with derived records.
 *  
 */
public abstract record PersonDestructorExample(string FirstName, string LastName);
public record Teacher(string FirstName ,string LastName, int Grade)
            : PersonDestructorExample(FirstName,LastName);
public record Student(string FirstName, string LastName, int Grade)
            : PersonDestructorExample(FirstName,LastName);

public class DesctructorExample
{
    public void Descrutor()
    {
        var teacher = new Teacher("Nancy", "Davolio", 3);
        var (firstName, LastName) = teacher;
        var (fname, lname, grade) = (Teacher)teacher;
    }
}

