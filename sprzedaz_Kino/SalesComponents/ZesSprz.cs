using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprzedaz_Kino.SalesComponents
{
    class ZesSprz
    {
        int id;
        int zestawId;
        int sprzedazId;
        int ilosc;
        object[] tablica;

        public ZesSprz(int id , int zestawId, int sprzedazId, int ilosc)
        {
            this.id = id;
            this.zestawId = zestawId;
            this.sprzedazId = sprzedazId;
            this.ilosc = ilosc;
            tablica = new object[] { id, this.zestawId, this.sprzedazId, this.ilosc };
        }
        public ZesSprz()
        {
            sprzedazId = 0;
            ilosc = 0;
            tablica = new object[] {id, zestawId, sprzedazId, ilosc };
        }
        public object this[int index]
        {
            get { return tablica[index]; }
        }
        public object[] Tablica { get => tablica; }
        public int ZestawId { get => zestawId; set => zestawId = value; }
        public int SprzedazId { get => sprzedazId; set => sprzedazId = value; }
        public int Ilosc { get => ilosc; set => ilosc = value; }
        public int Id { get => id; set => id = value; }
    }
}
