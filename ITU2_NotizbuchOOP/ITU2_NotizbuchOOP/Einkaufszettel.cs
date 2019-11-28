using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Einkaufszettel
    {
        private List<Position> eintraege;

        public List<Position> Eintraege { get => eintraege; set => eintraege = value; }

        public Einkaufszettel()
        {
            eintraege = new List<Position>();
        }

        public Position GetPosition(int index)
        {
            if (index < 0 || index >= eintraege.Count)
            {
                return null;
            }
            else
            {
                return eintraege[index];
            }
        }

        // Fügt die position hinzu, wenn Produkt bereits vorhanden wird Anzahl erhöht
        public void AddPosition(Position position)
        {
            bool produktVorhanden = false;
            for (int i = 0; i < eintraege.Count; i++)
            {
                if (produktVorhanden)
                {
                    break;
                }

                if (eintraege[i].Produkt == position.Produkt)
                {
                    eintraege[i].Anzahl += position.Anzahl;
                    produktVorhanden = true;
                }
            }

            if (!produktVorhanden)
            {
                eintraege.Add(position);
            }
        }
    }
}
