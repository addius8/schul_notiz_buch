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
            this.btn_clear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.regular_notes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.shopping_notes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.homework_clear_btn = new System.Windows.Forms.Button();
            this.homework_title_input = new System.Windows.Forms.TextBox();
            this.homework_edit_btn = new System.Windows.Forms.Button();
            this.homework_delete_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.homework_timestamp_input = new System.Windows.Forms.DateTimePicker();
            this.homework_save_btn = new System.Windows.Forms.Button();
            this.homework_needed_time_input = new System.Windows.Forms.NumericUpDown();
            this.homework_preview_box = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.homework_task_input = new System.Windows.Forms.RichTextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.homework_search_time_needed_input = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.homework_deadline_input = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.homework_display_box = new System.Windows.Forms.ListBox();
            this.homework_subject_input = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.homework_search_title_input = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.priority_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_priority_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.regular_notes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.shopping_notes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homework_needed_time_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homework_search_time_needed_input)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(270, 403);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.saveNote);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(11, 10);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(30, 13);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Titel:";
            // 
            // title_input
            // 
            this.title_input.AccessibleName = "";
            this.title_input.Location = new System.Drawing.Point(14, 26);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(200, 20);
            this.title_input.TabIndex = 3;
            this.title_input.TextChanged += new System.EventHandler(this.txt_titel_TextChanged);
            // 
            // timestamp_input
            // 
            this.timestamp_input.Location = new System.Drawing.Point(14, 65);
            this.timestamp_input.Name = "timestamp_input";
            this.timestamp_input.Size = new System.Drawing.Size(200, 20);
            this.timestamp_input.TabIndex = 4;
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.Location = new System.Drawing.Point(11, 169);
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(34, 13);
            this.note_label.TabIndex = 5;
            this.note_label.Text = "Notiz:";
            // 
            // priority_input
            // 
            this.priority_input.Location = new System.Drawing.Point(220, 26);
            this.priority_input.Name = "priority_input";
            this.priority_input.Size = new System.Drawing.Size(125, 20);
            this.priority_input.TabIndex = 6;
            this.priority_input.ValueChanged += new System.EventHandler(this.updown_prio_ValueChanged);
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(217, 10);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(45, 13);
            this.priority_label.TabIndex = 7;
            this.priority_label.Text = "Priorität:";
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(11, 49);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(67, 13);
            this.timestamp_label.TabIndex = 8;
            this.timestamp_label.Text = "Erstelldatum:";
            // 
            // deadline_input
            // 
            this.deadline_input.Location = new System.Drawing.Point(14, 107);
            this.deadline_input.Name = "deadline_input";
            this.deadline_input.Size = new System.Drawing.Size(200, 20);
            this.deadline_input.TabIndex = 9;
            // 
            // deadline_label
            // 
            this.deadline_label.AutoSize = true;
            this.deadline_label.Location = new System.Drawing.Point(11, 91);
            this.deadline_label.Name = "deadline_label";
            this.deadline_label.Size = new System.Drawing.Size(85, 13);
            this.deadline_label.TabIndex = 10;
            this.deadline_label.Text = "Fälligkeitsdatum:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Location = new System.Drawing.Point(11, 130);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(55, 13);
            this.category_label.TabIndex = 11;
            this.category_label.Text = "Kategorie:";
            // 
            // category_input
            // 
            this.category_input.Location = new System.Drawing.Point(14, 146);
            this.category_input.Name = "category_input";
            this.category_input.Size = new System.Drawing.Size(331, 20);
            this.category_input.TabIndex = 12;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(603, 403);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.deleteByTitle);
            // 
            // search_title_label
            // 
            this.search_title_label.AutoSize = true;
            this.search_title_label.Location = new System.Drawing.Point(444, 10);
            this.search_title_label.Name = "search_title_label";
            this.search_title_label.Size = new System.Drawing.Size(68, 13);
            this.search_title_label.TabIndex = 16;
            this.search_title_label.Text = "Titel suchen:";
            // 
            // search_title_input
            // 
            this.search_title_input.Location = new System.Drawing.Point(447, 26);
            this.search_title_input.Name = "search_title_input";
            this.search_title_input.Size = new System.Drawing.Size(186, 20);
            this.search_title_input.TabIndex = 17;
            this.search_title_input.TextChanged += new System.EventHandler(this.search_notes_title_input_changed);
            // 
            // notes_label
            // 
            this.notes_label.AutoSize = true;
            this.notes_label.Location = new System.Drawing.Point(444, 49);
            this.notes_label.Name = "notes_label";
            this.notes_label.Size = new System.Drawing.Size(46, 13);
            this.notes_label.TabIndex = 18;
            this.notes_label.Text = "Notizen:";
            this.notes_label.Click += new System.EventHandler(this.label9_Click);
            // 
            // notes_display
            // 
            this.notes_display.FormattingEnabled = true;
            this.notes_display.Location = new System.Drawing.Point(447, 65);
            this.notes_display.Name = "notes_display";
            this.notes_display.Size = new System.Drawing.Size(312, 95);
            this.notes_display.TabIndex = 19;
            this.notes_display.DoubleClick += new System.EventHandler(this.notes_display_doubleclick);
            // 
            // search_priority_label
            // 
            this.search_priority_label.AutoSize = true;
            this.search_priority_label.Location = new System.Drawing.Point(636, 10);
            this.search_priority_label.Name = "search_priority_label";
            this.search_priority_label.Size = new System.Drawing.Size(45, 13);
            this.search_priority_label.TabIndex = 20;
            this.search_priority_label.Text = "Priorität:";
            // 
            // content_label
            // 
            this.content_label.AutoSize = true;
            this.content_label.Location = new System.Drawing.Point(444, 169);
            this.content_label.Name = "content_label";
            this.content_label.Size = new System.Drawing.Size(36, 13);
            this.content_label.TabIndex = 21;
            this.content_label.Text = "Inhalt:";
            // 
            // search_priority_input
            // 
            this.search_priority_input.Location = new System.Drawing.Point(639, 26);
            this.search_priority_input.Name = "search_priority_input";
            this.search_priority_input.Size = new System.Drawing.Size(120, 20);
            this.search_priority_input.TabIndex = 23;
            this.search_priority_input.ValueChanged += new System.EventHandler(this.search_notes_priority_input_changed);
            // 
            // note_input
            // 
            this.note_input.Location = new System.Drawing.Point(14, 186);
            this.note_input.Name = "note_input";
            this.note_input.Size = new System.Drawing.Size(328, 212);
            this.note_input.TabIndex = 24;
            this.note_input.Text = "";
            // 
            // content_display
            // 
            this.content_display.Location = new System.Drawing.Point(447, 187);
            this.content_display.Name = "content_display";
            this.content_display.Size = new System.Drawing.Size(312, 211);
            this.content_display.TabIndex = 25;
            this.content_display.Text = "";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(447, 403);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 27;
            this.edit_btn.Text = "edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(17, 403);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Notiz:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(220, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.updown_prio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Priorität:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Erstelldatum:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(14, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fälligkeitsdatum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategorie:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Titel suchen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Notizen:";
            this.label8.Click += new System.EventHandler(this.label9_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Priorität:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Inhalt:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(447, 186);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(312, 211);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // regular_notes
            // 
            this.regular_notes.Controls.Add(this.tabPage1);
            this.regular_notes.Controls.Add(this.shopping_notes);
            this.regular_notes.Controls.Add(this.tabPage2);
            this.regular_notes.Controls.Add(this.tabPage3);
            this.regular_notes.Location = new System.Drawing.Point(12, 12);
            this.regular_notes.Name = "regular_notes";
            this.regular_notes.SelectedIndex = 0;
            this.regular_notes.Size = new System.Drawing.Size(786, 466);
            this.regular_notes.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.title_label);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.title_input);
            this.tabPage1.Controls.Add(this.edit_btn);
            this.tabPage1.Controls.Add(this.timestamp_input);
            this.tabPage1.Controls.Add(this.delete_btn);
            this.tabPage1.Controls.Add(this.note_label);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.save_btn);
            this.tabPage1.Controls.Add(this.priority_input);
            this.tabPage1.Controls.Add(this.content_display);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.priority_label);
            this.tabPage1.Controls.Add(this.note_input);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.timestamp_label);
            this.tabPage1.Controls.Add(this.search_priority_input);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.deadline_input);
            this.tabPage1.Controls.Add(this.content_label);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.deadline_label);
            this.tabPage1.Controls.Add(this.search_priority_label);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.category_label);
            this.tabPage1.Controls.Add(this.notes_display);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.category_input);
            this.tabPage1.Controls.Add(this.notes_label);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.search_title_input);
            this.tabPage1.Controls.Add(this.search_title_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notizen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // shopping_notes
            // 
            this.shopping_notes.Controls.Add(this.label1);
            this.shopping_notes.Controls.Add(this.homework_clear_btn);
            this.shopping_notes.Controls.Add(this.homework_title_input);
            this.shopping_notes.Controls.Add(this.homework_edit_btn);
            this.shopping_notes.Controls.Add(this.homework_delete_btn);
            this.shopping_notes.Controls.Add(this.label11);
            this.shopping_notes.Controls.Add(this.homework_timestamp_input);
            this.shopping_notes.Controls.Add(this.homework_save_btn);
            this.shopping_notes.Controls.Add(this.homework_needed_time_input);
            this.shopping_notes.Controls.Add(this.homework_preview_box);
            this.shopping_notes.Controls.Add(this.label13);
            this.shopping_notes.Controls.Add(this.homework_task_input);
            this.shopping_notes.Controls.Add(this.numericUpDown3);
            this.shopping_notes.Controls.Add(this.label15);
            this.shopping_notes.Controls.Add(this.homework_search_time_needed_input);
            this.shopping_notes.Controls.Add(this.label18);
            this.shopping_notes.Controls.Add(this.label20);
            this.shopping_notes.Controls.Add(this.label21);
            this.shopping_notes.Controls.Add(this.homework_deadline_input);
            this.shopping_notes.Controls.Add(this.label23);
            this.shopping_notes.Controls.Add(this.homework_display_box);
            this.shopping_notes.Controls.Add(this.homework_subject_input);
            this.shopping_notes.Controls.Add(this.label25);
            this.shopping_notes.Controls.Add(this.homework_search_title_input);
            this.shopping_notes.Controls.Add(this.label28);
            this.shopping_notes.Location = new System.Drawing.Point(4, 22);
            this.shopping_notes.Name = "shopping_notes";
            this.shopping_notes.Padding = new System.Windows.Forms.Padding(3);
            this.shopping_notes.Size = new System.Drawing.Size(778, 440);
            this.shopping_notes.TabIndex = 1;
            this.shopping_notes.Text = "Hausaufgaben";
            this.shopping_notes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Titel:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // homework_clear_btn
            // 
            this.homework_clear_btn.Location = new System.Drawing.Point(16, 405);
            this.homework_clear_btn.Name = "homework_clear_btn";
            this.homework_clear_btn.Size = new System.Drawing.Size(75, 23);
            this.homework_clear_btn.TabIndex = 67;
            this.homework_clear_btn.Text = "clear";
            this.homework_clear_btn.UseVisualStyleBackColor = true;
            this.homework_clear_btn.Click += new System.EventHandler(this.homework_clear_btn_Click);
            // 
            // homework_title_input
            // 
            this.homework_title_input.AccessibleName = "";
            this.homework_title_input.Location = new System.Drawing.Point(18, 27);
            this.homework_title_input.Name = "homework_title_input";
            this.homework_title_input.Size = new System.Drawing.Size(200, 20);
            this.homework_title_input.TabIndex = 32;
            // 
            // homework_edit_btn
            // 
            this.homework_edit_btn.Location = new System.Drawing.Point(451, 405);
            this.homework_edit_btn.Name = "homework_edit_btn";
            this.homework_edit_btn.Size = new System.Drawing.Size(75, 23);
            this.homework_edit_btn.TabIndex = 65;
            this.homework_edit_btn.Text = "edit";
            this.homework_edit_btn.UseVisualStyleBackColor = true;
            this.homework_edit_btn.Click += new System.EventHandler(this.homework_edit_btn_Click);
            // 
            // homework_delete_btn
            // 
            this.homework_delete_btn.Location = new System.Drawing.Point(688, 405);
            this.homework_delete_btn.Name = "homework_delete_btn";
            this.homework_delete_btn.Size = new System.Drawing.Size(75, 23);
            this.homework_delete_btn.TabIndex = 50;
            this.homework_delete_btn.Text = "delete";
            this.homework_delete_btn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Aufgabe:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // homework_timestamp_input
            // 
            this.homework_timestamp_input.Location = new System.Drawing.Point(16, 67);
            this.homework_timestamp_input.Name = "homework_timestamp_input";
            this.homework_timestamp_input.Size = new System.Drawing.Size(200, 20);
            this.homework_timestamp_input.TabIndex = 33;
            // 
            // homework_save_btn
            // 
            this.homework_save_btn.Location = new System.Drawing.Point(274, 405);
            this.homework_save_btn.Name = "homework_save_btn";
            this.homework_save_btn.Size = new System.Drawing.Size(75, 23);
            this.homework_save_btn.TabIndex = 29;
            this.homework_save_btn.Text = "save";
            this.homework_save_btn.UseVisualStyleBackColor = true;
            this.homework_save_btn.Click += new System.EventHandler(this.saveHomeWork);
            // 
            // homework_needed_time_input
            // 
            this.homework_needed_time_input.Location = new System.Drawing.Point(224, 28);
            this.homework_needed_time_input.Name = "homework_needed_time_input";
            this.homework_needed_time_input.Size = new System.Drawing.Size(125, 20);
            this.homework_needed_time_input.TabIndex = 37;
            // 
            // homework_preview_box
            // 
            this.homework_preview_box.Location = new System.Drawing.Point(451, 188);
            this.homework_preview_box.Name = "homework_preview_box";
            this.homework_preview_box.Size = new System.Drawing.Size(312, 211);
            this.homework_preview_box.TabIndex = 64;
            this.homework_preview_box.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Zeitaufwand";
            // 
            // homework_task_input
            // 
            this.homework_task_input.Location = new System.Drawing.Point(18, 187);
            this.homework_task_input.Name = "homework_task_input";
            this.homework_task_input.Size = new System.Drawing.Size(328, 212);
            this.homework_task_input.TabIndex = 63;
            this.homework_task_input.Text = "";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(224, 28);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(125, 20);
            this.numericUpDown3.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Erstelldatum:";
            // 
            // homework_search_time_needed_input
            // 
            this.homework_search_time_needed_input.Location = new System.Drawing.Point(643, 28);
            this.homework_search_time_needed_input.Name = "homework_search_time_needed_input";
            this.homework_search_time_needed_input.Size = new System.Drawing.Size(120, 20);
            this.homework_search_time_needed_input.TabIndex = 62;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(448, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Inhalt:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Abgabedatum:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(640, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "Priorität:";
            // 
            // homework_deadline_input
            // 
            this.homework_deadline_input.Location = new System.Drawing.Point(18, 109);
            this.homework_deadline_input.Name = "homework_deadline_input";
            this.homework_deadline_input.Size = new System.Drawing.Size(200, 20);
            this.homework_deadline_input.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "Fach:";
            // 
            // homework_display_box
            // 
            this.homework_display_box.FormattingEnabled = true;
            this.homework_display_box.Location = new System.Drawing.Point(451, 67);
            this.homework_display_box.Name = "homework_display_box";
            this.homework_display_box.Size = new System.Drawing.Size(312, 95);
            this.homework_display_box.TabIndex = 57;
            // 
            // homework_subject_input
            // 
            this.homework_subject_input.Location = new System.Drawing.Point(18, 148);
            this.homework_subject_input.Name = "homework_subject_input";
            this.homework_subject_input.Size = new System.Drawing.Size(331, 20);
            this.homework_subject_input.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(448, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 55;
            this.label25.Text = "Notizen:";
            // 
            // homework_search_title_input
            // 
            this.homework_search_title_input.Location = new System.Drawing.Point(451, 28);
            this.homework_search_title_input.Name = "homework_search_title_input";
            this.homework_search_title_input.Size = new System.Drawing.Size(186, 20);
            this.homework_search_title_input.TabIndex = 54;
            this.homework_search_title_input.TextChanged += new System.EventHandler(this.homework_search_input_changed);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(448, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 13);
            this.label28.TabIndex = 52;
            this.label28.Text = "Titel suchen:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 440);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Einkäufe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 440);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Produkteditor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 484);
            this.Controls.Add(this.regular_notes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.priority_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_priority_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.regular_notes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.shopping_notes.ResumeLayout(false);
            this.shopping_notes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homework_needed_time_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homework_search_time_needed_input)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabControl regular_notes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage shopping_notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homework_clear_btn;
        private System.Windows.Forms.TextBox homework_title_input;
        private System.Windows.Forms.Button homework_edit_btn;
        private System.Windows.Forms.Button homework_delete_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker homework_timestamp_input;
        private System.Windows.Forms.Button homework_save_btn;
        private System.Windows.Forms.NumericUpDown homework_needed_time_input;
        private System.Windows.Forms.RichTextBox homework_preview_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox homework_task_input;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown homework_search_time_needed_input;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker homework_deadline_input;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox homework_display_box;
        private System.Windows.Forms.TextBox homework_subject_input;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox homework_search_title_input;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

