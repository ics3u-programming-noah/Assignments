/*
 * Created by: Noah Colbourne 
 * Created on: 13-Nov-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program runs a game of blackjack. It generates random
 * cards for the user and dealer and allows the user to hit 
 * or stay and declares a winner in the end.
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

namespace Simplified_21
{
     
    public partial class frmSimplified21 : Form
    {
        //This is creating a random number generator 
        Random randomNumberGenerator = new Random();

        //Declaring a maximum and minimum for random number generator 
        //and declaring variables 
        const int MIN_NUM = 1;
        const int MAX_NUM = 11;
        int Ucard1, Ucard2, Ucard3, Ucard4, Dcard1, Dcard2, Dcard3;
        int aRandomNumber;
        int userTotal, dealerTotal;

        private void BtnHit2_Click(object sender, EventArgs e)
        {
            //This is generating a random number then adding it to the total
            //and displaying the number on a label
            this.lblUser4.Show();
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard4 = aRandomNumber;
            this.lblUser4.Text = Convert.ToString(Ucard4);
            userTotal = userTotal + Ucard4;
            lblUserTotal.Text = Convert.ToString(userTotal);

            //This is hiding and showing labels 
                this.btnHit.Hide();
                this.btnHit2.Hide();
                this.btnStay.Hide();              
                this.lblDealer1.Show();
                this.lblDealer2.Show();
                this.lblDealer3.Show();
                this.lblDealerTotal.Show();

            //This is generating 3 random numbers for the dealer and displaying 
            //them and calculating and displaying the dealer total
                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                Dcard1 = aRandomNumber;
                this.lblDealer1.Text = Convert.ToString(Dcard1);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard2 = aRandomNumber;
                this.lblDealer2.Text = Convert.ToString(Dcard2);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard3 = aRandomNumber;
                this.lblDealer3.Text = Convert.ToString(Dcard3);

                dealerTotal = Dcard1 + Dcard2 + Dcard3;

                this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

            //This is checking if any of these statements are true and if
            //they are it will determines who wins, loses or if theres a 
            //Tie then it will display the answer
            if (dealerTotal > 21)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Win!";
            }

            if (userTotal > dealerTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Win!";
            }

            if (dealerTotal > userTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Lose!";
            }

            if (userTotal > 21)
            {

                    this.lblEnd.Text = "You Lose!";

                if (dealerTotal > 21)
                {
                    this.lblEnd.Show();
                    this.lblEnd.Text = "Tie!";
                }
            }


            if (dealerTotal == userTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "Tie!";
            }

           
        }

       

        
        public frmSimplified21()
        {
            InitializeComponent();
        }

        private void FrmSimplified21_Load(object sender, EventArgs e)
        {
            //This hides everything but the start button when the program
            //is started 
            this.lblDealer1.Hide();
            this.lblDealer2.Hide();
            this.lblDealer3.Hide();
            this.lblUser1.Hide();
            this.lblUser2.Hide();
            this.lblUser3.Hide();
            this.lblUser4.Hide();
            this.lblDealerTotal.Hide();
            this.lblUserTotal.Hide();
            this.btnHit.Hide();
            this.btnHit2.Hide();
            this.btnStay.Hide();
            this.lblEnd.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //This is revealing all needed lables when the start
            //button is pressed 
            this.lblUser1.Show();
            this.lblUser2.Show();
            this.lblUserTotal.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            this.btnStart.Hide();
            

            //This is generating 2 random numbers for the user then displaying 
            //them and calculating a total for the user and dsiplaying it
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM+1);

            Ucard1 = aRandomNumber;
            this.lblUser1.Text = Convert.ToString(Ucard1);

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard2 = aRandomNumber;
            this.lblUser2.Text = Convert.ToString(Ucard2);

            userTotal = Ucard1 + Ucard2;
            
            this.lblUserTotal.Text = Convert.ToString(userTotal);

            //If an if statement is true this code will generate 3 random
            //numbers for the dealer then check who wins or losses or if 
            //there is a tie 
          
            if (userTotal > 21)
            {

                this.btnHit.Hide();
                this.btnHit2.Hide();
                this.btnStay.Hide();
                this.lblDealer1.Show();
                this.lblDealer2.Show();
                this.lblDealer3.Show();
                this.lblDealerTotal.Show();
                this.lblEnd.Show();

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                Dcard1 = aRandomNumber;
                this.lblDealer1.Text = Convert.ToString(Dcard1);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard2 = aRandomNumber;
                this.lblDealer2.Text = Convert.ToString(Dcard2);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard3 = aRandomNumber;
                this.lblDealer3.Text = Convert.ToString(Dcard3);

                dealerTotal = Dcard1 + Dcard2 + Dcard3;

                this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

                if (dealerTotal > 21)
                {
                    this.lblEnd.Text = "Tie!";
                }
                else
                {
                    this.lblEnd.Text = "You Lose!";
                }

                if (userTotal == 21)
                {
                    this.btnHit.Hide();
                    this.btnHit2.Hide();
                    this.btnStay.Hide();
                    this.lblDealer1.Show();
                    this.lblDealer2.Show();
                    this.lblDealer3.Show();
                    this.lblDealerTotal.Show();
                    this.lblEnd.Show();

                    aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                    Dcard1 = aRandomNumber;
                    this.lblDealer1.Text = Convert.ToString(Dcard1);

                    aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                    Dcard2 = aRandomNumber;
                    this.lblDealer2.Text = Convert.ToString(Dcard2);

                    aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                    Dcard3 = aRandomNumber;
                    this.lblDealer3.Text = Convert.ToString(Dcard3);

                    dealerTotal = Dcard1 + Dcard2 + Dcard3;

                    this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

                    this.lblEnd.Text = "You Win!";

                    if (dealerTotal == userTotal)
                    {
                        this.lblEnd.Text = "Tie!";
                    }

                }

            }
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            //This will gnerate 3 random numbers for the dealer and display
            //the dealers cards and total
            this.btnHit.Hide();
            this.btnHit2.Hide();
            this.btnStay.Hide();
            this.lblDealer1.Show();
            this.lblDealer2.Show();
            this.lblDealer3.Show();
            this.lblDealerTotal.Show();

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            Dcard1 = aRandomNumber;
            this.lblDealer1.Text = Convert.ToString(Dcard1);

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Dcard2 = aRandomNumber;
            this.lblDealer2.Text = Convert.ToString(Dcard2);

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Dcard3 = aRandomNumber;
            this.lblDealer3.Text = Convert.ToString(Dcard3);

            dealerTotal = Dcard1 + Dcard2 + Dcard3;

            this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

            //this is checking which scenerio is true and then determines
            //who wins, loses or if there is a tie and dsiaplys a label
            //with the answer
            if (dealerTotal > userTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Lose!";
            }

            if (dealerTotal > 21)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Win!";
            }

            if (dealerTotal == 21)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Lose!";
            }

            if (dealerTotal == userTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "Tie!";
            }

            if (dealerTotal < userTotal)
            {
                this.lblEnd.Show();
                this.lblEnd.Text = "You Win!";
            }

            

            
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
           //This is generating another random card for the user and displaying
           //it and adding it to the users total
            this.lblUser3.Show();
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard3 = aRandomNumber;
            this.lblUser3.Text = Convert.ToString(Ucard3);
            userTotal = userTotal + Ucard3;
            lblUserTotal.Text = Convert.ToString(userTotal);
            this.btnHit.Hide();
            this.btnHit2.Show();

            //This is checking if the user meets any win, loss or tie conditions
            //then it will generate 3 cards for the dealer and determine who wins
            //and display the appropriate label
            if (userTotal == 21)
            {
                this.btnHit.Hide();
                this.btnHit2.Hide();
                this.btnStay.Hide();
                this.lblDealer1.Show();
                this.lblDealer2.Show();
                this.lblDealer3.Show();
                this.lblDealerTotal.Show();
                this.lblEnd.Show();

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                Dcard1 = aRandomNumber;
                this.lblDealer1.Text = Convert.ToString(Dcard1);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard2 = aRandomNumber;
                this.lblDealer2.Text = Convert.ToString(Dcard2);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard3 = aRandomNumber;
                this.lblDealer3.Text = Convert.ToString(Dcard3);

                dealerTotal = Dcard1 + Dcard2 + Dcard3;

                this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

                this.lblEnd.Text = "You Win!";

                if (dealerTotal == userTotal)
                {
                    this.lblEnd.Text = "Tie!";
                }

            }

            if (userTotal > 21)
            {

                this.btnHit.Hide();
                this.btnHit2.Hide();
                this.btnStay.Hide();
                this.lblDealer1.Show();
                this.lblDealer2.Show();
                this.lblDealer3.Show();
                this.lblDealerTotal.Show();
                this.lblEnd.Show();

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

                Dcard1 = aRandomNumber;
                this.lblDealer1.Text = Convert.ToString(Dcard1);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard2 = aRandomNumber;
                this.lblDealer2.Text = Convert.ToString(Dcard2);

                aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
                Dcard3 = aRandomNumber;
                this.lblDealer3.Text = Convert.ToString(Dcard3);

                dealerTotal = Dcard1 + Dcard2 + Dcard3;

                this.lblDealerTotal.Text = Convert.ToString(dealerTotal);

                this.lblEnd.Text = "You Lose!";
            }

            if (dealerTotal > 21)
            {
                this.lblEnd.Text = "Tie!";
            }
        }

            

        }
    }

