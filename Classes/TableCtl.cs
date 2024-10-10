using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ms_word_writer.Classes
{
    public static class TableCtl
    {
        // создание таблицы
        public static Table Create(Form form, string filepath)
        {
            var document = DocX.Load(filepath);
            var table = document.AddTable(2, 8);

            float[] widths = { 60, 250, 250, 250, 250, 250, 250, 250 };
            table.SetWidths(widths, true);


            table.Rows[0].Cells[0].Paragraphs[0].Append("№ п/п");
            table.Rows[0].Cells[1].Paragraphs[0].Append("Дата создания резервной\r\nкопии\r\n");
            table.Rows[0].Cells[2].Paragraphs[0].Append("Содержание резервной копии");
            table.Rows[0].Cells[3].Paragraphs[0].Append("Размер\r\nрезервной\r\nкопии\r\n(Мб)\r\n");
            table.Rows[0].Cells[4].Paragraphs[0].Append("Учетный номер\r\nносителя\r\n");
            table.Rows[0].Cells[5].Paragraphs[0].Append("Место хранения\r\nносителя\r\n");
            table.Rows[0].Cells[6].Paragraphs[0].Append("ФИО, должность лица,\r\nосуществившего резервное копирование\r\n");
            table.Rows[0].Cells[7].Paragraphs[0].Append("Подпись должностного лица, осуществившего резервное копирование");

            table.Rows[1].Cells[0].Paragraphs[0].Append("1");
            table.Rows[1].Cells[1].Paragraphs[0].Append("2");
            table.Rows[1].Cells[2].Paragraphs[0].Append("3");
            table.Rows[1].Cells[3].Paragraphs[0].Append("4");
            table.Rows[1].Cells[4].Paragraphs[0].Append("5");
            table.Rows[1].Cells[5].Paragraphs[0].Append("6");
            table.Rows[1].Cells[6].Paragraphs[0].Append("7");
            table.Rows[1].Cells[7].Paragraphs[0].Append("8");


            table.Alignment = Alignment.center;
            table.SetTableCellMargin(TableCellMarginType.top, 10);
            table.SetTableCellMargin(TableCellMarginType.bottom, 10);
            table.SetTableCellMargin(TableCellMarginType.left, 5);
            table.SetTableCellMargin(TableCellMarginType.right, 5);

            document.InsertTable(table);
            document.Save();
            return table;
        }
    }
}
