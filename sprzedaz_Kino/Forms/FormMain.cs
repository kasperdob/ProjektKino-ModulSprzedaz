using sprzedaz_Kino.Mouły;
using sprzedaz_Kino.SalesComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NoweZamowienie noweZamowienie = new NoweZamowienie((int)numericUpDownUprawnienie.Value);
            noweZamowienie.ShowDialog();
        }

        private void buttonManagmentPanel_Click(object sender, EventArgs e)
        {
            ManagmentPanel managmentPanel = new ManagmentPanel();
            managmentPanel.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                buttonManagmentPanel.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                buttonManagmentPanel.Enabled = false;
            }
        }
    }
}
