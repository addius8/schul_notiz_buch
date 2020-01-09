using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class ShoppingList : Entry
    {
        private static int idCounter = 1;
        private DateTime deadline;
        private IDictionary<Product, int> positions = new Dictionary<Product, int>();

        public IDictionary<Product, int> Positions { get => positions; }

        public ShoppingList(int id, String title, DateTime timestamp, DateTime deadline)
        {
            this.id = id;
            this.title = title;
            this.timestamp = timestamp;
            this.deadline = deadline;
        }
        public ShoppingList(String title, DateTime timestamp, DateTime deadline)
        {
            this.title = title;
            this.timestamp = timestamp;
            this.deadline = deadline;
        }
    }
}
