namespace Practices.Coding.CSharp.CSharpVersion9;
internal readonly struct Coordinates
{
    public Coordinates(double x, double y)
    {
        X = x;
        Y = y;
    }

    public readonly double X { get; init; }
    public readonly double Y { get; init; }

    public override string ToString() => $"{X} {Y}";
}

internal class WithExpressionExample
{
    public void WithExpression()
    {
        var p1 = new Coordinates(0, 0);
        var p2 = p1 with {X = 3};
        var p3 = p1 with { X = 1, Y = 4 };
    }
}