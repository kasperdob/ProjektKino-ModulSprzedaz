using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprzedaz_Kino.SalesComponents
{
    class Sprzedaz
    {
        int id;
        int pracownikId;
        DateTime dataSprz;
        decimal cena;
        decimal upust;
        object[] tablica;
        List<ZesSprz> listaZesSprz = new List<ZesSprz>();

        public Sprzedaz(int id, int pracownikId, DateTime dataSprz, decimal cena, decimal upust)
        {
            this.id = id;
            this.pracownikId = pracownikId;
            this.dataSprz = dataSprz;
            this.cena = cena;
            this.upust = upust;
            tablica = new object[] { this.id, this.pracownikId, this.dataSprz, this.cena, this.upust };
        }

        public Sprzedaz()
        {
            pracownikId = 0;
            dataSprz = DateTime.Now;
            cena = 0;
            upust = 0;
            tablica = new object[] { this.id, this.pracownikId, this.dataSprz, this.cena, this.upust };
        }

        public object this[int index]
        {
            get { return tablica[index]; }
        }
        public object[] Tablica { get => tablica; }
        public int PracownikId { get => pracownikId; set => pracownikId = value; }
        public DateTime DataSprz { get => dataSprz; set => dataSprz = value; }
        public decimal Cena { get => cena; set => cena = value; }
        public decimal Upust { get => upust; set => upust = value; }
        public int Id { get => id; set => id = value; }
        internal List<ZesSprz> ListaZesSprz { get => listaZesSprz; set => listaZesSprz = value; }
    }
}
