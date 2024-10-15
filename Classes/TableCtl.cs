using System.Drawing;
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
        const string FONT_NAME = "Arial";
        const double FONT_SIZE = 10.5;
        /// <summary>
        /// Создает таблицу
        /// </summary>
        public static Xceed.Document.NET.Table Create(DocX document)
        {
            var table = document.AddTable(2, 8);

            // отступы ячеек
            float[] widths = { 80, 400, 400, 400, 400, 400, 400, 400 };
            table.SetWidths(widths, true);
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
                WriteRowCellContent(table.Rows[0], i, headerArr[i], true);
                WriteRowCellContent(table.Rows[1], i, (i + 1).ToString());
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
        public static DocX Write(string filepath, string[] data)
        {
            var document = DocX.Load(filepath);
            var table = document.Tables[document.Tables.Count - 1];
            var row = table.InsertRow();
            for (int i = 0; i < data.Length; i++)
            {
                WriteRowCellContent(row, i, data[i]);
            }
            document.Save();

            return document;

        }

        /// <summary>
        /// Возвращает номер последней строки
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public static int GetLastRecordNumber(DocX document)
        {
            if (document.Tables.Count <= 0)
            {
                return -1;
            }

            Table lastTable = document.Tables[document.Tables.Count - 1];
            if (lastTable.RowCount < 3)
            {
                return 0;
            }

            Row lastRow = lastTable.Rows[lastTable.RowCount - 1];
            int.TryParse(lastRow.Cells[0].Paragraphs[0].Text, out int number);
            return number;
        }


        /// <summary>
        /// Записывает данные в ячейку строки таблицы
        /// </summary>
        /// <param name="row"></param> Xceed.Document.NET.Row строка
        /// <param name="cellIndex"></param> индекс ячейки
        /// <param name="text"></param> содержание ячейки
        private static void WriteRowCellContent(Xceed.Document.NET.Row row, int cellIndex, string text, bool isHeader = false)
        {
            row.Cells[cellIndex].Paragraphs[0].Append(text);

            Border b = new Border(Xceed.Document.NET.BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Black);
            row.Cells[cellIndex].SetBorder(TableCellBorderType.Top, b);
            row.Cells[cellIndex].SetBorder(TableCellBorderType.Bottom, b);
            row.Cells[cellIndex].SetBorder(TableCellBorderType.Left, b);
            row.Cells[cellIndex].SetBorder(TableCellBorderType.Right, b);
            row.Cells[cellIndex].VerticalAlignment = VerticalAlignment.Center;
            row.Cells[cellIndex].Paragraphs[0].Alignment = Alignment.center;
            row.Cells[cellIndex].MarginTop = 8;
            row.Cells[cellIndex].MarginBottom = 8;
            row.Cells[cellIndex].Paragraphs[0].FontSize(FONT_SIZE).Font(new Xceed.Document.NET.Font(FONT_NAME));

            if (isHeader)
            {
                row.Cells[cellIndex].Paragraphs[0].Bold();
            }
        }
    }
}
