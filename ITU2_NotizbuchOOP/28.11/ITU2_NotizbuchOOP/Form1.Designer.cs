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
            this.label9 = new System.Windows.Forms.Label();
            this.numPrioSuche = new System.Windows.Forms.NumericUpDown();
            this.lstbSuche = new System.Windows.Forms.ListBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBearbeiten = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Notizen = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Hausaufgaben = new System.Windows.Forms.TabPage();
            this.Einkaufszettel = new System.Windows.Forms.TabPage();
            this.txtErstelldatum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioritaet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioSuche)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Notizen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(63, 279);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(101, 23);
            this.btnSpeichern.TabIndex = 0;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titel:";
            // 
            // lstbNotizen
            // 
            this.lstbNotizen.FormattingEnabled = true;
            this.lstbNotizen.Location = new System.Drawing.Point(293, 35);
            this.lstbNotizen.Name = "lstbNotizen";
            this.lstbNotizen.Size = new System.Drawing.Size(182, 238);
            this.lstbNotizen.TabIndex = 2;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(63, 35);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(210, 20);
            this.txtTitel.TabIndex = 3;
            // 
            // numPrioritaet
            // 
            this.numPrioritaet.Location = new System.Drawing.Point(112, 87);
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
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Priorität:";
            // 
            // txtInhalt
            // 
            this.txtInhalt.Location = new System.Drawing.Point(63, 192);
            this.txtInhalt.Multiline = true;
            this.txtInhalt.Name = "txtInhalt";
            this.txtInhalt.Size = new System.Drawing.Size(210, 81);
            this.txtInhalt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inhalt:";
            // 
            // dateDeadline
            // 
            this.dateDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDeadline.Location = new System.Drawing.Point(112, 113);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(161, 20);
            this.dateDeadline.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
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
            this.drpDwnKategorie.Location = new System.Drawing.Point(112, 139);
            this.drpDwnKategorie.Name = "drpDwnKategorie";
            this.drpDwnKategorie.Size = new System.Drawing.Size(161, 20);
            this.drpDwnKategorie.TabIndex = 14;
            this.drpDwnKategorie.Text = "Kategorie wählen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kategorie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vorhandene Notizen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Notiz";
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Location = new System.Drawing.Point(293, 280);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(89, 23);
            this.btnAnzeigen.TabIndex = 18;
            this.btnAnzeigen.Text = "Anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(388, 280);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(87, 23);
            this.btnLoeschen.TabIndex = 19;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Notizen durchsuchen";
            // 
            // numPrioSuche
            // 
            this.numPrioSuche.Location = new System.Drawing.Point(544, 35);
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
            this.numPrioSuche.Size = new System.Drawing.Size(45, 20);
            this.numPrioSuche.TabIndex = 21;
            this.numPrioSuche.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstbSuche
            // 
            this.lstbSuche.FormattingEnabled = true;
            this.lstbSuche.Location = new System.Drawing.Point(496, 61);
            this.lstbSuche.Name = "lstbSuche";
            this.lstbSuche.Size = new System.Drawing.Size(175, 56);
            this.lstbSuche.TabIndex = 22;
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(596, 33);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(75, 10);
            this.btnSuche.TabIndex = 23;
            this.btnSuche.Text = "Anzeigen";
            this.btnSuche.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Priorität:";
            // 
            // btnBearbeiten
            // 
            this.btnBearbeiten.Location = new System.Drawing.Point(293, 309);
            this.btnBearbeiten.Name = "btnBearbeiten";
            this.btnBearbeiten.Size = new System.Drawing.Size(89, 23);
            this.btnBearbeiten.TabIndex = 25;
            this.btnBearbeiten.Text = "Bearbeiten";
            this.btnBearbeiten.UseVisualStyleBackColor = true;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(173, 279);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(100, 23);
            this.btnNeu.TabIndex = 26;
            this.btnNeu.Text = "Neu anlegen";
            this.btnNeu.UseVisualStyleBackColor = true;
            // 
            // txtKategorie
            // 
            this.txtKategorie.Location = new System.Drawing.Point(112, 165);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(161, 20);
            this.txtKategorie.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 168);
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
            this.tabControl1.Size = new System.Drawing.Size(705, 494);
            this.tabControl1.TabIndex = 29;
            // 
            // Notizen
            // 
            this.Notizen.Controls.Add(this.txtErstelldatum);
            this.Notizen.Controls.Add(this.label2);
            this.Notizen.Controls.Add(this.numPrioritaet);
            this.Notizen.Controls.Add(this.btnBearbeiten);
            this.Notizen.Controls.Add(this.label11);
            this.Notizen.Controls.Add(this.btnLoeschen);
            this.Notizen.Controls.Add(this.label10);
            this.Notizen.Controls.Add(this.btnAnzeigen);
            this.Notizen.Controls.Add(this.label7);
            this.Notizen.Controls.Add(this.btnSpeichern);
            this.Notizen.Controls.Add(this.lstbNotizen);
            this.Notizen.Controls.Add(this.btnSuche);
            this.Notizen.Controls.Add(this.txtKategorie);
            this.Notizen.Controls.Add(this.lstbSuche);
            this.Notizen.Controls.Add(this.numPrioSuche);
            this.Notizen.Controls.Add(this.label1);
            this.Notizen.Controls.Add(this.label9);
            this.Notizen.Controls.Add(this.btnNeu);
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
            this.Notizen.Size = new System.Drawing.Size(697, 468);
            this.Notizen.TabIndex = 1;
            this.Notizen.Text = "Notizen";
            this.Notizen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Erstelldatum:";
            // 
            // Hausaufgaben
            // 
            this.Hausaufgaben.Location = new System.Drawing.Point(4, 22);
            this.Hausaufgaben.Name = "Hausaufgaben";
            this.Hausaufgaben.Padding = new System.Windows.Forms.Padding(3);
            this.Hausaufgaben.Size = new System.Drawing.Size(697, 468);
            this.Hausaufgaben.TabIndex = 2;
            this.Hausaufgaben.Text = "Hausaufgaben";
            this.Hausaufgaben.UseVisualStyleBackColor = true;
            // 
            // Einkaufszettel
            // 
            this.Einkaufszettel.Location = new System.Drawing.Point(4, 22);
            this.Einkaufszettel.Name = "Einkaufszettel";
            this.Einkaufszettel.Padding = new System.Windows.Forms.Padding(3);
            this.Einkaufszettel.Size = new System.Drawing.Size(697, 468);
            this.Einkaufszettel.TabIndex = 3;
            this.Einkaufszettel.Text = "Einkaufszettel";
            this.Einkaufszettel.UseVisualStyleBackColor = true;
            // 
            // txtErstelldatum
            // 
            this.txtErstelldatum.Location = new System.Drawing.Point(112, 61);
            this.txtErstelldatum.Name = "txtErstelldatum";
            this.txtErstelldatum.ReadOnly = true;
            this.txtErstelldatum.Size = new System.Drawing.Size(161, 20);
            this.txtErstelldatum.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrioritaet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioSuche)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Notizen.ResumeLayout(false);
            this.Notizen.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPrioSuche;
        private System.Windows.Forms.ListBox lstbSuche;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBearbeiten;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.TextBox txtKategorie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Notizen;
        private System.Windows.Forms.TabPage Hausaufgaben;
        private System.Windows.Forms.TabPage Einkaufszettel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtErstelldatum;
    }
}

