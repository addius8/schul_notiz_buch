using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU2_NotizbuchOOP
{
    class Product
    {
        private String name;
        private String unit;
        private int price_per_unit;
        
        public String Name { get => name; }
        public String Unit { get => unit; }
        public int PricePerUnit { get => price_per_unit; }

        Product(String name, String unit, int price_per_unit)
        {
            this.name = name;
            this.unit = unit;
            this.price_per_unit = price_per_unit;
        }

    }
}
