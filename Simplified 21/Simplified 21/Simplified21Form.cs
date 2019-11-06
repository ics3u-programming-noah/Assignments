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
        Random randomNumberGenerator = new Random();

        const int MIN_NUM = 1;
        const int MAX_NUM = 11;
        int Ucard1, Ucard2, Ucard3, Ucard4;
        int aRandomNumber;
        int userTotal;
        public frmSimplified21()
        {
            InitializeComponent();
        }

        private void FrmSimplified21_Load(object sender, EventArgs e)
        {
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
            this.btnStay.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            this.lblUser1.Show();
            this.lblUser2.Show();
            this.lblUser3.Show();
            this.lblUserTotal.Show();
            this.btnHit.Show();
            this.btnStay.Show();
            this.btnStart.Hide();

            
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM+1);

            Ucard1 = aRandomNumber;
            this.lblUser1.Text = Convert.ToString(Ucard1);

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard2 = aRandomNumber;
            this.lblUser2.Text = Convert.ToString(Ucard2);

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard3 = aRandomNumber;
            this.lblUser3.Text = Convert.ToString(Ucard3);

            Convert.ToString(Ucard1);
            Convert.ToString(Ucard2);
            Convert.ToString(Ucard3);

            userTotal = Ucard1 + Ucard2 + Ucard3;
            
            this.lblUserTotal.Text = Convert.ToString(userTotal);
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            this.lblDealer1.Show();
            this.lblDealer2.Show();
            this.lblDealer3.Show();
            this.lblDealerTotal.Show();
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            this.lblUser4.Show();

            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            Ucard4 = aRandomNumber;
            Convert.ToString(Ucard4);
            this.lblUser4.Text = Convert.ToString(Ucard4);
            userTotal = userTotal + Ucard4;
            lblUserTotal.Text = Convert.ToString(userTotal);

        }
    }
}
