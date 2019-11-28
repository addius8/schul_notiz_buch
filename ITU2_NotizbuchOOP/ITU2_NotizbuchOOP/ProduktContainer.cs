using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class ProduktContainer
    {
        private List<Produkt> produkte;

        internal List<Produkt> Produkte { get => produkte; set => produkte = value; }

        public ProduktContainer()
        {
            produkte = new List<Produkt>();
        }
    }
}
