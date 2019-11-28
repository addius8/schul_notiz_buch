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
        // private ArrayList notizen;
        private List<Notiz> notizen;
        private string titel;


        /**
         * 
         */
        public void notizHinzufuegen(
            string      p_titel,
            DateTime    p_erstellDatum,
            int         p_prio,
            string      p_kategorie,
            string      p_text,
            DateTime    p_deadLine
            )
        {
            Notiz einNeuesNotizObjet = new Notiz();
            einNeuesNotizObjet.setTitle(p_titel);
            einNeuesNotizObjet.setErstellDatum(p_erstellDatum);
            einNeuesNotizObjet.setPrio(p_prio);
            einNeuesNotizObjet.setKategorie(p_kategorie);
            einNeuesNotizObjet.setText(p_text);
            einNeuesNotizObjet.setDeadLine(p_deadLine);

            // speicdhern des neuen Objekts
            notizen.Add(einNeuesNotizObjet);
            

        }
    }
}
