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
        private List<Entry> notes = new List<Entry>();

        public List<Entry> getNotes()
        {
            return this.notes;
        }

        public void saveNote(Entry newEntry)
        {
            if (notes.Contains(newEntry))
            {
                deleteByID(newEntry.getID());
            }
            notes.Add(newEntry);
        }
        public Entry findEntryByID(int id)
        {
            for (int i = 0; i < notes.Count(); i++)
            {
                Note note = (Note) notes[i];
                if (id.Equals(note.getID()))
                {
                    return note;
                }
            }
            return null;
        }
        public void deleteByID(int id)
        {
            for (int i = 0; i < notes.Count(); i++)
            {
                if (id.Equals(notes[i].getID()))
                { 
                    notes.RemoveAt(i);
                }
            }
        }
    }
}
