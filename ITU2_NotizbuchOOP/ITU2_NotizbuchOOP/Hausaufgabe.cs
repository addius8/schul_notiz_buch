﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Hausaufgabe
    {
        private string titel;
        private string fach;
        private string aufgabe;
        private DateTime deadline;
        private DateTime erstellDatum;

        public string Titel { get => titel; }
        public string Fach { get => fach; set => fach = value; }
        public string Aufgabe { get => aufgabe; set => aufgabe = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public DateTime ErstellDatum { get => erstellDatum;}

        public Hausaufgabe(string titel)
        {
            this.titel = titel;
            erstellDatum = DateTime.Now;
        }
        public Hausaufgabe(string titel, string fach, string aufgabe, DateTime deadline)
        {
            this.titel = titel;
            this.fach = fach;
            this.aufgabe = aufgabe;
            this.deadline = deadline;

            erstellDatum = DateTime.Now;
        }
    }
}
