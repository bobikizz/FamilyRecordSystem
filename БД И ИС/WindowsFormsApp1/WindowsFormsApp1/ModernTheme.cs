
using System;
using System.Drawing;
using System.Windows.Forms;

public static class ModernTheme
{
    private static readonly Color TextColor =
        Color.FromArgb(235, 242, 255);

    private static readonly Color InputColor =
        Color.FromArgb(39, 57, 85);

    private static readonly Color AccentColor =
        Color.FromArgb(100, 149, 220);

    // Оформление всех элементов
    public static void Apply(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            // LABEL
            if (control is Label label)
            {
                label.BackColor = Color.Transparent;
                label.ForeColor = TextColor;

                label.Font = new Font(
                    "Segoe UI", 10F,
                    FontStyle.Regular);
            }

            // GROUPBOX
            else if (control is GroupBox group)
            {
                group.BackColor = Color.Transparent;
                group.ForeColor = TextColor;

                group.Font = new Font(
                    "Segoe UI", 10F,
                    FontStyle.Bold);

                group.FlatStyle = FlatStyle.Flat;
            }

            // TEXTBOX
            else if (control is TextBox textbox)
            {
                textbox.BackColor = InputColor;
                textbox.ForeColor = Color.White;

                textbox.BorderStyle =
                    BorderStyle.FixedSingle;

                textbox.Font = new Font(
                    "Segoe UI", 11F,
                    FontStyle.Regular);
            }

            // DATETIMEPICKER
            else if (control is DateTimePicker date)
            {
                date.Font = new Font(
                    "Segoe UI", 10F,
                    FontStyle.Regular);

                date.Format =
                    DateTimePickerFormat.Custom;

                date.CustomFormat = "dd.MM.yyyy";

                date.CalendarMonthBackground =
                    InputColor;

                date.CalendarForeColor =
                    TextColor;

                date.CalendarTitleBackColor =
                    AccentColor;

                date.CalendarTitleForeColor =
                    Color.White;

                // Для стандартного светлого поля
                date.ForeColor =
                    Color.FromArgb(30, 41, 59);
            }

            else if (control is DataGridView grid)
            {
                // Основной фон таблицы
                grid.BackgroundColor =
                    Color.FromArgb(25, 39, 67);

                grid.BorderStyle = BorderStyle.None;

                // Цвет линий между строками
                grid.GridColor =
                    Color.FromArgb(55, 75, 110);

                grid.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;

                // Убираем стандартную левую колонку
                grid.RowHeadersVisible = false;

                // Заголовки столбцов
                grid.EnableHeadersVisualStyles = false;

                grid.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.FromArgb(30, 48, 80);

                grid.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.FromArgb(147, 197, 253);

                grid.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10F, FontStyle.Bold);

                grid.ColumnHeadersDefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                grid.ColumnHeadersBorderStyle =
                    DataGridViewHeaderBorderStyle.None;

                grid.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                grid.ColumnHeadersHeight = 42;

                // Основные строки
                grid.DefaultCellStyle.BackColor =
                    Color.FromArgb(32, 48, 77);

                grid.DefaultCellStyle.ForeColor = Color.White;

                grid.DefaultCellStyle.Font =
                    new Font("Segoe UI", 10F);

                grid.DefaultCellStyle.Padding =
                    new Padding(8, 2, 8, 2);

                // Чередование строк
                grid.AlternatingRowsDefaultCellStyle.BackColor =
                    Color.FromArgb(39, 57, 85);

                // Цвет выделенной строки
                grid.DefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(59, 100, 170);

                grid.DefaultCellStyle.SelectionForeColor =
                    Color.White;

                // Высота новых строк
                grid.RowTemplate.Height = 36;

                // Выделение всей строки
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                // Убираем некрасивый стандартный фон
                // в пустой области таблицы
                grid.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

                // Единый цвет всех заголовков
                grid.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                    Color.FromArgb(30, 48, 80);

                grid.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                    Color.FromArgb(147, 197, 253);

                // Столбцы заполняют всю ширину таблицы
                grid.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Заголовки могут переноситься на две строки
                grid.ColumnHeadersDefaultCellStyle.WrapMode =
                    DataGridViewTriState.True;

                grid.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // Убираем возможность случайно добавить строку
                grid.AllowUserToAddRows = false;

                // Красивое выделение всей строки
                grid.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

            }


            // Элементы внутри GroupBox, Panel и т.д.
            if (control.HasChildren)
            {
                Apply(control);
            }
        }
    }
}
