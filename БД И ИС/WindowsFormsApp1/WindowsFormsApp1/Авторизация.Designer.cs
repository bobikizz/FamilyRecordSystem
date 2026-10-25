namespace WindowsFormsApp1
{
    partial class Авторизация
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
            this.button1 = new ModernButton();
            this.button2 = new ModernButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button1.BorderRadius = 15;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.CustomTextColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.button1.Location = new System.Drawing.Point(111, 195);
            this.button1.Name = "button1";
            this.button1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(102)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Родитель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(109)))), ((int)(((byte)(148)))));
            this.button2.BorderRadius = 15;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.CustomTextColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.button2.Location = new System.Drawing.Point(550, 195);
            this.button2.Name = "button2";
            this.button2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(102)))));
            this.button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.button2.Size = new System.Drawing.Size(108, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ребёнок";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Авторизация";
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private ModernButton button1;
        private ModernButton button2;
    }
}