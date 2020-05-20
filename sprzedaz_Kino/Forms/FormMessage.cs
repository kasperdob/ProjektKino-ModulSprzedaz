using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino.Forms
{
    public partial class FormMessage : Form
    {
        public FormMessage(string message)
        {
            InitializeComponent();
            labelText.Text = message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 || string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Proszę podać prawidłową wartość", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public int ReturnInt() 
        {
            numericUpDown1.Visible = true;
            ShowDialog();
            while (true)
            {
                if (DialogResult == DialogResult.OK)
                {
                    return (int)numericUpDown1.Value;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string ReturnString()
        {
            textBox1.Visible = true;
            ShowDialog();
            while (true)
            {
                if (DialogResult == DialogResult.OK)
                {
                    return textBox1.Text;
                }
                else
                {
                    return null;
                }
            }
        }


    }
}
