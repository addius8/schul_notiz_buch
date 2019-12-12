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
		public string Titel { get => titel; set => titel = value; }

		private List<Notiz> notizen = new List<Notiz>();
        private List<Hausaufgabe> hausaufgaben = new List<Hausaufgabe>();
        private List<Einkaufszettel> einkaufszettel = new List<Einkaufszettel>();
		public List<Notiz> Notizen { get => notizen; }
		public List<Hausaufgabe> Hausaufgaben { get => hausaufgaben; }
		public List<Einkaufszettel> Einkaufszettel { get => einkaufszettel; }

		private List<string> kategorien = new List<string>();
        private List<Produkt> produkte = new List<Produkt>();
        private List<string> faecher = new List<string>();
        public List<string> Kategorien { get => kategorien; set => kategorien = value; }
        internal List<Produkt> Produkte { get => produkte; set => produkte = value; }
        public List<string> Faecher { get => faecher; set => faecher = value; }

        #region Allgemein
        public Notizbuch(string titel)
        {
            this.titel = titel;
            kategorien.AddRange(new string[] { "To-Do", "Information", "Aufgabe", "Idee", "Ereignis" });
            faecher.AddRange(new string[] { "Mathematik", "Physik", "Biologie", "Chemie", "Englisch", "Deutsch", "Politik" });
        }
        #endregion

        #region Notizen
        public void NotizDatenSpeichern(Notiz notiz)
		{
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

		public void NotizDatenSpeichern(string p_titel, int p_prioritaet, string p_kategorie, DateTime p_deadline, string p_inhalt)
        {
            Notiz neueNotiz = new Notiz(p_titel, p_prioritaet, p_kategorie, p_deadline, p_inhalt);
            NotizDatenSpeichern(neueNotiz);
        }

		public void NotizLoeschen(int index)
		{
			if (index >= 0 && index < notizen.Count)
			{
				notizen.RemoveAt(index);
			}
		}

		public void NotizLoeschen(Notiz notiz)
		{
			for (int i = 0; i < notizen.Count; i++)
			{
				if (notiz.Titel == notizen[i].Titel)
				{
					notizen.RemoveAt(i);
					return;
				}
			}
		}

		public List<Notiz> NotizenSuchen(int prio)
		{
			List<Notiz> gefunden = new List<Notiz>();
			for (int i = 0; i < notizen.Count; i++)
			{
				if (notizen[i].Prioritaet == prio)
				{
					gefunden.Add(notizen[i]);
				}
			}
			return gefunden;
		}

        public bool NotizExistiert(string titel)
        {
            for (int i = 0; i < notizen.Count; i++)
            {
                if (titel == notizen[i].Titel)
                {
                    return true;
                }
            }
            return false;
        }

		public bool NotizExistiert(Notiz notiz)
		{
			return NotizExistiert(notiz.Titel);
		}
		#endregion

		#region Hausaufgaben
        public void HausaufgabeDatenSpeichern(Hausaufgabe hausaufgabe)
        {
            for (int i = 0; i < hausaufgaben.Count; i++)
            {
                if (hausaufgabe.Titel == hausaufgaben[i].Titel)
                {
                    hausaufgaben[i] = hausaufgabe;
                    return;
                }
            }
            hausaufgaben.Add(hausaufgabe);
        }

        public void HausaufgabeDatenSpeichern(string titel, string fach, string aufgabe, DateTime deadline)
        {
            Hausaufgabe neueHA = new Hausaufgabe(titel, fach, aufgabe, deadline);
            HausaufgabeDatenSpeichern(neueHA);
        }

        public void HausaufgabeLoeschen(int index)
        {
            if (index >= 0 && index < hausaufgaben.Count)
            {
                hausaufgaben.RemoveAt(index);
            }
        }

        public void HausaufgabeLoeschen(Hausaufgabe hausaufgabe)
        {
            for (int i = 0; i < hausaufgaben.Count; i++)
            {
                if (hausaufgabe.Titel == hausaufgaben[i].Titel)
                {
                    hausaufgaben.RemoveAt(i);
                    return;
                }
            }
        }

        public bool HausaufgabeExistiert(string titel)
        {
            for (int i = 0; i < hausaufgaben.Count; i++)
            {
                if (titel == hausaufgaben[i].Titel)
                {
                    return true;
                }
            }
            return false;
        }

        public bool HausaufgabeExistiert(Hausaufgabe hausaufgabe)
        {
            return HausaufgabeExistiert(hausaufgabe.Titel);
        }

        public List<Hausaufgabe> HausaufgabenSuchen(string fachFilter)
        {
            List<Hausaufgabe> gefunden = new List<Hausaufgabe>();
            for (int i = 0; i < hausaufgaben.Count; i++)
            {
                if (hausaufgaben[i].Fach == fachFilter)
                {
                    gefunden.Add(hausaufgaben[i]);
                }
            }
            return gefunden;
        }
        #endregion

        #region Einkaufszettel
        #endregion
    }
}
