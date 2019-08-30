using System.Configuration;

namespace TT.Utils.ConfigManager
{
    public class SettingManager
    {
        /// <summary>
        /// Ejemplo de implementacion
        /// </summary>
        public static string WebPagesVersion
        {
            get { return GetSettings("webpages:Version"); }
        }

        private static string GetSettings(string key)
        {
            return string.IsNullOrEmpty(ConfigurationManager.AppSettings[key]) ? "" : ConfigurationManager.AppSettings[key].ToString();
        }

    }
}
