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

        // открыть файл
        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            filename = openFileDialog.SafeFileName;
            filepath = openFileDialog.FileName;
            contextBox.Text = filename;

            // запись в таблицу
            using (var document = DocX.Load(filepath))
            {
                var table = document.Tables[0];

                // вставка пустой строки
                var row = table.InsertRow();
                row.Cells[0].Paragraphs[0].Append("1");
                row.Cells[1].Paragraphs[0].Append("2");
                document.Save();

            }

        }
    }
}
