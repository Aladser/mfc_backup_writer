using Aspose.Words;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ms_word_writer
{
    public partial class MainForm : Form
    {
        string filename;
        string filepath;
        int rowCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // открывает файл
        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            filename = openFileDialog.SafeFileName;

            filepath = openFileDialog.FileName;
            contentTextBox.Text = $"Файл бэкапов {filename}\n";

            try
            {
                var document = DocX.Load(filepath);
                foreach(var table in document.Tables)
                {
                    rowCount += table.RowCount;
                }
                contentTextBox.Text += $"Число таблиц = {document.Tables.Count}\n";
                contentTextBox.Text += $"Число записей = {rowCount} \n";
            } catch (System.IO.IOException exc)
            {
                // файл открыт в другой программе
                contentTextBox.Text = exc.Message;
            }
        }

        // записывает в таблицу
        private void writeButton_Click(object sender, EventArgs e)
        {

            if (filename == null || filename == null || filename == "" || filename == "")
            {
                return;
            }

            // запись в таблицу
            using (var document = DocX.Load(filepath))
            {
                try
                {
                    var table = document.Tables[0];

                    // вставка пустой строки
                    var row = table.InsertRow();
                    row.Cells[0].Paragraphs[0].Append("№ п/п");
                    row.Cells[1].Paragraphs[0].Append(dateField.Text);
                    row.Cells[2].Paragraphs[0].Append(copyContentField.Text);
                    row.Cells[3].Paragraphs[0].Append(copySizeField.Text);
                    row.Cells[4].Paragraphs[0].Append(storageNumberField.Text);
                    row.Cells[5].Paragraphs[0].Append(storagePlaceField.Text);
                    row.Cells[6].Paragraphs[0].Append(personField.Text);
                    row.Cells[7].Paragraphs[0].Append(signatureField.Text);
                    document.Save();
                    contentTextBox.Text += "Записано:\n";
                } catch(Exception exc)
                {
                    contentTextBox.Text += $"{exc}";
                }

            }
        }
        
    }
}
