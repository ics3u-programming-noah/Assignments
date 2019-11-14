/*
 * Created by: Noah Colbourne
 * Created on: Monday-October-21
 * Created for: ICS3U Programming
 * Assignment #3b - Pizza Order
 * This program will take the users input of a pizza 
 * and drink and calculate the total, subtotal 
 * and tax of the order.
*/
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

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            //this is hiding the answer labels when the program starts.
            this.lblSubtotal.Hide();
            this.lblTotal.Hide();
            this.lblTaxAnswer.Hide();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //this will reveal the answer labels when the button is clicked.
            this.lblSubtotal.Show();
            this.lblTotal.Show();
            this.lblTaxAnswer.Show();

            //This is declaring variables.
            double pizzasize, toppings, drinks, pizzacost, drinkcost, toppingscost, tax, subtotal, total, ordertax, ordertaxans;

            //This is declaring constants 
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

            //This is initializing the values of the variables.
            pizzacost = 0;

            toppingscost = 0;

            drinkcost = 0;

            ordertax = 0;

            //This is converting text values to numeric values and making the variabls equal to their input.
            pizzasize = double.Parse(nudPizzaSize.Text);
            toppings = double.Parse(nudToppings.Text);
            drinks = double.Parse(nudDrinks.Text);
            tax = double.Parse(nudOrderTax.Text);

            //This is giving the variable "pizzacost" a value depending on what conditions are met.
            if (pizzasize == 1)
            {
                pizzacost = medium;
            }
            else if (pizzasize == 2)
            {
                pizzacost = large;
            }
            else if (pizzasize == 3)
            {
                pizzacost = extralarge;
            }

            //This is giving the variable "toppings" a value depending on what conditions are met.
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

            //This is giving the variable "drinkcost" a value depending on what conditions are met.
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

            //This is giving the variable "tax" a value depending on what conditions are met.
            if (tax == 1)
            {
                ordertax = hsttax;
            }
            else if (tax == 2)
            {
                ordertax = gsttax;
            }

            //this is calculating the subtotal and assigning the value to a variable.
            subtotal = pizzacost + toppingscost + drinkcost;

            //this is calculating the tax and assigning the value to a variable.
            ordertaxans = subtotal * ordertax;

            //this is calculating the total and assigning the value to a variable.
            total = subtotal + ordertaxans;

            //this is taking the calculations and converting them back to text
            //then assigning them to labels and displaying them.
            lblSubtotal.Text = String.Format("${0:0.00}", subtotal);

            lblTotal.Text = String.Format("${0:0.00}", total);

            lblTaxAnswer.Text = String.Format("${0:0.00}", ordertaxans);


        }
    }
}
