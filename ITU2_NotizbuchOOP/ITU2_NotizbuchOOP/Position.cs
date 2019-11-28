using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Position
    {
        private Produkt produkt;
        private int anzahl;

        public int Anzahl { get => anzahl; set => anzahl = value; }
        public Produkt Produkt { get => produkt; set => produkt = value; }

        public double GetGesamtpreis()
        {
            return anzahl * produkt.Preis;
        }
    }
}
