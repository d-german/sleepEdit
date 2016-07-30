using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;



namespace SleepEdit
{
    public class SleepEditSettings
    {
        public SleepEditSettings() { }

        private Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public string readSettings(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(key);

        }

        public void writeSettings(string key, string value)
        {

            if (System.Configuration.ConfigurationManager.AppSettings.Get(key) == null)
            {
                System.Configuration.ConfigurationManager.AppSettings[key] = value;

            }
            else
            {
                System.Configuration.ConfigurationManager.AppSettings.Set(key, value);
            }

            config.Save();

        }

    }
}
