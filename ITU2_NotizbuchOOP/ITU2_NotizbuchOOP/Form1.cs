using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU2_NotizbuchOOP
{
    public partial class Form1 : Form
    {
        Notizbuch notizbuch;
        public Form1()
        {
            InitializeComponent();

            notizbuch = new Notizbuch("Ein Notizbuch");

            txtErstelldatum.Text = DateTime.Now.ToShortDateString();

            KategorienSync();

            FaecherSync();
        }

        #region Notizen
        private void NotizenSync()
        {
			List<Notiz> tempNotizen = new List<Notiz>();
			if (cboxFiltern.Checked)
			{
				int prioFilter = (int)numPrioSuche.Value;
				tempNotizen = notizbuch.NotizenSuchen(prioFilter);
			} 
			else
			{
				tempNotizen = notizbuch.Notizen;
			}

            
            lstbNotizen.Items.Clear();
            foreach (Notiz notiz in tempNotizen)
            {
                lstbNotizen.Items.Add(notiz.Titel);
            }
        }

        private void KategorienSync()
        {
            drpDwnKategorie.Items.Clear();
            drpDwnKategorie.Items.AddRange(notizbuch.Kategorien);
            drpDwnKategorie.SelectedIndex = 0;
        }

        private void NotizSpeichern()
        {

            if (txtTitel.Text == "")
            {
				MessageBox.Show("Bitte einen Titel angeben.", "Fehler", MessageBoxButtons.OK);
                Console.WriteLine("ERROR: Title can't be empty.");
                return;
            }

            string titel = txtTitel.Text;
            int prio = (int)numPrioritaet.Value;
			string kategorie = drpDwnKategorie.Text;
			if (txtKategorie.Text != "")
			{
				string neueKategorie = txtKategorie.Text;
				if (!notizbuch.Kategorien.Contains(neueKategorie))
				{
					kategorie = neueKategorie;
					notizbuch.Kategorien.Add(neueKategorie);
					KategorienSync();
					drpDwnKategorie.SelectedIndex = notizbuch.Kategorien.IndexOf(neueKategorie);
				}
   }
			DateTime deadline = dateDeadline.Value;
            string inhalt = txtInhalt.Text;

			Notiz neueNotiz = new Notiz(titel, prio, kategorie, deadline, inhalt);

			bool confirmed;
			if (notizbuch.NotizExistiert(neueNotiz))
			{
				confirmed = MessageBox.Show("Notiz mit diesem Titel existiert bereits. Überschreiben?", "Notiz überschreiben", MessageBoxButtons.OKCancel) == DialogResult.OK ? true : false;
			} else
			{
				confirmed = true;
				//confirmed = MessageBox.Show("Soll eine neue Notiz angelegt werden?", "Neue Notiz anlegen", MessageBoxButtons.OKCancel) == DialogResult.OK ? true : false;
			}
			
			if (confirmed)
			{
				notizbuch.NotizDatenSpeichern(neueNotiz);

				NotizenSync();
			}
            else
			{
				return;
			}
        }

        public void NotizAnzeigen(Notiz notiz)
        {
            txtTitel.Text = notiz.Titel;
            txtErstelldatum.Text = notiz.Erstelldatum.ToShortDateString();
            numPrioritaet.Value = notiz.Prioritaet;
            drpDwnKategorie.Text = notiz.Kategorie;
            dateDeadline.Value = notiz.Deadline;
            txtInhalt.Text = notiz.Inhalt;
        }

		private void NotizLoeschen()
		{
			//TODO: need some sort of check to see if an item is actually selected, the index is always set to something
			int index = lstbNotizen.SelectedIndex;
			if (cboxFiltern.Checked)
			{
				Notiz zuLoeschen = notizbuch.NotizenSuchen((int)numPrioSuche.Value)[index];
				notizbuch.NotizLoeschen(zuLoeschen);
			}
			else
			{
				notizbuch.NotizLoeschen(index);
			}

			NotizenSync();
		}

        // EVENTS
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            NotizSpeichern();
        }
        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            Notiz ausgewaehlt = notizbuch.Notizen[lstbNotizen.SelectedIndex];
            NotizAnzeigen(ausgewaehlt);
        }
		private void btnLoeschen_Click(object sender, EventArgs e)
		{
			bool confirmed;
			confirmed = MessageBox.Show("Soll die ausgewählte Notiz gelöscht werden?", "Notiz löschen", MessageBoxButtons.OKCancel) == DialogResult.OK ? true : false;
			if (confirmed)
			{
				NotizLoeschen();
			}		
		}
		private void cboxFiltern_CheckedChanged(object sender, EventArgs e)
		{
			NotizenSync();
		}
		private void numPrioSuche_ValueChanged(object sender, EventArgs e)
		{
			if (cboxFiltern.Checked)
			{
				NotizenSync();
			}
		}
        #endregion

        #region Hausaufgaben
        private void HausaufgabenSync()
        {
            List<Hausaufgabe> tempHausaufgaben = new List<Hausaufgabe>();
            if (HAcheckFiltern.Checked)
            {
                string fachFilter = (string)HAcomboFilterFach.SelectedItem;
                tempHausaufgaben = notizbuch.HausaufgabenSuchen(fachFilter);
            }
            else
            {
                tempHausaufgaben = notizbuch.Hausaufgaben;
            }


            HAlistboxListe.Items.Clear();
            foreach (Hausaufgabe ha in tempHausaufgaben)
            {
                HAlistboxListe.Items.Add(ha.Titel);
            }
        }

        private void FaecherSync()
        {
            HAcomboFach.Items.Clear();
            HAcomboFilterFach.Items.Clear();
            for (int i = 0; i < notizbuch.Faecher.Count; i++)
            {
                HAcomboFach.Items.Add(notizbuch.Faecher[i]);
                HAcomboFilterFach.Items.Add(notizbuch.Faecher[i]);
            }
        }

        private void HausaufgabeSpeichern()
        {
            if (HAtxtTitel.Text == "")
            {
                MessageBox.Show("Bitte einen Titel angeben.", "Fehler", MessageBoxButtons.OK);
                return;
            }

            string titel = HAtxtTitel.Text;
            string fach = (string)HAcomboFach.SelectedItem;
            DateTime deadline = HAdateDeadline.Value;
            string aufgabe = HAtxtAufgabe.Text;

            //TODO: fächer neu etc behandeln

            string inhalt = txtInhalt.Text;

            Hausaufgabe neueHausaufgabe = new Hausaufgabe(titel, fach, aufgabe, deadline);

            bool confirmed;
            if (notizbuch.HausaufgabeExistiert(neueHausaufgabe))
            {
                confirmed = MessageBox.Show("Eine Hausaufgabe mit diesem Titel existiert bereits. Überschreiben?", "Hausaufgabe überschreiben", MessageBoxButtons.OKCancel) == DialogResult.OK ? true : false;
            }
            else
            {
                confirmed = true;
                //confirmed = MessageBox.Show("Soll eine neue Hausaufgabe angelegt werden?", "Neue Hausaufgabe anlegen", MessageBoxButtons.OKCancel) == DialogResult.OK ? true : false;
            }

            if (confirmed)
            {
                notizbuch.HausaufgabeDatenSpeichern(neueHausaufgabe);

                HausaufgabenSync();
            }
            else
            {
                return;
            }
        }
 
        private void HausaufgabeAnzeigen(Hausaufgabe hausaufgabe)
        {
            HAtxtTitel.Text = hausaufgabe.Titel;
            HAcomboFach.SelectedItem = notizbuch.Faecher.IndexOf(hausaufgabe.Fach);
            HAdateDeadline.Value = hausaufgabe.Deadline;
            HAtxtAufgabe.Text = hausaufgabe.Aufgabe;
        }

        private void HausaufgabeLoeschen()
        {
            int index = HAlistboxListe.SelectedIndex;
            if (HAcheckFiltern.Checked)
            {
                Hausaufgabe zuLoeschen = notizbuch.HausaufgabenSuchen((string)HAcomboFilterFach.SelectedItem)[index];
                notizbuch.HausaufgabeLoeschen(zuLoeschen);
            }
            else
            {
                notizbuch.HausaufgabeLoeschen(index);
            }

            HausaufgabenSync();
        }

        // EVENTS
        private void HAbtnSpeichern_Click(object sender, EventArgs e)
        {
            HausaufgabeSpeichern();
        }
        #endregion
    }
}
