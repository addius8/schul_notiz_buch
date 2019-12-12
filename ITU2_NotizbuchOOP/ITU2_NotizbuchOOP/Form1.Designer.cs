namespace ITU2_NotizbuchOOP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbNotizen = new System.Windows.Forms.ListBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.numPrioritaet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInhalt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.drpDwnKategorie = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.numPrioSuche = new System.Windows.Forms.NumericUpDown();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Notizen = new System.Windows.Forms.TabPage();
            this.cboxFiltern = new System.Windows.Forms.CheckBox();
            this.txtErstelldatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Hausaufgaben = new System.Windows.Forms.TabPage();
            this.HAbtnErledigt = new System.Windows.Forms.Button();
            this.HAcomboFilterFach = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.HAcheckFiltern = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.HAbtnLoeschen = new System.Windows.Forms.Button();
            this.HAbtnAnzeigen = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.HAbtnSpeichern = new System.Windows.Forms.Button();
            this.HAlistboxListe = new System.Windows.Forms.ListBox();
            this.HAtxtFachNeu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HAtxtTitel = new System.Windows.Forms.TextBox();
            this.HAtxtAufgabe = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.HAdateDeadline = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.HAcomboFach = new System.Windows.Forms.ComboBox();
            this.Einkaufszettel = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioritaet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioSuche)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Notizen.SuspendLayout();
            this.Hausaufgaben.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(179, 281);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(93, 23);
            this.btnSpeichern.TabIndex = 0;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel:";
            // 
            // lstbNotizen
            // 
            this.lstbNotizen.FormattingEnabled = true;
            this.lstbNotizen.Location = new System.Drawing.Point(292, 36);
            this.lstbNotizen.Name = "lstbNotizen";
            this.lstbNotizen.Size = new System.Drawing.Size(182, 212);
            this.lstbNotizen.TabIndex = 2;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(62, 36);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(210, 20);
            this.txtTitel.TabIndex = 3;
            // 
            // numPrioritaet
            // 
            this.numPrioritaet.Location = new System.Drawing.Point(111, 88);
            this.numPrioritaet.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrioritaet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrioritaet.Name = "numPrioritaet";
            this.numPrioritaet.Size = new System.Drawing.Size(161, 20);
            this.numPrioritaet.TabIndex = 7;
            this.numPrioritaet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priorität:";
            // 
            // txtInhalt
            // 
            this.txtInhalt.Location = new System.Drawing.Point(62, 193);
            this.txtInhalt.Multiline = true;
            this.txtInhalt.Name = "txtInhalt";
            this.txtInhalt.Size = new System.Drawing.Size(210, 81);
            this.txtInhalt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inhalt:";
            // 
            // dateDeadline
            // 
            this.dateDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeadline.Location = new System.Drawing.Point(111, 114);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(161, 20);
            this.dateDeadline.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zu erledigen bis:";
            // 
            // drpDwnKategorie
            // 
            this.drpDwnKategorie.Items.Add("K1");
            this.drpDwnKategorie.Items.Add("K2");
            this.drpDwnKategorie.Items.Add("K3");
            this.drpDwnKategorie.Items.Add("K4");
            this.drpDwnKategorie.Items.Add("K5");
            this.drpDwnKategorie.Location = new System.Drawing.Point(111, 140);
            this.drpDwnKategorie.Name = "drpDwnKategorie";
            this.drpDwnKategorie.Size = new System.Drawing.Size(161, 20);
            this.drpDwnKategorie.TabIndex = 14;
            this.drpDwnKategorie.Text = "Kategorie wählen";
            this.drpDwnKategorie.Wrap = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategorie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vorhandene Notizen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Notiz";
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(292, 281);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(89, 23);
            this.btnAnzeigen.TabIndex = 18;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(387, 281);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(87, 23);
            this.btnLoeschen.TabIndex = 19;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // numPrioSuche
            // 
            this.numPrioSuche.Location = new System.Drawing.Point(416, 254);
            this.numPrioSuche.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPrioSuche.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrioSuche.Name = "numPrioSuche";
            this.numPrioSuche.Size = new System.Drawing.Size(58, 20);
            this.numPrioSuche.TabIndex = 21;
            this.numPrioSuche.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrioSuche.ValueChanged += new System.EventHandler(this.numPrioSuche_ValueChanged);
            // 
            // txtKategorie
            // 
            this.txtKategorie.Location = new System.Drawing.Point(111, 166);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(161, 20);
            this.txtKategorie.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Kategorie(neu):";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Notizen);
            this.tabControl1.Controls.Add(this.Hausaufgaben);
            this.tabControl1.Controls.Add(this.Einkaufszettel);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 345);
            this.tabControl1.TabIndex = 29;
            // 
            // Notizen
            // 
            this.Notizen.Controls.Add(this.cboxFiltern);
            this.Notizen.Controls.Add(this.txtErstelldatum);
            this.Notizen.Controls.Add(this.label2);
            this.Notizen.Controls.Add(this.numPrioritaet);
            this.Notizen.Controls.Add(this.label11);
            this.Notizen.Controls.Add(this.btnLoeschen);
            this.Notizen.Controls.Add(this.btnAnzeigen);
            this.Notizen.Controls.Add(this.label7);
            this.Notizen.Controls.Add(this.btnSpeichern);
            this.Notizen.Controls.Add(this.lstbNotizen);
            this.Notizen.Controls.Add(this.txtKategorie);
            this.Notizen.Controls.Add(this.numPrioSuche);
            this.Notizen.Controls.Add(this.label1);
            this.Notizen.Controls.Add(this.txtTitel);
            this.Notizen.Controls.Add(this.label3);
            this.Notizen.Controls.Add(this.txtInhalt);
            this.Notizen.Controls.Add(this.label4);
            this.Notizen.Controls.Add(this.dateDeadline);
            this.Notizen.Controls.Add(this.label5);
            this.Notizen.Controls.Add(this.drpDwnKategorie);
            this.Notizen.Controls.Add(this.label6);
            this.Notizen.Controls.Add(this.label8);
            this.Notizen.Location = new System.Drawing.Point(4, 22);
            this.Notizen.Name = "Notizen";
            this.Notizen.Padding = new System.Windows.Forms.Padding(3);
            this.Notizen.Size = new System.Drawing.Size(489, 319);
            this.Notizen.TabIndex = 1;
            this.Notizen.Text = "Notizen";
            this.Notizen.UseVisualStyleBackColor = true;
            // 
            // cboxFiltern
            // 
            this.cboxFiltern.AutoSize = true;
            this.cboxFiltern.Location = new System.Drawing.Point(294, 256);
            this.cboxFiltern.Name = "cboxFiltern";
            this.cboxFiltern.Size = new System.Drawing.Size(116, 17);
            this.cboxFiltern.TabIndex = 31;
            this.cboxFiltern.Text = "nach Priorität filtern";
            this.cboxFiltern.UseVisualStyleBackColor = true;
            this.cboxFiltern.CheckedChanged += new System.EventHandler(this.cboxFiltern_CheckedChanged);
            // 
            // txtErstelldatum
            // 
            this.txtErstelldatum.Location = new System.Drawing.Point(111, 62);
            this.txtErstelldatum.Name = "txtErstelldatum";
            this.txtErstelldatum.ReadOnly = true;
            this.txtErstelldatum.Size = new System.Drawing.Size(161, 20);
            this.txtErstelldatum.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Erstelldatum:";
            // 
            // Hausaufgaben
            // 
            this.Hausaufgaben.Controls.Add(this.HAbtnErledigt);
            this.Hausaufgaben.Controls.Add(this.HAcomboFilterFach);
            this.Hausaufgaben.Controls.Add(this.label18);
            this.Hausaufgaben.Controls.Add(this.HAcheckFiltern);
            this.Hausaufgaben.Controls.Add(this.label9);
            this.Hausaufgaben.Controls.Add(this.HAbtnLoeschen);
            this.Hausaufgaben.Controls.Add(this.HAbtnAnzeigen);
            this.Hausaufgaben.Controls.Add(this.label13);
            this.Hausaufgaben.Controls.Add(this.HAbtnSpeichern);
            this.Hausaufgaben.Controls.Add(this.HAlistboxListe);
            this.Hausaufgaben.Controls.Add(this.HAtxtFachNeu);
            this.Hausaufgaben.Controls.Add(this.label14);
            this.Hausaufgaben.Controls.Add(this.HAtxtTitel);
            this.Hausaufgaben.Controls.Add(this.HAtxtAufgabe);
            this.Hausaufgaben.Controls.Add(this.label15);
            this.Hausaufgaben.Controls.Add(this.HAdateDeadline);
            this.Hausaufgaben.Controls.Add(this.label16);
            this.Hausaufgaben.Controls.Add(this.label17);
            this.Hausaufgaben.Controls.Add(this.HAcomboFach);
            this.Hausaufgaben.Location = new System.Drawing.Point(4, 22);
            this.Hausaufgaben.Name = "Hausaufgaben";
            this.Hausaufgaben.Padding = new System.Windows.Forms.Padding(3);
            this.Hausaufgaben.Size = new System.Drawing.Size(489, 319);
            this.Hausaufgaben.TabIndex = 2;
            this.Hausaufgaben.Text = "Hausaufgaben";
            this.Hausaufgaben.UseVisualStyleBackColor = true;
            // 
            // HAbtnErledigt
            // 
            this.HAbtnErledigt.Location = new System.Drawing.Point(73, 281);
            this.HAbtnErledigt.Name = "HAbtnErledigt";
            this.HAbtnErledigt.Size = new System.Drawing.Size(101, 23);
            this.HAbtnErledigt.TabIndex = 55;
            this.HAbtnErledigt.Text = "Erledigt";
            this.HAbtnErledigt.UseVisualStyleBackColor = true;
            // 
            // HAcomboFilterFach
            // 
            this.HAcomboFilterFach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HAcomboFilterFach.FormattingEnabled = true;
            this.HAcomboFilterFach.Location = new System.Drawing.Point(349, 254);
            this.HAcomboFilterFach.Name = "HAcomboFilterFach";
            this.HAcomboFilterFach.Size = new System.Drawing.Size(125, 21);
            this.HAcomboFilterFach.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Fach:";
            // 
            // HAcheckFiltern
            // 
            this.HAcheckFiltern.AutoSize = true;
            this.HAcheckFiltern.Location = new System.Drawing.Point(292, 256);
            this.HAcheckFiltern.Name = "HAcheckFiltern";
            this.HAcheckFiltern.Size = new System.Drawing.Size(51, 17);
            this.HAcheckFiltern.TabIndex = 52;
            this.HAcheckFiltern.Text = "filtern";
            this.HAcheckFiltern.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Fach (neu):";
            // 
            // HAbtnLoeschen
            // 
            this.HAbtnLoeschen.Location = new System.Drawing.Point(387, 281);
            this.HAbtnLoeschen.Name = "HAbtnLoeschen";
            this.HAbtnLoeschen.Size = new System.Drawing.Size(87, 23);
            this.HAbtnLoeschen.TabIndex = 47;
            this.HAbtnLoeschen.Text = "Löschen";
            this.HAbtnLoeschen.UseVisualStyleBackColor = true;
            // 
            // HAbtnAnzeigen
            // 
            this.HAbtnAnzeigen.Location = new System.Drawing.Point(292, 281);
            this.HAbtnAnzeigen.Name = "HAbtnAnzeigen";
            this.HAbtnAnzeigen.Size = new System.Drawing.Size(89, 23);
            this.HAbtnAnzeigen.TabIndex = 46;
            this.HAbtnAnzeigen.Text = "Anzeigen";
            this.HAbtnAnzeigen.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Hausaufgabenliste";
            // 
            // HAbtnSpeichern
            // 
            this.HAbtnSpeichern.Location = new System.Drawing.Point(180, 281);
            this.HAbtnSpeichern.Name = "HAbtnSpeichern";
            this.HAbtnSpeichern.Size = new System.Drawing.Size(92, 23);
            this.HAbtnSpeichern.TabIndex = 36;
            this.HAbtnSpeichern.Text = "Speichern";
            this.HAbtnSpeichern.UseVisualStyleBackColor = true;
            this.HAbtnSpeichern.Click += new System.EventHandler(this.HAbtnSpeichern_Click);
            // 
            // HAlistboxListe
            // 
            this.HAlistboxListe.FormattingEnabled = true;
            this.HAlistboxListe.Location = new System.Drawing.Point(292, 36);
            this.HAlistboxListe.Name = "HAlistboxListe";
            this.HAlistboxListe.Size = new System.Drawing.Size(182, 212);
            this.HAlistboxListe.TabIndex = 38;
            // 
            // HAtxtFachNeu
            // 
            this.HAtxtFachNeu.Location = new System.Drawing.Point(111, 88);
            this.HAtxtFachNeu.Name = "HAtxtFachNeu";
            this.HAtxtFachNeu.Size = new System.Drawing.Size(161, 20);
            this.HAtxtFachNeu.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Titel:";
            // 
            // HAtxtTitel
            // 
            this.HAtxtTitel.Location = new System.Drawing.Point(73, 36);
            this.HAtxtTitel.Name = "HAtxtTitel";
            this.HAtxtTitel.Size = new System.Drawing.Size(199, 20);
            this.HAtxtTitel.TabIndex = 39;
            // 
            // HAtxtAufgabe
            // 
            this.HAtxtAufgabe.Location = new System.Drawing.Point(73, 142);
            this.HAtxtAufgabe.Multiline = true;
            this.HAtxtAufgabe.Name = "HAtxtAufgabe";
            this.HAtxtAufgabe.Size = new System.Drawing.Size(199, 131);
            this.HAtxtAufgabe.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Aufgabe:";
            // 
            // HAdateDeadline
            // 
            this.HAdateDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HAdateDeadline.Location = new System.Drawing.Point(111, 114);
            this.HAdateDeadline.Name = "HAdateDeadline";
            this.HAdateDeadline.Size = new System.Drawing.Size(161, 20);
            this.HAdateDeadline.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Zu erledigen bis:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(15, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "Hausaufgabe";
            // 
            // HAcomboFach
            // 
            this.HAcomboFach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HAcomboFach.FormattingEnabled = true;
            this.HAcomboFach.Location = new System.Drawing.Point(111, 62);
            this.HAcomboFach.Name = "HAcomboFach";
            this.HAcomboFach.Size = new System.Drawing.Size(161, 21);
            this.HAcomboFach.TabIndex = 35;
            // 
            // Einkaufszettel
            // 
            this.Einkaufszettel.Location = new System.Drawing.Point(4, 22);
            this.Einkaufszettel.Name = "Einkaufszettel";
            this.Einkaufszettel.Padding = new System.Windows.Forms.Padding(3);
            this.Einkaufszettel.Size = new System.Drawing.Size(489, 319);
            this.Einkaufszettel.TabIndex = 3;
            this.Einkaufszettel.Text = "Einkaufszettel";
            this.Einkaufszettel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Notizbuch";
            ((System.ComponentModel.ISupportInitialize)(this.numPrioritaet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioSuche)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Notizen.ResumeLayout(false);
            this.Notizen.PerformLayout();
            this.Hausaufgaben.ResumeLayout(false);
            this.Hausaufgaben.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbNotizen;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.NumericUpDown numPrioritaet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInhalt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDeadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown drpDwnKategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAnzeigen;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.NumericUpDown numPrioSuche;
        private System.Windows.Forms.TextBox txtKategorie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Notizen;
        private System.Windows.Forms.TabPage Hausaufgaben;
        private System.Windows.Forms.TabPage Einkaufszettel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtErstelldatum;
		private System.Windows.Forms.CheckBox cboxFiltern;
		private System.Windows.Forms.ComboBox HAcomboFach;
		private System.Windows.Forms.Button HAbtnErledigt;
		private System.Windows.Forms.ComboBox HAcomboFilterFach;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox HAcheckFiltern;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button HAbtnLoeschen;
		private System.Windows.Forms.Button HAbtnAnzeigen;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button HAbtnSpeichern;
		private System.Windows.Forms.ListBox HAlistboxListe;
		private System.Windows.Forms.TextBox HAtxtFachNeu;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox HAtxtTitel;
		private System.Windows.Forms.TextBox HAtxtAufgabe;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker HAdateDeadline;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
	}
}

