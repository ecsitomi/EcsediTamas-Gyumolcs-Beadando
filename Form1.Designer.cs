namespace EcsediTamas_Gyumolcs_Beadando
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Uj = new System.Windows.Forms.Button();
            this.button_Modosit = new System.Windows.Forms.Button();
            this.button_Torol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 147);
            this.listBox1.TabIndex = 0;
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(371, 13);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_Betoltes.TabIndex = 1;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(371, 43);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(75, 23);
            this.button_Mentes.TabIndex = 2;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            // 
            // button_Uj
            // 
            this.button_Uj.Location = new System.Drawing.Point(371, 73);
            this.button_Uj.Name = "button_Uj";
            this.button_Uj.Size = new System.Drawing.Size(75, 23);
            this.button_Uj.TabIndex = 3;
            this.button_Uj.Text = "Új";
            this.button_Uj.UseVisualStyleBackColor = true;
            // 
            // button_Modosit
            // 
            this.button_Modosit.Location = new System.Drawing.Point(371, 103);
            this.button_Modosit.Name = "button_Modosit";
            this.button_Modosit.Size = new System.Drawing.Size(75, 23);
            this.button_Modosit.TabIndex = 4;
            this.button_Modosit.Text = "Módosít";
            this.button_Modosit.UseVisualStyleBackColor = true;
            // 
            // button_Torol
            // 
            this.button_Torol.Location = new System.Drawing.Point(371, 133);
            this.button_Torol.Name = "button_Torol";
            this.button_Torol.Size = new System.Drawing.Size(75, 23);
            this.button_Torol.TabIndex = 5;
            this.button_Torol.Text = "Töröl";
            this.button_Torol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 169);
            this.Controls.Add(this.button_Torol);
            this.Controls.Add(this.button_Modosit);
            this.Controls.Add(this.button_Uj);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Ecsedi Gyümölcsei";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Uj;
        private System.Windows.Forms.Button button_Modosit;
        private System.Windows.Forms.Button button_Torol;
    }
}

