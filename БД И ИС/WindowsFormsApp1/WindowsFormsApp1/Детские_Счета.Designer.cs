namespace WindowsFormsApp1
{
    partial class Детские_Счета
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодСчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyDataSet = new WindowsFormsApp1.familyDataSet();
            this.счетаTableAdapter = new WindowsFormsApp1.familyDataSetTableAdapters.СчетаTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
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
            this.кодСчетаDataGridViewTextBoxColumn,
            this.счетDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 157);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодСчетаDataGridViewTextBoxColumn
            // 
            this.кодСчетаDataGridViewTextBoxColumn.DataPropertyName = "КодСчета";
            this.кодСчетаDataGridViewTextBoxColumn.HeaderText = "КодСчета";
            this.кодСчетаDataGridViewTextBoxColumn.Name = "кодСчетаDataGridViewTextBoxColumn";
            // 
            // счетDataGridViewTextBoxColumn
            // 
            this.счетDataGridViewTextBoxColumn.DataPropertyName = "Счет";
            this.счетDataGridViewTextBoxColumn.HeaderText = "Счет";
            this.счетDataGridViewTextBoxColumn.Name = "счетDataGridViewTextBoxColumn";
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.familyDataSet;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "familyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Детские_Счета
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Детские_Счета";
            this.Text = "Детские_Счета";
            this.Load += new System.EventHandler(this.Детские_Счета_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private familyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource счетаBindingSource;
        private familyDataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn счетDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}