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
    public partial class Детские_траты : GradientForm
    {
        public Детские_траты()
        {
            InitializeComponent();
            ModernTheme.Apply(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {

                this.Owner.Show();
            }


            this.Close();
        }

        private void Детские_траты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "familyDataSet.Траты". При необходимости она может быть перемещена или удалена.
            this.тратыTableAdapter.Fill(this.familyDataSet.Траты);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            тратыBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тратыTableAdapter.Update(this.familyDataSet.Траты);
        }
    }
}
