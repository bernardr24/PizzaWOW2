using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWow.Model
{
    class PWItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

      

        public override string ToString()
        {
            var numFormat = "000,000.00";
            return $"{Price.ToString(numFormat).PadRight(10 + (10 - Price.ToString(numFormat).Length))} {Name}";
        }
    }
}
