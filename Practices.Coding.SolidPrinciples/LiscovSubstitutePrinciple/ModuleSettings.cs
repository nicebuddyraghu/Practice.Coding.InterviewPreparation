namespace Practices.Programming.SolidPrinciples.LiscovSubstitutePrinciple
{
    public class ModuleSettings : ISettings
    {
        public Settings GetSettings()
        {
            return new Settings();
        }
    }
}
