using System;
using System.Collections.Generic;

namespace ITU2_NotizbuchOOP
{
    class Entry
    {
        protected int id;
        protected string title;
        protected DateTime timestamp;
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
            if (!this.id.Equals(((Entry)obj).getID()))
            {
                return false;
            }

            return true;
        }
        public override int GetHashCode()
        {
            var hashCode = 139145961;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(title);
            return hashCode;
        }
        public int CompareTo(Note other)
        {
            return this.id.CompareTo(other.getID());
        }
        public int getID()
        {
            return this.id;
        }
        public String getTitle()
        {
            return this.title;
        }
        public DateTime getTimestamp()
        {
            return this.timestamp;
        }
    }
}