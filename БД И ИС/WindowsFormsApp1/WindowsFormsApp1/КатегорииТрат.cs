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
    public partial class КатегорииТрат : Form
    {
        public КатегорииТрат()
        {
            InitializeComponent();
        }

        private void КатегорииТрат_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Категории_трат". При необходимости она может быть перемещена или удалена.
            this.категории_тратTableAdapter.Fill(this.familyDataSet.Категории_трат);

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
