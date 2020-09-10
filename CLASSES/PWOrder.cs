using PizzaWow.Model;
using PizzaWOW2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaWOW2.CLASSES
{
    class PWOrder
    {
        public int Id { get; set; }

        public PWItem Item { get; set; }

        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public PWCustomer Customer { get; set; }

        public int Quantity { get; set; }


        public override string ToString()
        {
            return $"{Item.Name} - {Quantity} x {Item.Price}  {Item.Price * Quantity}";
        }
    }
}
