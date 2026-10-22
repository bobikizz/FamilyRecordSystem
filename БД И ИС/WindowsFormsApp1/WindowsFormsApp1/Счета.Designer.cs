namespace WindowsFormsApp1
{
    partial class Счета
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
            this.familyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.familyDataSet = new WindowsFormsApp1.familyDataSet();
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетаTableAdapter = new WindowsFormsApp1.familyDataSetTableAdapters.СчетаTableAdapter();
            this.кодСчетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.счетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСчетаDataGridViewTextBoxColumn,
            this.счетDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.счетаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 181);
            this.dataGridView1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 52);
            this.button5.TabIndex = 8;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "familyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.familyDataSet;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
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
            // Счета
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Счета";
            this.Text = "Счета";
            this.Load += new System.EventHandler(this.Счета_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource familyDataSetBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private familyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource счетаBindingSource;
        private familyDataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСчетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn счетDataGridViewTextBoxColumn;
    }
}