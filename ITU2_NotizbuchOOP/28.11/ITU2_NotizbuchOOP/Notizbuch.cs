using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITU2_NotizbuchOOP
{
    class Notizbuch
    {
        private string titel;
        private List<Notiz> notizen = new List<Notiz>();
        private List<Hausaufgabe> hausaufgaben = new List<Hausaufgabe>();
        private List<Einkaufszettel> einkaufszettel = new List<Einkaufszettel>();


        private List<string> kategorien = new List<string>();
        private List<Produkt> produkte = new List<Produkt>();

        public string Titel { get => titel; set => titel = value; }
        public List<Notiz> Notizen { get => notizen; }
        public List<Hausaufgabe> Hausaufgaben { get => hausaufgaben; }
        public List<Einkaufszettel> Einkaufszettel { get => einkaufszettel; }

        public List<string> Kategorien { get => kategorien; set => kategorien = value; }
        internal List<Produkt> Produkte { get => produkte; set => produkte = value; }


        public Notizbuch(string titel)
        {
            this.titel = titel;
            kategorien.AddRange(new string[] { "Kategorie 1", "kategorie 2", "Kategorie 3" });
        }

        public void NotizErstellenUndSpeichern(string p_titel, int p_prioritaet, string p_kategorie, DateTime p_deadline, string p_inhalt)
        {
            //neues Notiz-Objekt erstellen, unveränderlichen Titel festlegen
            Notiz neueNotiz = new Notiz(p_titel, p_prioritaet, p_kategorie, p_deadline, p_inhalt);
            NotizSpeichern(neueNotiz);
        }

        public bool ExistiertNotiz(string titel)
        {
            // Als Kriterium wird Titel verwendet
            for (int i = 0; i < notizen.Count; i++)
            {
                if (titel == notizen[i].Titel)
                {
                    return true;
                }
            }
            return false;
        }

        public void NotizSpeichern(Notiz notiz)
        {
            // Überschreibt oder legt neuen Eintrag in Liste an
            for (int i = 0; i < notizen.Count; i++)
            {
                if (notiz.Titel == notizen[i].Titel)
                {
                    notizen[i] = notiz;
                    return;
                }
            }
            notizen.Add(notiz);
        }
    }
}
