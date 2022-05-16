using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Adapter
{
    class Triangle : ITriangle
    {
        private double baseLength;
        private double height;
        public Triangle(double baselength, double height)
        {
            this.baseLength = baselength;
            this.height = height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("Acutally, I am a Triangle");
        }

        public double CalculatreAreaofTriangle()
        {
            return 0.5 * baseLength * height;
        }
    }
}
