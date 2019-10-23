using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderNoah
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void FrmPizzaOrder_Load(object sender, EventArgs e)
        {
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
            this.lblTaxAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            this.lblSubtotal.Show();
            this.lblTotal.Show();
            this.lblTaxAnswer.Show();

            double pizzasize, toppings, drinks, pizzacost, drinkcost, toppingscost, tax, subtotal, total, ordertax, ordertaxans;

            const double extralarge = 12.99;
            const double large = 9.99;
            const double medium = 7.99;
            const double notop = 0;
            const double onetop = 0.75;
            const double twotop = 1.35;
            const double threetop = 2.15;
            const double fourtop = 2.75;
            const double fivetop = 3.50;
            const double nodrink = 0;
            const double onedrink = 1.50;
            const double twodrink = 3;
            const double threedrink = 4.50;
            const double fourdrink = 6;
            const double hsttax = 0.13;
            const double gsttax = 0.05;

            pizzacost = 0;

            toppingscost = 0;

            drinkcost = 0;

            ordertax = 0;
            
            pizzasize = double.Parse(nudPizzaSize.Text);
            toppings = double.Parse(nudToppings.Text);
            drinks = double.Parse(nudDrinks.Text);
            tax = double.Parse(nudOrderTax.Text);

            if (pizzasize == 1)
            {
                pizzacost = medium;
            }
            else if (pizzasize == 2)
            {
                pizzacost = large;
            }
            else if (pizzasize == 3 )
            {
                pizzacost = extralarge;
            }

            if (toppings == 0)
            {
                toppingscost = notop;
            }
            else if (toppings == 1)
            {
                toppingscost = onetop;
            }
            else if (toppings == 2)
            {
                toppingscost = twotop;
            }
            else if (toppings == 3)
            {
                toppingscost = threetop; 
            }
            else if (toppings == 4)
            {
                toppingscost = fourtop;
            }
            else if (toppings == 5)
            {
                toppingscost = fivetop;
            }

            if (drinks == 0)
            {
                drinkcost = nodrink;
            }
            else if (drinks == 1)
            {
                drinkcost = onedrink;
            }
            else if (drinks == 2)
            {
                drinkcost = twodrink;
            }
            else if (drinks == 3)
            {
                drinkcost = threedrink;
            }
            else if (drinks == 4)
            {
                drinkcost = fourdrink;
            }

            if (tax == 1)
            {
                ordertax = hsttax;
            }
            else if (tax == 2)
            {
                ordertax = gsttax;
            }

            subtotal = pizzacost + toppingscost + drinkcost;

            ordertaxans = subtotal * ordertax;

            total = subtotal + ordertaxans;

            lblSubtotal.Text = String.Format("${0:0.0}", subtotal);

            lblTotal.Text = String.Format("${0:0.0}", total);

            lblOrderTax.Text = String.Format("${0:0.0}", ordertaxans);







        }
    }
}
