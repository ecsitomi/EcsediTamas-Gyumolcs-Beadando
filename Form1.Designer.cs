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
            this.listBox_Gyumolcs = new System.Windows.Forms.ListBox();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Uj = new System.Windows.Forms.Button();
            this.button_Modosit = new System.Windows.Forms.Button();
            this.button_Torol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Gyumolcs
            // 
            this.listBox_Gyumolcs.FormattingEnabled = true;
            this.listBox_Gyumolcs.Location = new System.Drawing.Point(14, 5);
            this.listBox_Gyumolcs.Name = "listBox_Gyumolcs";
            this.listBox_Gyumolcs.Size = new System.Drawing.Size(224, 147);
            this.listBox_Gyumolcs.TabIndex = 0;
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(247, 10);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(75, 23);
            this.button_Betoltes.TabIndex = 1;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(247, 40);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(75, 23);
            this.button_Mentes.TabIndex = 2;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // button_Uj
            // 
            this.button_Uj.Location = new System.Drawing.Point(247, 70);
            this.button_Uj.Name = "button_Uj";
            this.button_Uj.Size = new System.Drawing.Size(75, 23);
            this.button_Uj.TabIndex = 3;
            this.button_Uj.Text = "Új";
            this.button_Uj.UseVisualStyleBackColor = true;
            this.button_Uj.Click += new System.EventHandler(this.button_Uj_Click);
            // 
            // button_Modosit
            // 
            this.button_Modosit.Location = new System.Drawing.Point(247, 100);
            this.button_Modosit.Name = "button_Modosit";
            this.button_Modosit.Size = new System.Drawing.Size(75, 23);
            this.button_Modosit.TabIndex = 4;
            this.button_Modosit.Text = "Módosít";
            this.button_Modosit.UseVisualStyleBackColor = true;
            this.button_Modosit.Click += new System.EventHandler(this.button_Modosit_Click);
            // 
            // button_Torol
            // 
            this.button_Torol.Location = new System.Drawing.Point(247, 130);
            this.button_Torol.Name = "button_Torol";
            this.button_Torol.Size = new System.Drawing.Size(75, 23);
            this.button_Torol.TabIndex = 5;
            this.button_Torol.Text = "Töröl";
            this.button_Torol.UseVisualStyleBackColor = true;
            this.button_Torol.Click += new System.EventHandler(this.button_Torol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 169);
            this.Controls.Add(this.button_Torol);
            this.Controls.Add(this.button_Modosit);
            this.Controls.Add(this.button_Uj);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.listBox_Gyumolcs);
            this.Name = "Form1";
            this.Text = "Ecsedi Gyümölcsei";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Uj;
        private System.Windows.Forms.Button button_Modosit;
        private System.Windows.Forms.Button button_Torol;
        internal System.Windows.Forms.ListBox listBox_Gyumolcs;
    }
}

