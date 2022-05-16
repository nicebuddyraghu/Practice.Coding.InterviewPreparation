namespace Practices.Coding.DesignPatterns.Creational.Prototype
{
    internal interface IGuiControl
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public string Color { get; set; }

        public IGuiControl Clone();
    }
}
