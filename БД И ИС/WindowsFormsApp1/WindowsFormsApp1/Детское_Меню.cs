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
    public partial class Детское_Меню : GradientForm
    {
        public Детское_Меню()
        {
            InitializeComponent();
            ModernTheme.Apply(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Детские_траты formDet_trat = new Детские_траты();

            // Передаем текущую форму (Главное меню) как владельца
            formDet_trat.Owner = this;

            // Показываем категории и скрываем главное меню
            formDet_trat.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Детские_Счета formDet_scheta = new Детские_Счета();

            // Передаем текущую форму (Главное меню) как владельца
            formDet_scheta.Owner = this;

            // Показываем категории и скрываем главное меню
            formDet_scheta.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Детские_члены_семьи formDet_Chs = new Детские_члены_семьи();

            // Передаем текущую форму (Главное меню) как владельца
            formDet_Chs.Owner = this;

            // Показываем категории и скрываем главное меню
            formDet_Chs.Show();
            this.Hide();
        }
    }
}
