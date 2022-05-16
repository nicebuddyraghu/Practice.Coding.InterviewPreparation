namespace Practices.Programming.SolidPrinciples.LiscovSubstitutePrinciple
{
    public class ApplicationSettings : ISettings
    {
        public Settings GetSettings()
        {
            return new Settings();
        }
    }
}
