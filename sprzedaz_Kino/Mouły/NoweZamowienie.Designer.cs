namespace sprzedaz_Kino.Mouły
{
    partial class NoweZamowienie
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
            this.buttonZesDoZam = new System.Windows.Forms.Button();
            this.buttonClearOrder = new System.Windows.Forms.Button();
            this.labelSuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonZesDoZam
            // 
            this.buttonZesDoZam.Location = new System.Drawing.Point(404, 146);
            this.buttonZesDoZam.Name = "buttonZesDoZam";
            this.buttonZesDoZam.Size = new System.Drawing.Size(97, 23);
            this.buttonZesDoZam.TabIndex = 8;
            this.buttonZesDoZam.Text = "---->";
            this.buttonZesDoZam.UseVisualStyleBackColor = true;
            this.buttonZesDoZam.Click += new System.EventHandler(this.buttonZesDoZam_Click);
            // 
            // buttonClearOrder
            // 
            this.buttonClearOrder.Location = new System.Drawing.Point(404, 195);
            this.buttonClearOrder.Name = "buttonClearOrder";
            this.buttonClearOrder.Size = new System.Drawing.Size(97, 23);
            this.buttonClearOrder.TabIndex = 9;
            this.buttonClearOrder.Text = "<----";
            this.buttonClearOrder.UseVisualStyleBackColor = true;
            this.buttonClearOrder.Click += new System.EventHandler(this.buttonClearOrder_Click);
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Location = new System.Drawing.Point(789, 513);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(70, 13);
            this.labelSuma.TabIndex = 10;
            this.labelSuma.Text = "Suma: 0,00zł";
            // 
            // NoweZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = this.Size;
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.buttonClearOrder);
            this.Controls.Add(this.buttonZesDoZam);
            this.Name = "NoweZamowienie";
            this.Text = "NoweZamowienie";
            this.Load += new System.EventHandler(this.NoweZamowienie_Load);
            this.Controls.SetChildIndex(this.buttonPowrot, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonZesDoZam, 0);
            this.Controls.SetChildIndex(this.buttonClearOrder, 0);
            this.Controls.SetChildIndex(this.labelSuma, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZesDoZam;
        private System.Windows.Forms.Button buttonClearOrder;
        private System.Windows.Forms.Label labelSuma;
    }
}