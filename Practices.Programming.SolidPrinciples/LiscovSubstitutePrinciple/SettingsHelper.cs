using System.Collections.Generic;

namespace Practices.Programming.SolidPrinciples.LiscovSubstitutePrinciple
{
    public class SettingsHelper
    {
        List<ISettings> settings = new List<ISettings>();
        public SettingsHelper()
        {
            settings.Add(new ApplicationSettings());
            settings.Add(new ModuleSettings());
        }
        public void PrintSettings()
        {
            foreach(var setting in settings)
            {
                setting.GetSettings();
            }
        }
    }
}
