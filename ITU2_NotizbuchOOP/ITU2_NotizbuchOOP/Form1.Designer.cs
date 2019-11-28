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
            this.save_btn = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.title_input = new System.Windows.Forms.TextBox();
            this.timestamp_input = new System.Windows.Forms.DateTimePicker();
            this.note_label = new System.Windows.Forms.Label();
            this.priority_input = new System.Windows.Forms.NumericUpDown();
            this.priority_label = new System.Windows.Forms.Label();
            this.timestamp_label = new System.Windows.Forms.Label();
            this.deadline_input = new System.Windows.Forms.DateTimePicker();
            this.deadline_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.category_input = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_title_label = new System.Windows.Forms.Label();
            this.search_title_input = new System.Windows.Forms.TextBox();
            this.notes_label = new System.Windows.Forms.Label();
            this.notes_display = new System.Windows.Forms.ListBox();
            this.search_priority_label = new System.Windows.Forms.Label();
            this.content_label = new System.Windows.Forms.Label();
            this.search_priority_input = new System.Windows.Forms.NumericUpDown();
            this.note_input = new System.Windows.Forms.RichTextBox();
            this.content_display = new System.Windows.Forms.RichTextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priority_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_priority_input)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.save_btn.Location = new System.Drawing.Point(268, 415);
            this.save_btn.Name = "btn_save";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.saveNote);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(9, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(30, 13);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Titel:";
            // 
            // title_input
            // 
            this.title_input.AccessibleName = "";
            this.title_input.Location = new System.Drawing.Point(12, 25);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(200, 20);
            this.title_input.TabIndex = 3;
            this.title_input.TextChanged += new System.EventHandler(this.txt_titel_TextChanged);
            // 
            // timestamp_input
            // 
            this.timestamp_input.Location = new System.Drawing.Point(12, 64);
            this.timestamp_input.Name = "timestamp_input";
            this.timestamp_input.Size = new System.Drawing.Size(200, 20);
            this.timestamp_input.TabIndex = 4;
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.Location = new System.Drawing.Point(12, 168);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(34, 13);
            this.note_label.TabIndex = 5;
            this.note_label.Text = "Notiz:";
            // 
            // priority_input
            // 
            this.priority_input.Location = new System.Drawing.Point(218, 25);
            this.priority_input.Name = "priority_input";
            this.priority_input.Size = new System.Drawing.Size(125, 20);
            this.priority_input.TabIndex = 6;
            this.priority_input.ValueChanged += new System.EventHandler(this.updown_prio_ValueChanged);
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(215, 9);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(45, 13);
            this.priority_label.TabIndex = 7;
            this.priority_label.Text = "Priorität:";
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(9, 48);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(67, 13);
            this.timestamp_label.TabIndex = 8;
            this.timestamp_label.Text = "Erstelldatum:";
            // 
            // deadline_input
            // 
            this.deadline_input.Location = new System.Drawing.Point(12, 106);
            this.deadline_input.Name = "deadline_input";
            this.deadline_input.Size = new System.Drawing.Size(200, 20);
            this.deadline_input.TabIndex = 9;
            // 
            // deadline_label
            // 
            this.deadline_label.AutoSize = true;
            this.deadline_label.Location = new System.Drawing.Point(9, 90);
            this.deadline_label.Name = "deadline_label";
            this.deadline_label.Size = new System.Drawing.Size(85, 13);
            this.deadline_label.TabIndex = 10;
            this.deadline_label.Text = "Fälligkeitsdatum:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(9, 129);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(55, 13);
            this.category_label.TabIndex = 11;
            this.category_label.Text = "Kategorie:";
            // 
            // category_input
            // 
            this.category_input.Location = new System.Drawing.Point(12, 145);
            this.category_input.Name = "category_input";
            this.category_input.Size = new System.Drawing.Size(331, 20);
            this.category_input.TabIndex = 12;
            // 
            // btn_loeschen
            // 
            this.delete_btn.Location = new System.Drawing.Point(601, 415);
            this.delete_btn.Name = "btn_loeschen";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.deleteByTitle);
            // 
            // search_title_label
            // 
            this.search_title_label.AutoSize = true;
            this.search_title_label.Location = new System.Drawing.Point(442, 9);
            this.search_title_label.Name = "search_title_label";
            this.search_title_label.Size = new System.Drawing.Size(68, 13);
            this.search_title_label.TabIndex = 16;
            this.search_title_label.Text = "Titel suchen:";
            // 
            // search_title_input
            // 
            this.search_title_input.Location = new System.Drawing.Point(445, 25);
            this.search_title_input.Name = "search_title_input";
            this.search_title_input.Size = new System.Drawing.Size(186, 20);
            this.search_title_input.TabIndex = 17;
            this.search_title_input.TextChanged += new System.EventHandler(this.searchByTitle);
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Location = new System.Drawing.Point(442, 48);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(46, 13);
            this.notes_label.TabIndex = 18;
            this.notes_label.Text = "Notizen:";
            this.notes_label.Click += new System.EventHandler(this.label9_Click);
            // 
            // notes_display
            // 
            this.notes_display.FormattingEnabled = true;
            this.notes_display.Location = new System.Drawing.Point(445, 64);
            this.notes_display.Name = "notes_display";
            this.notes_display.Size = new System.Drawing.Size(312, 95);
            this.notes_display.TabIndex = 19;
            // 
            // search_priority_label
            // 
            this.search_priority_label.AutoSize = true;
            this.search_priority_label.Location = new System.Drawing.Point(634, 9);
            this.search_priority_label.Name = "search_priority_label";
            this.search_priority_label.Size = new System.Drawing.Size(45, 13);
            this.search_priority_label.TabIndex = 20;
            this.search_priority_label.Text = "Priorität:";
            // 
            // content_label
            // 
            this.content_label.AutoSize = true;
            this.content_label.Location = new System.Drawing.Point(442, 168);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(36, 13);
            this.content_label.TabIndex = 21;
            this.content_label.Text = "Inhalt:";
            // 
            // search_priority_input
            // 
            this.search_priority_input.Location = new System.Drawing.Point(637, 25);
            this.search_priority_input.Name = "search_priority_input";
            this.search_priority_input.Size = new System.Drawing.Size(120, 20);
            this.search_priority_input.TabIndex = 23;
            // 
            // note_input
            // 
            this.note_input.Location = new System.Drawing.Point(15, 184);
            this.note_input.Name = "note_input";
            this.note_input.Size = new System.Drawing.Size(328, 212);
            this.note_input.TabIndex = 24;
            this.note_input.Text = "";
            // 
            // content_display
            // 
            this.content_display.Location = new System.Drawing.Point(445, 185);
            this.content_display.Name = "content_display";
            this.content_display.Size = new System.Drawing.Size(312, 211);
            this.content_display.TabIndex = 25;
            this.content_display.Text = "";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(445, 415);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 27;
            this.edit_btn.Text = "edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.content_display);
            this.Controls.Add(this.note_input);
            this.Controls.Add(this.search_priority_input);
            this.Controls.Add(this.content_label);
            this.Controls.Add(this.search_priority_label);
            this.Controls.Add(this.notes_display);
            this.Controls.Add(this.notes_label);
            this.Controls.Add(this.search_title_input);
            this.Controls.Add(this.search_title_label);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.category_input);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.deadline_label);
            this.Controls.Add(this.deadline_input);
            this.Controls.Add(this.timestamp_label);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.priority_input);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.timestamp_input);
            this.Controls.Add(this.title_input);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.save_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.priority_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_priority_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.DateTimePicker timestamp_input;
        private System.Windows.Forms.Label note_label;
        private System.Windows.Forms.NumericUpDown priority_input;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label timestamp_label;
        private System.Windows.Forms.DateTimePicker deadline_input;
        private System.Windows.Forms.Label deadline_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.TextBox category_input;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label search_title_label;
        private System.Windows.Forms.TextBox search_title_input;
        private System.Windows.Forms.Label notes_label;
        private System.Windows.Forms.ListBox notes_display;
        private System.Windows.Forms.Label search_priority_label;
        private System.Windows.Forms.Label content_label;
        private System.Windows.Forms.NumericUpDown search_priority_input;
        private System.Windows.Forms.RichTextBox note_input;
        private System.Windows.Forms.RichTextBox content_display;
        private System.Windows.Forms.Button edit_btn;
    }
}

