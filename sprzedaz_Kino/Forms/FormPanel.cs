using sprzedaz_Kino.SalesComponents;
using sprzedaz_Kino.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprzedaz_Kino
{
    public partial class FormPanel : Form
    {
        public FormPanel()
        {
            InitializeComponent();
        }

        private void FormNoweZamowienie_Load(object sender, EventArgs e)
        {
            DgvRefresh();
        }

        private void buttonZestawDoZamowienia_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsunZamowienie_Click(object sender, EventArgs e)
        {

        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {

        }
        private void FormNoweZamowienie_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anulowanie", "Czy napewno chcesz anulować ?" , MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void dataGridViewProdukt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewZestaw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProdukt.Rows.Clear();
            foreach (ProdZes prodZestaw in ((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag).ListaProdZes)
            {
                SalesSqlTools.SqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.produkt WHERE produkt_id=" + prodZestaw.ProduktId + ";", SalesSqlTools.SqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                int x = dataGridViewProdukt.Rows.Add(sqlDataReader[1], sqlDataReader[2], prodZestaw[3]);
                dataGridViewProdukt.Rows[x].Tag = prodZestaw;
                SalesSqlTools.SqlConnection.Close();
            }
        }
        protected void DgvRefresh()
        {
            dataGridViewZestaw.Rows.Clear();
            SalesSqlTools.SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.zestaw;", SalesSqlTools.SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Zestaw zestaw = new Zestaw((int)sqlDataReader[0], (string)sqlDataReader[1], (decimal)sqlDataReader[2]);
                int x = dataGridViewZestaw.Rows.Add(zestaw[1], zestaw[2]);
                dataGridViewZestaw.Rows[x].Tag = zestaw;
            }
            SalesSqlTools.SqlConnection.Close();
            foreach (DataGridViewRow row in dataGridViewZestaw.Rows)
            {
                SalesSqlTools.SqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM prod_zes WHERE prod_zes.zestaw_id =" + ((Zestaw)row.Tag)[0] + ";", SalesSqlTools.SqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ProdZes prodZes = new ProdZes((int)sqlDataReader[0], (int)sqlDataReader[1], (int)sqlDataReader[2], (int)sqlDataReader[3]);
                    ((Zestaw)row.Tag).AddProdZes(prodZes);
                }
                SalesSqlTools.SqlConnection.Close();
            }
            dataGridViewProdukt.Rows.Clear();
        }

        public virtual void dataGridViewZamowienie_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
