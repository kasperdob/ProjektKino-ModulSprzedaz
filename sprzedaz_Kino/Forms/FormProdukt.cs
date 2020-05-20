using sprzedaz_Kino.SalesComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino
{
    internal partial class FormProdukt : Form
    {
        Produkt produkt;
        public FormProdukt(Produkt produkt)
        {
            InitializeComponent();
            this.produkt = produkt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produkt.Ilosc = (int)numericUpDown1.Value;
            produkt.Cena = numericUpDown2.Value;
            produkt.Nazwa = textBox1.Text;
            DialogResult = DialogResult.OK;
        }

        private void FormProdukt_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = produkt.Ilosc;
            numericUpDown2.Value = produkt.Cena;
            textBox1.Text = produkt.Nazwa;
        }
    }
}
