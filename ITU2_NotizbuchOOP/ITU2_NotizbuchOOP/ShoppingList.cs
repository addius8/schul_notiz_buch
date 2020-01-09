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
        private IDictionary<Produkt, int> positionen = new Dictionary<Produkt, int>();
    }
}
