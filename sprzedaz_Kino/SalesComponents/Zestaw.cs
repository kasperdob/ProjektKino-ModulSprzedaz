using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprzedaz_Kino.SalesComponents
{
    class Zestaw
    {
        int id;
        string nazwa;
        decimal cena;
        List<ProdZes> listaProdZes = new List<ProdZes>();
        object[] tablica;

        public object[] Tablica { get => tablica; }
        public int Id { get => id; set => id = value; }
        public string Nazwa { get => nazwa; set => nazwa = value; }
        public decimal Cena { get => cena; set => cena = value; }
        internal List<ProdZes> ListaProdZes { get => listaProdZes; set => listaProdZes = value; }

        public Zestaw(int id, string nazwa, decimal cena)
        {
            this.id = id;
            this.nazwa = nazwa;
            this.cena = cena;
            tablica = new object[] { id, this.Nazwa, this.Cena };
        }
        public Zestaw()
        {
            nazwa = string.Empty;
            cena = 0.00m;
            tablica = new object[] { id, this.Nazwa, this.Cena };
        }

        public object this[int index]
        {
            get { return tablica[index]; }
        }


        public void AddProdZes(ProdZes prodZes)
        {
            listaProdZes.Add(prodZes);
        }
        public void RemoveProdZes(ProdZes prodZes)
        {
            listaProdZes.Remove(prodZes);
        }
        
    }
}
