namespace Practices.Coding.DesignPatterns.Creational.Prototype
{
    internal class ButtonControl : IGuiControl
    {
        public ButtonControl()
        {
            Width = 100;
            Height = 300;
            Color = "Default";
        }

        /// <summary>
        /// Copy Constructor.
        /// </summary>
        /// <param name="buttonControl"></param>
        public ButtonControl(ButtonControl buttonControl)
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
            return new ButtonControl(this);//Using Copy Constructor. This looks a deep copy. You may use ShallowCopy with MemberwiseClone();
        }
    }
}
