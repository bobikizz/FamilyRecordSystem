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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            КатегорииТрат formCategories = new КатегорииТрат();

            // Передаем текущую форму (Главное меню) как владельца
            formCategories.Owner = this;

            // Показываем категории и скрываем главное меню
            formCategories.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Счета formScheta = new Счета();

            // Передаем текущую форму (Главное меню) как владельца
            formScheta.Owner = this;

            // Показываем категории и скрываем главное меню
            formScheta.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Траты formTrats = new Траты();

            
            formTrats.Owner = this;

            
            formTrats.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Члены_семьи formFamili = new Члены_семьи();


            formFamili.Owner = this;


            formFamili.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
