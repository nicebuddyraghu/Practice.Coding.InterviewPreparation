namespace Practices.Coding.LeetCode.DesignPatterns.Creational.Prototype
{
    internal class LabelControl : IGuiControl
    {
        public LabelControl()
        {
            Width = 100;
            Height = 100;
            Color = "Default";
        }

        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="buttonControl"></param>
        public LabelControl(LabelControl buttonControl)
        {
            Width = buttonControl.Width;
            Height = buttonControl.Height;
            Color = buttonControl.Color;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }

        public IGuiControl Clone()
        {
            return new LabelControl(this);  //Using Copy Constructor. This looks a deep copy. You may use ShallowCopy with MemberwiseClone();
        }
    }
}
