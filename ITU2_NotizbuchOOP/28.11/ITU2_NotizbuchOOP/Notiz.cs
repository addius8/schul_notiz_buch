using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    public class Notiz
    {
        private string titel; //Titel soll nur im Konstruktor festgelegt werden können
        private DateTime erstelldatum;
        private int prioritaet;
        private string kategorie;
        private DateTime deadline;
        private string inhalt;

        public string Titel { get => titel; }
        public DateTime Erstelldatum { get => erstelldatum; }
        public int Prioritaet { get => prioritaet; set => prioritaet = value; }
        public string Kategorie { get => kategorie; set => kategorie = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public string Inhalt { get => inhalt; set => inhalt = value; }

        //Konstruktor
        public Notiz(string titel)
        {
            this.titel = titel;
            this.erstelldatum = DateTime.Now;
        }

        public Notiz(string titel, int prioritaet, string kategorie, DateTime deadline, string inhalt)
        {
            this.titel = titel;
            this.erstelldatum = DateTime.Now;
            this.prioritaet = prioritaet;
            this.kategorie = kategorie;
            this.deadline = deadline;
            this.inhalt = inhalt;
        }
    }
}
