namespace Practices.Coding.CSharp.CSharpVersion9;
internal class PropertiesImprovements
{
    public PropertiesImprovements()
    {
        FirstName = "Raghu";
    }

    //The init is added in C#9 sothat it will be initialized in the constructor or using object initializer.
    //This makes the property readonly.
    public string FirstName { get; init; }
}
