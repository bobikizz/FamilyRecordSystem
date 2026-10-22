using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр второй формы
            Пароль mainMenu = new Пароль();

            // Показываем вторую форму
            mainMenu.Show();

            // Скрываем текущую (первую) форму
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Детское_Меню formDet = new Детское_Меню();

            // Передаем текущую форму (Главное меню) как владельца
            formDet.Owner = this;

            // Показываем категории и скрываем главное меню
            formDet.Show();
            this.Hide();
        }
    }
}
