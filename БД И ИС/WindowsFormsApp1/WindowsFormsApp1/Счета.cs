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
    public partial class Счета : Form
    {
        public Счета()
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

        private void Счета_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Счета". При необходимости она может быть перемещена или удалена.
            this.счетаTableAdapter.Fill(this.familyDataSet.Счета);

        }

        private void button5_Click(object sender, EventArgs e)
        {
           счетаTableAdapter.Update(this.familyDataSet.Счета);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            счетаBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, есть ли вообще что удалять
            if (счетаBindingSource.Current != null)
            {
                // 1. Удаляет текущую выбранную строку из компонента на форме
                счетаBindingSource.RemoveCurrent();

                // 2. Сразу сохраняет удаление физически в базу Access
                счетаTableAdapter.Update(this.familyDataSet.Счета);
            }
        }
    }
}
