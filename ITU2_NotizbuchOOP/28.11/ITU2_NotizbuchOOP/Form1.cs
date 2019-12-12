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

            //TODO: kategorienliste füllen
            drpDwnKategorie.Items.Clear();
            drpDwnKategorie.Items.AddRange(notizbuch.Kategorien);

            drpDwnKategorie.SelectedIndex = 0;
        }

        private void NotizenSync()
        {
            List<Notiz> tempNotizen = notizbuch.Notizen;
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
            //Notizen mit gleichem Titel werden überspeichert
            //TODO: evt popup?

            if (txtTitel.Text == "")
            {
                //TODO: eine Fehlermeldung ausgeben
                Console.WriteLine("ERROR: Title can't be empty.");
                return;
            }

            string titel = txtTitel.Text;
            int prio = (int)numPrioritaet.Value;
            string kategorie = drpDwnKategorie.Text;
            DateTime deadline = dateDeadline.Value;
            string inhalt = txtInhalt.Text;

            notizbuch.NotizErstellenUndSpeichern(titel, prio, kategorie, deadline, inhalt);

            NotizenSync();
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
    }
}
