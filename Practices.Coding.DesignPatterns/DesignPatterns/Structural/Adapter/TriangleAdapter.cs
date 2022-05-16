namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Adapter
{
    internal class TriangleAdapter : IRectangle
    {
        ITriangle triangle;

        public TriangleAdapter(ITriangle triangle)
        {
            this.triangle = triangle;
        }
        public void AboutRectangle()
        {
            triangle.AboutTriangle();
        }

        public double CalculateAreaOfRectangle()
        {
            return triangle.CalculatreAreaofTriangle();
        }
    }
}
