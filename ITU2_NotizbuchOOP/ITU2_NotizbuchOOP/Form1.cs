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
        int currentNote = 0;
        int currentHomeWork = 0;
        int currentShoppingNote = 0;
        NoteBook regularNoteBookInstance = new NoteBook();
        NoteBook homeWorkNoteBook = new NoteBook();
        NoteBook shoppingNoteBook = new NoteBook();

        public Form1()
        {
            InitializeComponent();
        }

        private void syncNotesDisplayBox()
        {
            notes_display.Items.Clear();
            List<Entry> tempNotes = regularNoteBookInstance.getNotes();
            tempNotes.Sort();
            foreach (Entry note in tempNotes)
            {
                notes_display.Items.Add(
                    note.getID() +
                    " - " +
                    note.getTitle()
                );
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void btn_neu_Click(object sender, EventArgs e)
        {

        }

        private void saveNote(object sender, EventArgs e)
        {
            string title = title_input.Text;
            int priority = (int)priority_input.Value;
            string category = category_input.Text;
            string text = note_input.Text;
            DateTime timestamp = timestamp_input.Value;
            DateTime deadline = deadline_input.Value;
            Note newNote;
            if (currentNote != 0)
            {
                newNote = new Note(title, priority, category, text, timestamp, deadline, currentNote);
            } else
            {
                newNote = new Note(title, priority, category, text, timestamp, deadline);
            }
            regularNoteBookInstance.saveNote(newNote);
            currentNote = 0;
            clear();
            syncNotesDisplayBox();
        }
        private void btn_clear_click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            title_input.Text = "";
            priority_input.Value = 0;
            category_input.Text = "";
            note_input.Text = "";
            timestamp_input.Value = DateTime.Now;
            deadline_input.Value = DateTime.Now;
            currentNote = 0;

        }
        private void deleteByTitle(object sender, EventArgs e)
        { 
            int noteID = parseIDFromTitle();
            if (noteID == 0)
            {
                return;
            }
            regularNoteBookInstance.deleteByID(noteID);
            syncNotesDisplayBox();
        }
        private int parseIDFromTitle()
        {
            object o = notes_display.SelectedItem;
            if (o == null)
            {
                return 0;
            }
            String displayed_title = o.ToString();
            String id = displayed_title.Substring(0, displayed_title.IndexOf(" - "));
            return int.Parse(id);
        }
        private void edit_btn_Click(object sender, EventArgs e)
        { 
            currentNote = parseIDFromTitle();

            Note note = (Note) regularNoteBookInstance.findEntryByID(currentNote);
            if (note != null)
            {
                title_input.Text = note.getTitle();
                priority_input.Value = note.getPriority();
                timestamp_input.Value = note.getTimestamp();
                deadline_input.Value = note.getDeadline();
                category_input.Text = note.getCategory();
                note_input.Text = note.getText();
            }
            syncNotesDisplayBox();
        }
        private void search_notes_title_input_changed (object sender, EventArgs e)
        {
            searchNotesByTitle();
        }
        private void search_notes_priority_input_changed(object sender, EventArgs e)
        {
            searchNotesByTitle();
        }


        private void searchNotesByTitle()
        {
            content_display.Text = "";
            string titleComponent = search_title_input.Text;
            notes_display.Items.Clear();
            List<Entry> tempNotes = regularNoteBookInstance.getNotes();
            foreach (Entry entry in tempNotes)
            {
                Note note = (Note) entry;
                if (note.getTitle().Contains(titleComponent) && note.getPriority() == search_priority_input.Value)
                {
                    notes_display.Items.Add(
                    note.getID() +
                    " - " +
                    note.getTitle()
                );
                }

            }
        }
        private void updown_prio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_titel_TextChanged(object sender, EventArgs e)
        {

        }
        private void notes_display_doubleclick(object sender, EventArgs e)
        {
            currentNote = parseIDFromTitle();
            Note note = (Note) regularNoteBookInstance.findEntryByID(currentNote);

            if (note != null)
            {
                content_display.Text = note.getText();
            } else
            {
                content_display.Text = null;
            }
            syncNotesDisplayBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void saveHomeWork(object sender, EventArgs e)
        {
            string title = homework_title_input.Text;
            int time = (int) homework_needed_time_input.Value;
            string category = homework_subject_input.Text;
            string text = homework_task_input.Text;
            DateTime timestamp = homework_timestamp_input.Value;
            DateTime deadline = homework_deadline_input.Value;
            HomeWork newNote;
            if (currentNote != 0)
            {
                newNote = new HomeWork(title, time, category, text, timestamp, deadline, currentNote);
            }
            else
            {
                newNote = new HomeWork(title, time, category, text, timestamp, deadline);
            }
            homeWorkNoteBook.saveNote(newNote);
            currentNote = 0;
            clear();
            syncHomeWorkDisplayBox();
        }
        private void syncHomeWorkDisplayBox()
        {
            homework_display_box.Items.Clear();
            List<Entry> tempNotes = homeWorkNoteBook.getNotes();
            foreach (Entry note in tempNotes)
            {
                homework_display_box.Items.Add(
                    note.getID() +
                    " - " +
                    note.getTitle()
                );
            }
        }

        private void homework_clear_btn_Click(object sender, EventArgs e)
        {
            clearHomeWork();
        }
        private void clearHomeWork()
        {
            this.homework_deadline_input.Value = DateTime.Now;
            this.homework_subject_input.Text = "";
            this.homework_timestamp_input.Value = DateTime.Now;
            this.homework_title_input.Text = "";
            this.homework_needed_time_input.Value = 0;
            this.homework_task_input.Text = "";
            this.currentHomeWork = 0;
        }

        private void homework_edit_btn_Click(object sender, EventArgs e)
        {
            currentHomeWork = parseHomeWorkIDFromTitle();

            HomeWork note = (HomeWork) homeWorkNoteBook.findEntryByID(currentHomeWork);
            homework_title_input.Text = note.getTitle();
            homework_needed_time_input.Value = note.getTimeNeeded();
            homework_timestamp_input.Value = note.getTimestamp();
            homework_deadline_input.Value = note.getDeadline();
            homework_subject_input.Text = note.getCategory();
            homework_task_input.Text = note.getText();

            syncHomeWorkDisplayBox();
        }

        private int parseHomeWorkIDFromTitle()
        {
            object o = homework_display_box.SelectedItem;
            if (o == null)
            {
                return 0;
            }
            String displayed_title = o.ToString();
            String id = displayed_title.Substring(0, displayed_title.IndexOf(" - "));
            return int.Parse(id);
        }

        private void homework_search_input_changed(object sender, EventArgs e)
        {

        }

        private void searchHomeWorkByTitle()
        {
            homework_preview_box.Text = "";
            string titleComponent = homework_search_title_input.Text;
            homework_display_box.Items.Clear();
            List<Entry> tempNotes = homeWorkNoteBook.getNotes();
            foreach (Entry entry in tempNotes)
            {
                Note note = (Note)entry;
                if (note.getTitle().Contains(titleComponent) && note.getPriority() == homework_search_time_needed_input.Value)
                {
                    homework_display_box.Items.Add(
                        note.getID() +
                        " - " +
                        note.getTitle()
                    );
                }

            }
        }
    }
}
