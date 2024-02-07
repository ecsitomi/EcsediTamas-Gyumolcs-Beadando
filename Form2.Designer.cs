namespace EcsediTamas_Gyumolcs_Beadando
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Termekkod = new System.Windows.Forms.TextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termékkód";
            // 
            // textBox_Termekkod
            // 
            this.textBox_Termekkod.Location = new System.Drawing.Point(86, 11);
            this.textBox_Termekkod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Termekkod.Name = "textBox_Termekkod";
            this.textBox_Termekkod.ReadOnly = true;
            this.textBox_Termekkod.Size = new System.Drawing.Size(167, 20);
            this.textBox_Termekkod.TabIndex = 1;
            this.textBox_Termekkod.TabStop = false;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(86, 35);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(167, 20);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mennyiség";
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(86, 59);
            this.numericUpDown_Mennyiseg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_Mennyiseg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(166, 20);
            this.numericUpDown_Mennyiseg.TabIndex = 2;
            this.numericUpDown_Mennyiseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown_Mennyiseg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Termekkod);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Ecsedi gyümölcsei";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Termekkod;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.Button button1;
        #region Windows Form Designer generated code
        }
        #endregion
    }
