using ms_word_writer.Classes;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
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
            if (ConfigurationManager.AppSettings["BACKUP_FILE"] != "")
            {
                if (File.Exists(ConfigurationManager.AppSettings["BACKUP_FILE"]))
                {
                    filename = Path.GetFileName(ConfigurationManager.AppSettings["BACKUP_FILE"]);
                    filefolder = Path.GetDirectoryName(ConfigurationManager.AppSettings["BACKUP_FILE"]);
                    var document = DocX.Load(ConfigurationManager.AppSettings["BACKUP_FILE"]);

                    int totalRowCount = 0;
                    foreach(var table in document.Tables)
                    {
                        totalRowCount += table.RowCount;
                    }
                    totalRowCount -= document.Tables.Count * 2;
                    backupNameField.Text = $"{filename}. Таблиц = {document.Tables.Count}. Записей - {totalRowCount}";
                    ShowTableLastRows(document, true);

                    writeButton.Enabled = true;
                    showBackupFileButton.Enabled = true;
                }
                else
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
                    contentField.Text = "";
                    ShowTableLastRows(document, true);
                    writeButton.Enabled = true;
                    showBackupFileButton.Enabled = true;
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
                ShowTableLastRows(document);
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
        private void ShowTableLastRows(DocX document, bool isFileOpening = false)
        {
            Table lastTable;
            // Проверка на пустоту файла
            if (document.Tables.Count == 0)
            {
                contentField.Text += "Нет записей в файле";
                return;
            }
            else
            {
                lastTable = document.Tables[document.Tables.Count - 1];
                if(lastTable.RowCount < 3)
                {
                    contentField.Text += "Нет записей в файле\n";
                    return;
                }
            }

            if(!isFileOpening)
            {
                contentField.Text += "-----------------------\n";
            }

            // есть минимум две записи
            if(lastTable.RowCount > 3)
            {
                Row peltRow = lastTable.Rows[lastTable.Rows.Count - 2];
                double.TryParse(peltRow.Cells[3].Paragraphs[0].Text, out double peltBackupSize);
                peltBackupSize = Math.Round(peltBackupSize / 1024, 2);
                contentField.Text += $"Предпоследняя запись №{peltRow.Cells[0].Paragraphs[0].Text}  /  {peltRow.Cells[1].Paragraphs[0].Text}  /  {peltRow.Cells[2].Paragraphs[0].Text} / {peltBackupSize}Гб\n";
            }
            // есть минимум одна запись
            if (lastTable.RowCount > 2)
            {
                Row lastRow = lastTable.Rows[lastTable.Rows.Count - 1];
                double.TryParse(lastRow.Cells[3].Paragraphs[0].Text, out double lastBackupSize);
                lastBackupSize = Math.Round(lastBackupSize / 1024, 2);
                contentField.Text += $"Последняя запись         №{lastRow.Cells[0].Paragraphs[0].Text}  /  {lastRow.Cells[1].Paragraphs[0].Text}  /  {lastRow.Cells[2].Paragraphs[0].Text} / {lastBackupSize}Гб\n";

                int.TryParse(lastRow.Cells[0].Paragraphs[0].Text, out lastRecordNumber);
            }
        }
    }
}
