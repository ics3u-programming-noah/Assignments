/*
 * Created by: Noah Colbourne
 * Created on: 26-Sep-2019
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program will tell you how high an object is from the ground when 
 * the obeject begins at the top of a cliff (100 meters) depending on 
 * what time you input.
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

namespace FallingObjectsNoah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void LblAnswerQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This hides the answer question label.
            this.lblAnswerQuestion.Hide();

            //This hides the answer label.
            this.lblAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //This shows the answer question when button is pressed.
            this.lblAnswerQuestion.Show();
            
            //This shows the answer when button is pressed .
            this.lblAnswer.Show();
           
            //This makes time and height double variables.
            double height, time;

            //This makes the vairbale "time" become double.parse(txtTime.Text).
            time = double.Parse(txtTime.Text);

            //This makes the variable "height" become the equation 100 - 0.5 * 9.8 * Math.Pow(time, 2).
            height = 100 - 0.5 * 9.8 * Math.Pow(time, 2);

            //This converts the answer label to string and and makes it display the height of the object.
            this.lblAnswer.Text = Convert.ToString(height) + " m";

            //This makes it so if the usuer inputs a number that is greater than when the object hits the.
            //ground it will tell you that the object has already hit the ground
            if (height < 0)
                this.lblAnswer.Text = "Object has already hit the ground!";

            //This makes it so that if you input a negative number it will tell you to use a positve number.
            if (time < 0)
                this.lblAnswer.Text = "Please use positive numbers.";



            





        }
    }
}
