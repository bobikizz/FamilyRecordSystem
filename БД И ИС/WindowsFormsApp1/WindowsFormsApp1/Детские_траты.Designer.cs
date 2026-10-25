namespace WindowsFormsApp1
{
    partial class Детские_траты
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new ModernButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТратыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодЧленаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКатегорииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тратыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyDataSet = new WindowsFormsApp1.familyDataSet();
            this.тратыTableAdapter = new WindowsFormsApp1.familyDataSetTableAdapters.ТратыTableAdapter();
            this.button3 = new ModernButton();
            this.button2 = new ModernButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тратыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТратыDataGridViewTextBoxColumn,
            this.кодЧленаDataGridViewTextBoxColumn,
            this.кодКатегорииDataGridViewTextBoxColumn,
            this.кодСчетаDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.тратыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 156);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодТратыDataGridViewTextBoxColumn
            // 
            this.кодТратыDataGridViewTextBoxColumn.DataPropertyName = "КодТраты";
            this.кодТратыDataGridViewTextBoxColumn.HeaderText = "КодТраты";
            this.кодТратыDataGridViewTextBoxColumn.Name = "кодТратыDataGridViewTextBoxColumn";
            // 
            // кодЧленаDataGridViewTextBoxColumn
            // 
            this.кодЧленаDataGridViewTextBoxColumn.DataPropertyName = "КодЧлена";
            this.кодЧленаDataGridViewTextBoxColumn.HeaderText = "КодЧлена";
            this.кодЧленаDataGridViewTextBoxColumn.Name = "кодЧленаDataGridViewTextBoxColumn";
            // 
            // кодКатегорииDataGridViewTextBoxColumn
            // 
            this.кодКатегорииDataGridViewTextBoxColumn.DataPropertyName = "КодКатегории";
            this.кодКатегорииDataGridViewTextBoxColumn.HeaderText = "КодКатегории";
            this.кодКатегорииDataGridViewTextBoxColumn.Name = "кодКатегорииDataGridViewTextBoxColumn";
            // 
            // кодСчетаDataGridViewTextBoxColumn
            // 
            this.кодСчетаDataGridViewTextBoxColumn.DataPropertyName = "КодСчета";
            this.кодСчетаDataGridViewTextBoxColumn.HeaderText = "КодСчета";
            this.кодСчетаDataGridViewTextBoxColumn.Name = "кодСчетаDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // тратыBindingSource
            // 
            this.тратыBindingSource.DataMember = "Траты";
            this.тратыBindingSource.DataSource = this.familyDataSet;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "familyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тратыTableAdapter
            // 
            this.тратыTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(629, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Детские_траты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Детские_траты";
            this.Text = "Детские_траты";
            this.Load += new System.EventHandler(this.Детские_траты_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тратыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ModernButton button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private familyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource тратыBindingSource;
        private familyDataSetTableAdapters.ТратыTableAdapter тратыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТратыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧленаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКатегорииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private ModernButton button3;
        private ModernButton button2;
    }
}