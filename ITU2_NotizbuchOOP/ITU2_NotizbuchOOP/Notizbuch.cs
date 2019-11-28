using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class NoteBook
    {
        private string noteBookName;
        private List<Note> notes = new List<Note>();

        public List<Note> getNotes()
        {
            return this.notes;
        }

        public void saveNote(string   title,
                              int      priority,
                              string   category,
                              string   text,
                              DateTime timestamp,
                              DateTime deadline)
        {
            //Neue Notiz erstellen
            Note newNote = new Note(title);
            newNote.setPriority(priority);
            newNote.setCategory(category);
            newNote.setText(text);
            newNote.setTimestamp(timestamp);
            newNote.setDeadline(deadline);


            // replace note if a note with the same title already existed instead of adding a new one
            if (notes.Contains(newNote))
            {
                deleteByTitle(newNote.getTitle());
            }

            //speichern des neuen Objekts
            notes.Add(newNote);
        }
        public Note findNoteByTitle(String title)
        {
            for (int i = 0; i < notes.Count(); i++)
            {
                Note note = notes[i];
                if (title.Equals(note.getTitle()))
                {
                    return note;
                }
            }
            return null;
        }
        public void deleteByTitle(string title)
        {
            for (int i = 0; i < notes.Count(); i++)
            {
                if (title.Equals(notes[i].getTitle()))
                { 
                    notes.RemoveAt(i);
                }
            }
        }
    }
}
