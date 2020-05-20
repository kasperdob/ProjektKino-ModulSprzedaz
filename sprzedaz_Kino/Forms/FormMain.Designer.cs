namespace sprzedaz_Kino
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNoweZamowienie = new System.Windows.Forms.Button();
            this.buttonManagmentPanel = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.numericUpDownUprawnienie = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUprawnienie)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNoweZamowienie
            // 
            this.buttonNoweZamowienie.Location = new System.Drawing.Point(11, 18);
            this.buttonNoweZamowienie.Name = "buttonNoweZamowienie";
            this.buttonNoweZamowienie.Size = new System.Drawing.Size(553, 75);
            this.buttonNoweZamowienie.TabIndex = 0;
            this.buttonNoweZamowienie.Text = "Nowe Zamówienie";
            this.buttonNoweZamowienie.UseVisualStyleBackColor = true;
            this.buttonNoweZamowienie.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonManagmentPanel
            // 
            this.buttonManagmentPanel.Enabled = false;
            this.buttonManagmentPanel.Location = new System.Drawing.Point(11, 124);
            this.buttonManagmentPanel.Name = "buttonManagmentPanel";
            this.buttonManagmentPanel.Size = new System.Drawing.Size(553, 75);
            this.buttonManagmentPanel.TabIndex = 1;
            this.buttonManagmentPanel.Text = "Managment Panel";
            this.buttonManagmentPanel.UseVisualStyleBackColor = true;
            this.buttonManagmentPanel.Click += new System.EventHandler(this.buttonManagmentPanel_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(211, 245);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(153, 46);
            this.buttonPowrot.TabIndex = 2;
            this.buttonPowrot.Text = "powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // numericUpDownUprawnienie
            // 
            this.numericUpDownUprawnienie.Location = new System.Drawing.Point(11, 232);
            this.numericUpDownUprawnienie.Name = "numericUpDownUprawnienie";
            this.numericUpDownUprawnienie.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownUprawnienie.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 259);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Kierownik";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 314);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDownUprawnienie);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonManagmentPanel);
            this.Controls.Add(this.buttonNoweZamowienie);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUprawnienie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNoweZamowienie;
        private System.Windows.Forms.Button buttonManagmentPanel;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.NumericUpDown numericUpDownUprawnienie;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

