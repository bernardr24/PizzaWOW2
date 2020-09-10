
using PizzaWow.Model;
using PizzaWOW2.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaWOW2
{
    public partial class PizzaWOW2 : Form
    {
        public PizzaWOW2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PizzaWOW2_Load(object sender, EventArgs e)
        {
            string[] pizzaTypes = { "Pepperoni", "Margherita", "BBQ Chicken" };
            decimal[] pizzaPrices = { 10000, 15000, 20000 };

            for (int i = 0; i < pizzaTypes.Length; i++)
            {
              
                var item = new PWItem { Id = i + 1, Name = pizzaTypes[i], Price = pizzaPrices[i] };
                choosePizza.Items.Add(item);
            }

        }

        private void AddQty_Click(object sender, EventArgs e)
        {
            if (choosePizza.SelectedItem == null)
            {
                MessageBox.Show("Add to your order");
                choosePizza.Focus();
                return;
            }

            var I = new PWOrder()
            {
                Id = OrderList.Items.Count + 1,
                Item = choosePizza.SelectedItem as PWItem,
                Customer = new PWCustomer(),
                OrderDate = DateTime.Now,
                OrderNumber = "",
                Quantity = (int)PizzaQty.Value
            };

            OrderList.Items.Add(I);
           
        }

        private void ChoosePizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddQty.Enabled = !(choosePizza.SelectedItem == null);
        }
    }
}
 

