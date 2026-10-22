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
    public partial class Члены_семьи : Form
    {
        public Члены_семьи()
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

        private void Члены_семьи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Члены_семьи". При необходимости она может быть перемещена или удалена.
            this.члены_семьиTableAdapter.Fill(this.familyDataSet.Члены_семьи);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            члены_семьиTableAdapter.Update(this.familyDataSet.Члены_семьи);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            членыСемьиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли вообще что удалять
            if (членыСемьиBindingSource.Current != null)
            {
                // 1. Удаляет текущую выбранную строку из компонента на форме
                членыСемьиBindingSource.RemoveCurrent();

                // 2. Сразу сохраняет удаление физически в базу Access
                члены_семьиTableAdapter.Update(this.familyDataSet.Члены_семьи);
            }
        }
    }
}
