using System.Configuration;

namespace SleepEdit
{
    public class SleepEditSettings
    {
        private readonly Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public string readSettings(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }

        public void writeSettings(string key, string value)
        {
            if (ConfigurationManager.AppSettings.Get(key) == null)
            {
                ConfigurationManager.AppSettings[key] = value;
            }
            else
            {
                ConfigurationManager.AppSettings.Set(key, value);
            }

            config.Save();
        }
    }
}