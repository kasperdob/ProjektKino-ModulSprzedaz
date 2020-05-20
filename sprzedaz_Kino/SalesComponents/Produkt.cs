using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprzedaz_Kino.SalesComponents
{
    class Produkt
    {
        int id;
        string nazwa;
        decimal cena;
        int ilosc;
        object[] tablica;

        public Produkt(int id, string nazwa, decimal cena, int ilosc)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
            tablica = new object[] { id, this.nazwa, this.cena, this.ilosc };
        }
        public Produkt()
        {
            nazwa = string.Empty;
            cena = 0.00m;
            ilosc = 0;
            tablica = new object[] { Id, this.nazwa, this.cena, this.ilosc };
        }
        public object this[int index]
        {
            get { return tablica[index]; }
        }
        public object[] Tablica { get => tablica; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public decimal Cena { get => cena; set => cena = value; }
        public int Ilosc { get => ilosc; set => ilosc = value; }
        public int Id { get => id; set => id = value; }
    }
}
