using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Note
    {
        private string title;
        private int priority;
        private string category;
        private string text;
        private DateTime timestamp;
        private DateTime deadline;
        //        private string p_titel;


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            if (!this.title.Equals(((Note) obj).getTitle()))
            {
                return false;
            }

            return true;
        }

        public Note(string p_titel)
        {
            this.title = p_titel;
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
       
    }
}
