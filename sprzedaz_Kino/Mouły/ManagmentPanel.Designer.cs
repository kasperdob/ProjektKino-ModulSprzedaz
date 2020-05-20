namespace sprzedaz_Kino.Mouły
{
    partial class ManagmentPanel
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
            this.buttonAddZestaw = new System.Windows.Forms.Button();
            this.buttonDelZestaw = new System.Windows.Forms.Button();
            this.buttonAddToPack = new System.Windows.Forms.Button();
            this.AddProdukt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAddZestaw
            // 
            this.buttonAddZestaw.Location = new System.Drawing.Point(51, 361);
            this.buttonAddZestaw.Name = "buttonAddZestaw";
            this.buttonAddZestaw.Size = new System.Drawing.Size(128, 23);
            this.buttonAddZestaw.TabIndex = 8;
            this.buttonAddZestaw.Text = "DodajZestaw";
            this.buttonAddZestaw.UseVisualStyleBackColor = true;
            this.buttonAddZestaw.Click += new System.EventHandler(this.buttonAddZestaw_Click);
            // 
            // buttonDelZestaw
            // 
            this.buttonDelZestaw.Location = new System.Drawing.Point(227, 361);
            this.buttonDelZestaw.Name = "buttonDelZestaw";
            this.buttonDelZestaw.Size = new System.Drawing.Size(128, 23);
            this.buttonDelZestaw.TabIndex = 9;
            this.buttonDelZestaw.Text = "UsuńZestaw";
            this.buttonDelZestaw.UseVisualStyleBackColor = true;
            this.buttonDelZestaw.Click += new System.EventHandler(this.buttonDelZestaw_Click);
            // 
            // buttonAddToPack
            // 
            this.buttonAddToPack.Location = new System.Drawing.Point(51, 567);
            this.buttonAddToPack.Name = "buttonAddToPack";
            this.buttonAddToPack.Size = new System.Drawing.Size(128, 23);
            this.buttonAddToPack.TabIndex = 10;
            this.buttonAddToPack.Text = "DodajDoPaczki";
            this.buttonAddToPack.UseVisualStyleBackColor = true;
            this.buttonAddToPack.Click += new System.EventHandler(this.buttonAddToPack_Click);
            // 
            // AddProdukt
            // 
            this.AddProdukt.Location = new System.Drawing.Point(542, 506);
            this.AddProdukt.Name = "AddProdukt";
            this.AddProdukt.Size = new System.Drawing.Size(128, 23);
            this.AddProdukt.TabIndex = 11;
            this.AddProdukt.Text = "DodajProdukt";
            this.AddProdukt.UseVisualStyleBackColor = true;
            this.AddProdukt.Click += new System.EventHandler(this.AddProdukt_Click);
            // 
            // ManagmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = this.Size;
            this.Controls.Add(this.AddProdukt);
            this.Controls.Add(this.buttonAddToPack);
            this.Controls.Add(this.buttonDelZestaw);
            this.Controls.Add(this.buttonAddZestaw);
            this.Name = "ManagmentPanel";
            this.Text = "ManagmentPanel";
            this.Load += new System.EventHandler(this.ManagmentPanel_Load);
            this.Controls.SetChildIndex(this.buttonPowrot, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonAddZestaw, 0);
            this.Controls.SetChildIndex(this.buttonDelZestaw, 0);
            this.Controls.SetChildIndex(this.buttonAddToPack, 0);
            this.Controls.SetChildIndex(this.AddProdukt, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddZestaw;
        private System.Windows.Forms.Button buttonDelZestaw;
        private System.Windows.Forms.Button buttonAddToPack;
        private System.Windows.Forms.Button AddProdukt;
    }
}