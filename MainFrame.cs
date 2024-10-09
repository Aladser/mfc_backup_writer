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
            contentTextBox.Text = filename + "\n";
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
                    row.Cells[0].Paragraphs[0].Append(numberField.Text);
                    row.Cells[1].Paragraphs[0].Append(dateField.Text);
                    document.Save();
                    contentTextBox.Text += $"Записано: {numberLabel.Text} = {numberField.Text}, {dateLabel.Text} = {dateField.Text}\n";
                } catch(Exception exc)
                {
                    contentTextBox.Text += $"{exc}";
                }

            }
        }
        
    }
}
