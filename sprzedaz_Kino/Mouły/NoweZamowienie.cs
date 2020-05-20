using sprzedaz_Kino.Forms;
using sprzedaz_Kino.SalesComponents;
using sprzedaz_Kino.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino.Mouły
{
    public partial class NoweZamowienie : FormPanel
    {
        int idPracownika;
        public NoweZamowienie(int idPracownika)
        {
            InitializeComponent();
            this.idPracownika = idPracownika;
        }

        private void NoweZamowienie_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            dataGridViewZamowienie.Rows.Remove(dataGridViewZamowienie.SelectedRows[0]);
            ObliczSume();
        }

        private void buttonZesDoZam_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage("Podaj ilość zestawów");
            int x = (int)formMessage.ReturnInt();
            if (x == 0)
            {
                return;
            }
            dataGridViewZamowienie.Rows.Add(((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag)[1], ((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag)[2], x);
            WyswietlSume();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {/*
            if (dataGridViewZamowienie.Rows.Count < 1)
            {
                MessageBox.Show("Lista Sprzedaży nie może być pusta","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sprzedaz sprzedaz = new Sprzedaz();
            sprzedaz.PracownikId = idPracownika;
            sprzedaz.Cena = ObliczSume();
            foreach (DataGridViewRow row in dataGridViewZamowienie.Rows)
            {
                ZesSprz zesSprz = new ZesSprz();
                zesSprz.ZestawId =
            }*/
        }
        private void WyswietlSume()
        {
            decimal temp = ObliczSume();
            labelSuma.Text = "Suma: " + temp.ToString() + " zł";
        }
        private decimal ObliczSume()
        {
            decimal temp = 0.00m;
            foreach (DataGridViewRow row in dataGridViewZamowienie.Rows)
            {
                temp += ((decimal)row.Cells[1].Value * (int)row.Cells[2].Value);
            }
            return temp;
        }
    }
}
