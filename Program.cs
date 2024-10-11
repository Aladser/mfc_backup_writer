using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;

namespace ms_word_writer
{
    internal static class Program
    {
        // номер носителя
        public static string STORAGE_NUMBER = ConfigurationManager.AppSettings.Get("STORAGE_NUMBER");
        // место расположения носителя
        public static string STORAGE_PLACE = ConfigurationManager.AppSettings.Get("STORAGE_PLACE");
        // содержание резервной копии
        public static List<string> BACKUP_CONTENT_ARR = new List<string>();
        // работники
        public static List<string> WORKERS_ARR = new List<string>();

        [STAThread]
        static void Main()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            foreach (var key in appSettings.AllKeys)
            {
                if (key.Contains("COPY_CONTENT"))
                {
                    BACKUP_CONTENT_ARR.Add(appSettings[key]);
                }
                else if (key.Contains("WORKER"))
                {
                    WORKERS_ARR.Add(appSettings[key]);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        // записывает в конфигурацию путь до файла бэкапа
        public static void AddBackupFilepath(string filepath)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["BACKUP_FILE"].Value = filepath;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
