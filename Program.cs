using System;
using System.Configuration;
using System.Windows.Forms;

namespace ms_word_writer
{
    internal static class Program
    {
        // номер носителя
        public static string STORAGE_NUMBER;
        // место расположения носителя
        public static string STORAGE_PLACE;
        // содержание резервной копии
        public static string[] COPY_CONTENT_ARR;
        // работники
        public static string[] WORKERS_ARR;

        [STAThread]
        static void Main()
        {
            STORAGE_NUMBER = ConfigurationManager.AppSettings.Get("STORAGE_NUMBER");
            STORAGE_PLACE = ConfigurationManager.AppSettings.Get("STORAGE_PLACE");


            var appSettings = ConfigurationManager.AppSettings;
            foreach (var key in appSettings.AllKeys)
            {
                Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
