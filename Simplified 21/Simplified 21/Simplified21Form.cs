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
            this.lblDealerTotal.Hide();
            this.lblUserTotal.Hide();
            this.btnHit.Hide();
            this.btnStay.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.lblDealer1.Show();
            this.lblDealer2.Show();
            this.lblDealer3.Show();
            this.lblUser1.Show();
            this.lblUser2.Show();
            this.lblUser3.Show();
            this.lblDealerTotal.Show();
            this.lblUserTotal.Show();
            this.btnHit.Show();
            this.btnStay.Show();

            const int MIN_NUM = 1;
            const int MAX_NUM = 11;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM+1);
        }
    }
}
