using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprzedaz_Kino.SalesComponents
{
    class ProdZes
    {
        int id;
        int produktId;
        int zestawId;
        int ilosc;
        object[] tablica;
        
        public ProdZes(int id, int produktId, int zestawId, int ilosc)
        {
            this.id = id;
            this.produktId = produktId;
            this.zestawId = zestawId;
            this.ilosc = ilosc;
            tablica = new object[] {id, this.produktId, this.zestawId, this.ilosc };
        }
        public ProdZes( int produktId, int zestawId, int ilosc)
        {
            this.produktId = produktId;
            this.zestawId = zestawId;
            this.ilosc = ilosc;
            tablica = new object[] { id, this.produktId, this.zestawId, this.ilosc };
        }

        public object this[int index]
        {
            get { return tablica[index]; }
        }
        public object[] Tablica { get => tablica; }
        public int ProduktId { get => produktId; set => produktId = value; }
        public int ZestawId { get => zestawId; set => zestawId = value; }
        public int Ilosc { get => ilosc; set => ilosc = value; }
        public int Id { get => id; set => id = value; }
    }
}
