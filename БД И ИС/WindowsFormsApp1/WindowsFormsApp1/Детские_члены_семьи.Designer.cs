namespace WindowsFormsApp1
{
    partial class Детские_члены_семьи
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
            this.кодЧленаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.членыСемьиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familyDataSet = new WindowsFormsApp1.familyDataSet();
            this.члены_семьиTableAdapter = new WindowsFormsApp1.familyDataSetTableAdapters.Члены_семьиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
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
            this.кодЧленаDataGridViewTextBoxColumn,
            this.рольDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.членыСемьиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(256, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // кодЧленаDataGridViewTextBoxColumn
            // 
            this.кодЧленаDataGridViewTextBoxColumn.DataPropertyName = "КодЧлена";
            this.кодЧленаDataGridViewTextBoxColumn.HeaderText = "КодЧлена";
            this.кодЧленаDataGridViewTextBoxColumn.Name = "кодЧленаDataGridViewTextBoxColumn";
            // 
            // рольDataGridViewTextBoxColumn
            // 
            this.рольDataGridViewTextBoxColumn.DataPropertyName = "Роль";
            this.рольDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.рольDataGridViewTextBoxColumn.Name = "рольDataGridViewTextBoxColumn";
            // 
            // членыСемьиBindingSource
            // 
            this.членыСемьиBindingSource.DataMember = "Члены семьи";
            this.членыСемьиBindingSource.DataSource = this.familyDataSet;
            // 
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "familyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // члены_семьиTableAdapter
            // 
            this.члены_семьиTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Детские_члены_семьи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Детские_члены_семьи";
            this.Text = "Детские_члены_семьи";
            this.Load += new System.EventHandler(this.Детские_члены_семьи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private familyDataSet familyDataSet;
        private System.Windows.Forms.BindingSource членыСемьиBindingSource;
        private familyDataSetTableAdapters.Члены_семьиTableAdapter члены_семьиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЧленаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}