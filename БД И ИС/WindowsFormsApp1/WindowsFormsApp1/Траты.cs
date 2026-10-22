using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.familyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Траты : Form
    {
        public Траты()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {

                this.Owner.Show();
            }


            this.Close();
        }

        private void Траты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Траты". При необходимости она может быть перемещена или удалена.
            this.тратыTableAdapter.Fill(this.familyDataSet.Траты);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            тратыBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            тратыTableAdapter.Update(this.familyDataSet.Траты);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли вообще что удалять
            if (тратыBindingSource.Current != null)
            {
                // 1. Удаляет текущую выбранную строку из компонента на форме
                тратыBindingSource.RemoveCurrent();

                // 2. Сразу сохраняет удаление физически в базу Access
                тратыTableAdapter.Update(this.familyDataSet.Траты);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Сумма dateForm = new Сумма())
            {
                if (dateForm.ShowDialog() == DialogResult.OK)
                {
                    // Получаем выбранные пользователем даты
                    DateTime start = dateForm.StartDate;
                    DateTime end = dateForm.EndDate;

                    // 2. Вызываем метод загрузки и расчета данных
                    CalculateExpenses(start, end);
                }
            }
        }
        // ВСТАВЛЯЕМ СУЩЕСТВУЮЩИЙ МЕТОД НИЖЕ:

        private void CalculateExpenses(DateTime startDate, DateTime endDate)
        {
            string connectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\family.accdb;";

            string query = @"
        SELECT
            C.[Категория] AS [Категория трат],
            SUM(E.[Сумма]) AS [Общая сумма]
        FROM
            [Траты] AS E
        INNER JOIN
            [Категории трат] AS C
            ON E.[КодКатегории] = C.[КодКатегории]
        WHERE
            E.[Дата] >= ? AND E.[Дата] < ?
        GROUP BY
            C.[Категория]";

            try
            {
                using (System.Data.OleDb.OleDbConnection conn =
                    new System.Data.OleDb.OleDbConnection(connectionString))
                {
                    conn.Open();

                    using (System.Data.OleDb.OleDbCommand cmd =
                        new System.Data.OleDb.OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("?",
                            System.Data.OleDb.OleDbType.Date).Value =
                            startDate.Date;

                        cmd.Parameters.Add("?",
                            System.Data.OleDb.OleDbType.Date).Value =
                            endDate.Date.AddDays(1);

                        System.Data.DataTable dt =
                            new System.Data.DataTable();

                        using (System.Data.OleDb.OleDbDataAdapter adapter =
                            new System.Data.OleDb.OleDbDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "За выбранный период трат не найдено.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при работе с БД:\n" + ex.Message);
            }
        }
    }
}