using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class Сумма : Form
    {
        public Сумма()
        {
            InitializeComponent();
        }

        public DateTime StartDate => dtpStart.Value.Date;
        public DateTime EndDate => dtpEnd.Value.Date;


        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Укажите правильный путь к вашему файлу базы данных .accdb или .mdb
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=family.accdb;";

            // 2. Запрос считает сумму из поля [Сумма] таблицы [Траты] за выбранный период [Дата]
            string query = "SELECT SUM(Сумма) FROM Траты WHERE Дата BETWEEN @Start AND @End";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // 3. ПЕРЕДАЧА ПАРАМЕТРОВ (Строго в том порядке, в каком они идут в запросе!)
                    command.Parameters.AddWithValue("@Start", StartDate);
                    command.Parameters.AddWithValue("@End", EndDate);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            MessageBox.Show($"Сумма трат за выбранный период: {result} руб.");
                        }
                        else
                        {
                            MessageBox.Show("За этот период трат не найдено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
