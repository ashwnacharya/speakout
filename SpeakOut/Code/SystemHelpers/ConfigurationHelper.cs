using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using SpeakYourMind.SystemHelpers;

namespace SpeakYourMind.SystemHelpers
{
    /// <summary>
    /// Helper class exposed out as Singleton
    /// </summary>
    public class ConfigurationHelper
    {
        #region ctor

        private ConfigurationHelper()
        {

        }
        #endregion

        #region Singleton
        private static ConfigurationHelper _instance = null;
        private static object lockObj = new object();
        public static ConfigurationHelper Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationHelper();
                    }
                }
                return _instance;
            }
        }

        #endregion

        public string DBConnectionString
        {
            get
            {
                return EncryptionHelper.Decrypt(ConfigurationManager.AppSettings.Get("DBConnectionString"));
            }
            set
            {
                SaveConfiguration("DBConnectionString", EncryptionHelper.Encrypt(value));

            }
        }

     

        public void SaveConfiguration(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
