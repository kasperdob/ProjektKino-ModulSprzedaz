namespace sprzedaz_Kino
{
    partial class FormPanel
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
            this.dataGridViewZestaw = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewZamowienie = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProdukt = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZestaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZestaw
            // 
            this.dataGridViewZestaw.AllowUserToAddRows = false;
            this.dataGridViewZestaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZestaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewZestaw.Location = new System.Drawing.Point(51, 45);
            this.dataGridViewZestaw.MultiSelect = false;
            this.dataGridViewZestaw.Name = "dataGridViewZestaw";
            this.dataGridViewZestaw.RowHeadersVisible = false;
            this.dataGridViewZestaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZestaw.Size = new System.Drawing.Size(304, 310);
            this.dataGridViewZestaw.TabIndex = 0;
            this.dataGridViewZestaw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewZestaw_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nazwa";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cena";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewZamowienie
            // 
            this.dataGridViewZamowienie.AllowUserToAddRows = false;
            this.dataGridViewZamowienie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZamowienie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column7});
            this.dataGridViewZamowienie.Location = new System.Drawing.Point(542, 45);
            this.dataGridViewZamowienie.Name = "dataGridViewZamowienie";
            this.dataGridViewZamowienie.RowHeadersVisible = false;
            this.dataGridViewZamowienie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZamowienie.Size = new System.Drawing.Size(317, 455);
            this.dataGridViewZamowienie.TabIndex = 1;
            this.dataGridViewZamowienie.DoubleClick += new System.EventHandler(this.dataGridViewZamowienie_DoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NazwaProduktu";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cena";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ilość";
            this.Column7.Name = "Column7";
            // 
            // dataGridViewProdukt
            // 
            this.dataGridViewProdukt.AllowUserToAddRows = false;
            this.dataGridViewProdukt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdukt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridViewProdukt.Location = new System.Drawing.Point(51, 407);
            this.dataGridViewProdukt.Name = "dataGridViewProdukt";
            this.dataGridViewProdukt.RowHeadersVisible = false;
            this.dataGridViewProdukt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdukt.Size = new System.Drawing.Size(304, 154);
            this.dataGridViewProdukt.TabIndex = 2;
            this.dataGridViewProdukt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdukt_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NazwaProduktu";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cena";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ilość";
            this.Column4.Name = "Column4";
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(51, 12);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(85, 27);
            this.buttonPowrot.TabIndex = 3;
            this.buttonPowrot.Text = "powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(542, 556);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(719, 555);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(139, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 600);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.dataGridViewProdukt);
            this.Controls.Add(this.dataGridViewZamowienie);
            this.Controls.Add(this.dataGridViewZestaw);
            this.Name = "FormPanel";
            this.Text = "FormNoweZamowienie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNoweZamowienie_FormClosing);
            this.Load += new System.EventHandler(this.FormNoweZamowienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZestaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button buttonPowrot;
        protected System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.DataGridView dataGridViewZestaw;
        protected System.Windows.Forms.DataGridView dataGridViewProdukt;
        protected System.Windows.Forms.DataGridView dataGridViewZamowienie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}