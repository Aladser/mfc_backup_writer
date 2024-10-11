using ms_word_writer.Classes;
using System;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ms_word_writer
{
    public partial class MainForm : Form
    {
        string filename;
        string filepath;
        int lastRecordNumber = 0;
        // this.copyContentField.SelectedIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // открывает файл
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            filename = openFileDialog.SafeFileName;
            filepath = openFileDialog.FileName;

            try
            {
                var document = DocX.Load(filepath);
                int tableCount = document.Tables.Count;

                if (document.Tables.Count == 0)
                {
                    TableCtl.Create(this, filepath);
                    tableCount++;
                }
                else
                {
                    // вычисление номера последней записи
                    Table lastTable = document.Tables[document.Tables.Count - 1];
                    Row row = lastTable.Rows[lastTable.Rows.Count - 1];
                    int.TryParse(row.Cells[0].Paragraphs[0].Text, out lastRecordNumber);
                    backupNameField.Text = $"{filename}: таблиц = {tableCount}, последняя запись №{lastRecordNumber}";
                    writeButton.Enabled = true;
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
                if (!double.TryParse(backupSizeArr[0], out double firstValue) || !double.TryParse(backupSizeArr[1], out double secondValue))
                {
                    contentField.Text += "Одно из значений суммы резервных копий не является числом. Выражение должно быть вида Число1 + Число 2\n";
                    return;
                }
                else
                {
                    backupSize = firstValue + secondValue;
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
                TableCtl.Write(filepath, cellData);
                contentField.Text += $"{dateField.Text}: записано\n";
            }
            catch (Exception exc)
            {
                contentField.Text += exc.Message;
            }
        }
    }
}
