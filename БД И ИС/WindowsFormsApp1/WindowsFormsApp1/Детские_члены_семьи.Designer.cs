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
            this.familyDataSet = new WindowsFormsApp1.familyDataSet();
            this.членыСемьиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.члены_семьиTableAdapter = new WindowsFormsApp1.familyDataSetTableAdapters.Члены_семьиTableAdapter();
            this.кодЧленаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).BeginInit();
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
            // familyDataSet
            // 
            this.familyDataSet.DataSetName = "familyDataSet";
            this.familyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // членыСемьиBindingSource
            // 
            this.членыСемьиBindingSource.DataMember = "Члены семьи";
            this.членыСемьиBindingSource.DataSource = this.familyDataSet;
            // 
            // члены_семьиTableAdapter
            // 
            this.члены_семьиTableAdapter.ClearBeforeFill = true;
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
            // Детские_члены_семьи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Детские_члены_семьи";
            this.Text = "Детские_члены_семьи";
            this.Load += new System.EventHandler(this.Детские_члены_семьи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.членыСемьиBindingSource)).EndInit();
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
    }
}