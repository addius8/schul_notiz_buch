using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Note : Entry, IComparable<Note>
    {
        private static int idCounter = 1;
        private int priority;
        private string category;
        private string text;
        private DateTime deadline;     
        public Note(string title, int priority, string category, string text, DateTime timestamp, DateTime deadline, int id)
        {
            this.title = title;
            this.id = id;
            this.category = category;
            this.priority = priority;
            this.text = text;
            this.timestamp = timestamp;
            this.deadline = deadline;

        }
        public Note(string title, int priority, string category, string text, DateTime timestamp, DateTime deadline)
        {
            this.title = title;
            this.id = Note.idCounter;
            Note.idCounter++;
            this.priority = priority;
            this.category = category;
            this.text = text;
            this.timestamp = timestamp;
            this.deadline = deadline;
        }
        public void setPriority(int p_prio)
        {
            priority = p_prio;
        }
        public void setCategory(string p_kategorie)
        {
            category = p_kategorie;
        }
        public void setText(string p_text)
        {
            text = p_text;
        }
        public void setTimestamp(DateTime p_erdat)
        {
            timestamp = p_erdat;
        }
        public void setDeadline(DateTime p_fadat)
        {
            deadline = p_fadat;
        }
        public string getTitle()
        {
            return this.title;
        }
        public int getPriority()
        {
            return this.priority;
        }
        public string getCategory()
        {
            return this.category;
        }
        public string getText()
        {
            return this.text;
        }
        public DateTime getTimestamp()
        {
            return this.timestamp;
        }
        public DateTime getDeadline()
        {
            return this.deadline;
        }
        public int getID()
        {
            return this.id;
        }
        public void setID(int id)
        {
            this.id = id;
        }
    }
}
