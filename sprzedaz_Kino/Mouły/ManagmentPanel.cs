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
    public partial class ManagmentPanel : FormPanel
    {
        public ManagmentPanel()
        {
            InitializeComponent();
        }

        private void ManagmentPanel_Load(object sender, EventArgs e)
        {
            DgvRefresh();
            Dgv2Refresh();
            CLERA();
        }

        private void AddProdukt_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt();
            FormProdukt formProdukt = new FormProdukt(produkt);
            if (formProdukt.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            SalesSqlTools.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.SalesSqlTools.SqlConnection;
            cmd.CommandText = "INSERT INTO dbo.produkt(cena,nazwa,ilosc)values(@Cena, @Nazwa, @Ilosc);";
            cmd.Parameters.Add(new SqlParameter("@Cena", produkt.Cena));
            cmd.Parameters.Add(new SqlParameter("@Nazwa", produkt.Nazwa));
            cmd.Parameters.Add(new SqlParameter("@Ilosc", produkt.Ilosc));
            cmd.ExecuteNonQuery();
            SalesSqlTools.SqlConnection.Close();
            Dgv2Refresh();
        }
        void Dgv2Refresh() {
            dataGridViewZamowienie.Rows.Clear();
            SalesSqlTools.SqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.produkt;", SalesSqlTools.SqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Produkt produkt = new Produkt((int)sqlDataReader[0], (string)sqlDataReader[1], (decimal)sqlDataReader[2], (int)sqlDataReader[3]);
                int x = dataGridViewZamowienie.Rows.Add(produkt[1], produkt[2], produkt[3]);
                dataGridViewZamowienie.Rows[x].Tag = produkt;
            }
            SalesSqlTools.SqlConnection.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToPack_Click(object sender, EventArgs e)
        {
            if (dataGridViewZamowienie.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze zaznaczyć produkty", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridViewZestaw.SelectedRows.Count != 1)
            {
                MessageBox.Show("Prosze zaznaczyć jeden zestaw", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dataGridViewZamowienie.SelectedRows)
            {
                FormMessage formMessage = new FormMessage("Proszę podać ilość prduktu: " + ((Produkt)row.Tag).Nazwa + "");
                int x = (int)formMessage.ReturnInt();
                if (x == 0)
                {
                    return;
                }
                ProdZes prodZes = new ProdZes(((Produkt)row.Tag).Id,((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag).Id,x);
                SalesSqlTools.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tools.SalesSqlTools.SqlConnection;
                cmd.CommandText = "insert into prod_zes values (@Produkt_Id, @Zestaw_Id, @Ilosc); update zestaw set cena = cena + @Cena where zestaw_id = @Zestaw_Id; ";
                cmd.Parameters.Add(new SqlParameter("@Produkt_Id", prodZes.ProduktId));
                cmd.Parameters.Add(new SqlParameter("@Zestaw_Id", prodZes.ZestawId));
                cmd.Parameters.Add(new SqlParameter("@Ilosc", prodZes.Ilosc));
                cmd.Parameters.Add(new SqlParameter("@Cena", (((Produkt)row.Tag).Cena * prodZes.Ilosc)));
                cmd.ExecuteNonQuery();
                SalesSqlTools.SqlConnection.Close(); 
            }
            DgvRefresh();
        }

        private void buttonAddZestaw_Click(object sender, EventArgs e)
        {
            Zestaw zestaw = new Zestaw();
            FormMessage formMessage = new FormMessage("Podaj nazwę zestawu");
            string x = formMessage.ReturnString();
            if (string.IsNullOrWhiteSpace(x) == true)
            {
                return;
            }
            zestaw.Nazwa = x; 
            SalesSqlTools.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.SalesSqlTools.SqlConnection;
            cmd.CommandText = "insert into zestaw values (@Nazwa, @Cena); ";
            cmd.Parameters.Add(new SqlParameter("@Cena", zestaw.Cena));
            cmd.Parameters.Add(new SqlParameter("@Nazwa", zestaw.Nazwa));
            cmd.ExecuteNonQuery();
            SalesSqlTools.SqlConnection.Close();
            DgvRefresh();
        }
        public override void dataGridViewZamowienie_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewZamowienie.SelectedRows.Count != 1)
            {
                MessageBox.Show("Prosze zaznaczyć jeden produkt", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Produkt produkt = new Produkt();
            produkt = (Produkt)dataGridViewZamowienie.SelectedRows[0].Tag;
            FormProdukt form = new FormProdukt(produkt);
            if (form.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            SalesSqlTools.SqlConnection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.SalesSqlTools.SqlConnection;
            cmd.CommandText = "update produkt set nazwa = @Nazwa, cena = @Cena, ilosc = @Ilosc where produkt_id = @Id; ";
            cmd.Parameters.Add(new SqlParameter("@Cena", produkt.Cena));
            cmd.Parameters.Add(new SqlParameter("@Nazwa", produkt.Nazwa));
            cmd.Parameters.Add(new SqlParameter("@Ilosc", produkt.Ilosc));
            cmd.Parameters.Add(new SqlParameter("@Id", produkt.Id));
            cmd.ExecuteNonQuery();
            SalesSqlTools.SqlConnection.Close();
            Dgv2Refresh();

        }

        private void buttonDelZestaw_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno chcesz usunąć zestaw:" + ((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag).Nazwa + " ?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridViewZestaw.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Prosze zaznaczyć jeden Zestaw", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SalesSqlTools.SqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Tools.SalesSqlTools.SqlConnection;
                cmd.CommandText = "delete from prod_zes where zestaw_id = @Id; delete from zestaw where zestaw_id = @Id;";
                cmd.Parameters.Add(new SqlParameter("@Id", ((Zestaw)dataGridViewZestaw.SelectedRows[0].Tag).Id));
                cmd.ExecuteNonQuery();
                SalesSqlTools.SqlConnection.Close();
                DgvRefresh();
                return;
            }

        }
    }
}
