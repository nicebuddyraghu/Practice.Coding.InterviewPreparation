namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Adapter
{
    internal class Rectangle : IRectangle
    {
        private double length;
        private double width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public void AboutRectangle()
        {
            System.Console.WriteLine("Actually, I am a Rectangle");
        }

        public double CalculateAreaOfRectangle()
        {
            return length * width;
        }
    }
}
