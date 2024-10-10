using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ms_word_writer.Classes
{
    /// <summary>
    /// Управляет записью данных в таблицу MS Word
    /// </summary>
    public static class TableCtl
    {
        /// <summary>
        /// Создает таблицу
        /// </summary>
        public static Table Create(Form form, string filepath)
        {
            var document = DocX.Load(filepath);
            var table = document.AddTable(2, 8);

            float[] widths = { 80, 400, 400, 400, 400, 400, 400, 400 };
            table.SetWidths(widths, true);
            // выравнивание в документе
            //table.Alignment = Alignment.center;
            // оступы
            table.SetTableCellMargin(TableCellMarginType.top, 10);
            table.SetTableCellMargin(TableCellMarginType.bottom, 10);
            table.SetTableCellMargin(TableCellMarginType.left, 5);
            table.SetTableCellMargin(TableCellMarginType.right, 5);

            // заголовки таблицы
            string[] headerArr = {
                "№ п/п",
                "Дата создания резервной\r\nкопии\r\n",
                "Содержание резервной копии",
                "Размер\r\nрезервной\r\nкопии\r\n(Мб)\r\n",
                "Учетный номер\r\nносителя\r\n",
                "Место хранения\r\nносителя\r\n",
                "ФИО, должность лица,\r\nосуществившего резервное копирование\r\n",
                "Подпись должностного лица, осуществившего резервное копирование"
            };
            for (int i = 0; i < headerArr.Length; i++)
            {
                table.Rows[0].Cells[i].Paragraphs[0].Append(headerArr[i]);
                table.Rows[0].Cells[i].Paragraphs[0].Alignment = Alignment.center;
                table.Rows[0].Cells[i].Paragraphs[0].FontSize(12).Bold();
                table.Rows[1].Cells[i].Paragraphs[0].Append((i + 1).ToString());
                table.Rows[1].Cells[i].Paragraphs[0].Alignment = Alignment.center;
                table.Rows[1].Cells[i].Paragraphs[0].FontSize(12);
            }

            document.InsertTable(table);
            document.Save();
            return table;
        }

        /// <summary>
        /// Записывает строку в таблицу
        /// <param name="filepath"></param>
        /// <param name="data"></param>
        /// </summary>
        public static void Write(string filepath, string[] data)
        {
            using (var document = DocX.Load(filepath))
            {
                var table = document.Tables[document.Tables.Count - 1];
                var row = table.InsertRow();
                for (int i = 0; i < data.Length; i++)
                {
                    row.Cells[i].Paragraphs[0].Append(data[i]);
                    row.Cells[i].Paragraphs[0].Alignment = Alignment.center;
                    row.Cells[i].Paragraphs[0].FontSize(12);
                }
                document.Save();
            }
        }
    }
}
