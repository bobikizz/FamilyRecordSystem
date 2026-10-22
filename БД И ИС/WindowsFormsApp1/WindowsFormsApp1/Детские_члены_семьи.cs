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
    public partial class Детские_члены_семьи : Form
    {
        public Детские_члены_семьи()
        {
            InitializeComponent();
        }

        private void Детские_члены_семьи_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Члены_семьи". При необходимости она может быть перемещена или удалена.
            this.члены_семьиTableAdapter.Fill(this.familyDataSet.Члены_семьи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {

                this.Owner.Show();
            }


            this.Close();
        }
    }
}
