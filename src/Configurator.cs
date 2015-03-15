using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;

namespace Guitar
{
    class Configurator
    {
        private Configuration config;
        private AppSettingsSection programSettings;
        Dictionary<string, ComboBox> comboboxMap;
        public Configurator(Dictionary<string, ComboBox> controls)
        {
            comboboxMap = controls;
            setConfigurationFile();
        }
        private void setConfigurationFile()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            programSettings = config.AppSettings;
        }
        public void autoloadFromValues()
        {
            Dictionary<string, ComboBox>.Enumerator en = comboboxMap.GetEnumerator();
            while (en.MoveNext())
            {
                loadComboboxValues(en.Current.Value, getConfigValue(en.Current.Key, ""));
            }
        }

        private void loadComboboxValues(ComboBox cb, string vals)
        {
            if (vals != null && vals.Trim().Length > 0)
            {
                string[] arr = vals.Split('|');
                foreach (string s in arr)
                {
                    cb.Items.Add(s);
                }
                cb.SelectedIndex = 0;
            }
        }
        private string getConfigValue(string key, string defaultVal)
        {
            KeyValueConfigurationElement setting = programSettings.Settings[key];
            if (setting == null) return defaultVal;
            return setting.Value;
        }

        public void saveSettings()
        {

            autosaveConfiguration();
            config.Save(ConfigurationSaveMode.Modified);

        }
        private void autosaveConfiguration()
        {
            Dictionary<string, ComboBox>.Enumerator en = comboboxMap.GetEnumerator();
            while (en.MoveNext())
            {
                setConfigurationSetting(en.Current.Key, toPipedString(en.Current.Value));
            }
        }
        private void setConfigurationSetting(string key, string val)
        {
            if (programSettings.Settings[key] == null)
            {
                programSettings.Settings.Add(key, val);
            }
            else
            {
                programSettings.Settings[key].Value = val;
            }
        }
        private String toPipedString(ComboBox cb)
        {
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (Object o in cb.Items)
            {
                string t = ((string)o).Trim();
                if (t.Length > 0)
                {
                    if (i > 0) builder.Append("|");
                    builder.Append(t);
                    i++;
                }
            }

            return builder.ToString();
        }
        public string getFilePath()
        {
            return config.FilePath;
        }
    }
}
