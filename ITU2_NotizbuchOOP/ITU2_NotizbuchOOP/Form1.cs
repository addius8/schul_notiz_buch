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
        Note currentNote = null;
        NoteBook noteBookInstance = new NoteBook();

        public Form1()
        {
            InitializeComponent();
        }

        private void syncDisplayBox()
        {
            notes_display.Items.Clear();
            List<Note> tempNotes = noteBookInstance.getNotes();
            foreach (Note note in tempNotes)
            {
                notes_display.Items.Add(note.getTitle());
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
            noteBookInstance.saveNote(title, priority, category, text, timestamp, deadline);

            syncDisplayBox();
        }
        private void deleteByTitle(object sender, EventArgs e)
        {
            String title = notes_display.SelectedItem.ToString();
            noteBookInstance.deleteByTitle(title);

            syncDisplayBox();
        }
        private void edit_btn_Click(object sender, EventArgs e)
        {
            String title = notes_display.SelectedItem.ToString();
            Note note = noteBookInstance.findNoteByTitle(title);
            title_input.Text = title;
            priority_input.Value = note.getPriority();
            timestamp_input.Value = note.getTimestamp();
            deadline_input.Value = note.getDeadline();
            category_input.Text = note.getCategory();
            note_input.Text = note.getText();
            


            syncDisplayBox();
        }

        private void searchByTitle(object sender, EventArgs args)
        {
            string titleComponent = search_title_input.Text;
            notes_display.Items.Clear();
            List<Note> tempNotes = noteBookInstance.getNotes();
            foreach (Note note in tempNotes)
            {
                if (note.getTitle().Contains(titleComponent))
                {
                    notes_display.Items.Add(note.getTitle());
                }
            }
        }
        private void updown_prio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_titel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
