using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Notiz
    {
        private string titel;
        private int prio;
        private string kategorie;
        private string text;
        private DateTime erstellDatum;
        private DateTime deadLine;

        public void setTitle(string p_titel)
        {
            titel = p_titel;
        }

        public void setPrio(int p_prio)
        {
            prio = p_prio;
        }

        public void setKategorie(string p_kategorie)
        {
            kategorie = p_kategorie;
        }

        public void setText(string p_text)
        {
            text = p_text;
        }

        public void setErstellDatum(DateTime p_erstellDatum)
        {
            erstellDatum = p_erstellDatum;

        }

        public void setDeadLine(DateTime p_deadLine)
        {
            deadLine = p_deadLine;
        }

        /**
        public Notiz(
                string titel,
                int prio,
                string kategorie,
                string text,
                DateTime erstellDatum,
                DateTime deadLine
            )
        {
            this.titel = titel;
            this.prio = prio;
            this.kategorie = kategorie;
            this.text = text;
            this.erstellDatum = erstellDatum;
            this.deadLine = deadLine;
            
        }
         *
         */
    }
}
