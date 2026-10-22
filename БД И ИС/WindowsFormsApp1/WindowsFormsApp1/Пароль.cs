using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Пароль : Form
    {
        public Пароль()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Строка подключения для MS Access (.accdb или .mdb)
            // Замените "UsersDB.accdb" на имя вашего файла базы данных
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=family.accdb;";

            // Если у вас старый формат .mdb и провайдер Jet:
            // string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=UsersDB.mdb;";

            string query = "SELECT COUNT(*) FROM [Пользователи] WHERE [Login] = ? AND [Password] = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавление параметров для защиты от SQL-инъекций
                        command.Parameters.Add("?", OleDbType.VarWChar).Value = login;
                        command.Parameters.Add("?", OleDbType.VarWChar).Value = password;

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Открытие следующей формы:
                             Form1 main = new Form1();
                             main.Show();
                             this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Clear();
                            textBox2.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}