using ms_word_writer.Classes;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ms_word_writer
{
    public partial class MainForm : Form
    {
        string filename;
        string filefolder;
        int lastRecordNumber = 0;

        public MainForm()
        {
            InitializeComponent();
            // Поиск файла бэкпа в конфигурации
            if(ConfigurationManager.AppSettings["BACKUP_FILE"] != "" )
            {
                if(File.Exists(ConfigurationManager.AppSettings["BACKUP_FILE"])) {
                    filename = Path.GetFileName(ConfigurationManager.AppSettings["BACKUP_FILE"]);
                    filefolder = Path.GetDirectoryName(ConfigurationManager.AppSettings["BACKUP_FILE"]);
                    var document = DocX.Load(ConfigurationManager.AppSettings["BACKUP_FILE"]);
                    ShowBackupFile(document);
                    writeButton.Enabled = true;
                    showBackupFileButton.Enabled = true;
                } else
                {
                    Program.AddBackupFilepath("");
                }

            }
        }

        // открывает файл
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            filename = openFileDialog.SafeFileName;
            filefolder = Path.GetDirectoryName(openFileDialog.FileName);
            Program.AddBackupFilepath(openFileDialog.FileName);

            try
            {
                var document = DocX.Load(openFileDialog.FileName);
                int tableCount = document.Tables.Count;

                if (document.Tables.Count == 0)
                {
                    TableCtl.Create(this, openFileDialog.FileName);
                    tableCount++;
                }
                else
                {
                    ShowBackupFile(document);
                    writeButton.Enabled = true;
                    showBackupFileButton.Enabled = true;
                    contentField.Text = "";
                }
            }
            catch (Exception exc)
            {
                contentField.Text = exc.Message;
            }
        }

        // записывает в таблицу
        private void WriteButton_Click(object sender, EventArgs e)
        {
            // получаем значение размера бэкапа
            double backupSize;
            backupSizeField.Text = backupSizeField.Text.Replace('.', ',');
            if (backupSizeField.Text.Contains("+"))
            {
                // сумма чисел

                string[] backupSizeArr = backupSizeField.Text.Split('+');
                // убираются пробелы
                for (int i = 0; i < backupSizeArr.Length; i++)
                {
                    backupSizeArr[i] = backupSizeArr[i].Trim();
                }

                // парсинг суммы чисел
                if (double.TryParse(backupSizeArr[0], out double firstValue) && double.TryParse(backupSizeArr[1], out double secondValue))
                {
                    backupSize = firstValue + secondValue;
                }
                else
                {
                    contentField.Text += "Одно из значений суммы резервных копий не является числом. Выражение должно быть вида Число1 + Число 2\n";
                    return;
                }
            }
            else
            {
                // одно число
                if (!double.TryParse(backupSizeField.Text, out backupSize))
                {
                    contentField.Text += "Значение размера резервной копии не является числом\n";
                    return;
                }
            }

            string[] cellData = new string[8];
            cellData[0] = (++lastRecordNumber).ToString();
            cellData[1] = dateField.Value.ToString().Substring(0, 10);
            cellData[2] = backupContentField.SelectedItem.ToString();
            cellData[3] = ((int)(backupSize * 1024)).ToString();
            cellData[4] = Program.STORAGE_NUMBER;
            cellData[5] = Program.STORAGE_PLACE;
            cellData[6] = workerField.SelectedItem.ToString();
            cellData[7] = "";

            try
            {
                DocX document = TableCtl.Write(ConfigurationManager.AppSettings["BACKUP_FILE"], cellData);
                contentField.Text += $"{dateField.Text} {cellData[2]}: записано\n";
                ShowBackupFile(document);
            }
            catch (Exception exc)
            {
                contentField.Text += exc.Message;
            }
        }

        // показать файл бэкапа в проводнике
        private void showBackupFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filefolder);
        }

        // показывает путь до бэкапа
        private void ShowBackupFile(DocX document)
        {
            int tableCount = document.Tables.Count;
            Table lastTable = document.Tables[document.Tables.Count - 1];
            Row lastRow = lastTable.Rows[lastTable.Rows.Count - 1];
            int.TryParse(lastRow.Cells[0].Paragraphs[0].Text, out lastRecordNumber);
            string recordDate = lastRow.Cells[1].Paragraphs[0].Text;
            string recordContent = lastRow.Cells[2].Paragraphs[0].Text;
            backupNameField.Text = $"{filename}: таблиц = {tableCount}, последняя запись - №{lastRecordNumber}|{recordDate}|{recordContent}";
        }
    }
}
