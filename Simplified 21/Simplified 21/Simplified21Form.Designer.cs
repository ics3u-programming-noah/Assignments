namespace Simplified_21
{
    partial class frmSimplified21
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHit = new System.Windows.Forms.Button();
            this.lblDealer1 = new System.Windows.Forms.Label();
            this.lblDealer2 = new System.Windows.Forms.Label();
            this.lblDealer3 = new System.Windows.Forms.Label();
            this.lblUser1 = new System.Windows.Forms.Label();
            this.lblUser2 = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblUserTotal = new System.Windows.Forms.Label();
            this.lblUser3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(47, 174);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(107, 46);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // lblDealer1
            // 
            this.lblDealer1.AutoSize = true;
            this.lblDealer1.Location = new System.Drawing.Point(44, 77);
            this.lblDealer1.Name = "lblDealer1";
            this.lblDealer1.Size = new System.Drawing.Size(35, 13);
            this.lblDealer1.TabIndex = 1;
            this.lblDealer1.Text = "label1";
            // 
            // lblDealer2
            // 
            this.lblDealer2.AutoSize = true;
            this.lblDealer2.Location = new System.Drawing.Point(135, 77);
            this.lblDealer2.Name = "lblDealer2";
            this.lblDealer2.Size = new System.Drawing.Size(35, 13);
            this.lblDealer2.TabIndex = 2;
            this.lblDealer2.Text = "label2";
            // 
            // lblDealer3
            // 
            this.lblDealer3.AutoSize = true;
            this.lblDealer3.Location = new System.Drawing.Point(219, 77);
            this.lblDealer3.Name = "lblDealer3";
            this.lblDealer3.Size = new System.Drawing.Size(35, 13);
            this.lblDealer3.TabIndex = 3;
            this.lblDealer3.Text = "label3";
            // 
            // lblUser1
            // 
            this.lblUser1.AutoSize = true;
            this.lblUser1.Location = new System.Drawing.Point(44, 303);
            this.lblUser1.Name = "lblUser1";
            this.lblUser1.Size = new System.Drawing.Size(35, 13);
            this.lblUser1.TabIndex = 4;
            this.lblUser1.Text = "label4";
            // 
            // lblUser2
            // 
            this.lblUser2.AutoSize = true;
            this.lblUser2.Location = new System.Drawing.Point(135, 303);
            this.lblUser2.Name = "lblUser2";
            this.lblUser2.Size = new System.Drawing.Size(35, 13);
            this.lblUser2.TabIndex = 5;
            this.lblUser2.Text = "label5";
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(209, 174);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(104, 46);
            this.btnStay.TabIndex = 6;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Location = new System.Drawing.Point(673, 98);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(35, 13);
            this.lblDealerTotal.TabIndex = 7;
            this.lblDealerTotal.Text = "label6";
            // 
            // lblUserTotal
            // 
            this.lblUserTotal.AutoSize = true;
            this.lblUserTotal.Location = new System.Drawing.Point(673, 234);
            this.lblUserTotal.Name = "lblUserTotal";
            this.lblUserTotal.Size = new System.Drawing.Size(35, 13);
            this.lblUserTotal.TabIndex = 8;
            this.lblUserTotal.Text = "label7";
            // 
            // lblUser3
            // 
            this.lblUser3.AutoSize = true;
            this.lblUser3.Location = new System.Drawing.Point(244, 303);
            this.lblUser3.Name = "lblUser3";
            this.lblUser3.Size = new System.Drawing.Size(35, 13);
            this.lblUser3.TabIndex = 9;
            this.lblUser3.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(379, 174);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(134, 48);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblUser3);
            this.Controls.Add(this.lblUserTotal);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.lblUser2);
            this.Controls.Add(this.lblUser1);
            this.Controls.Add(this.lblDealer3);
            this.Controls.Add(this.lblDealer2);
            this.Controls.Add(this.lblDealer1);
            this.Controls.Add(this.btnHit);
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Noah";
            this.Load += new System.EventHandler(this.FrmSimplified21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Label lblDealer1;
        private System.Windows.Forms.Label lblDealer2;
        private System.Windows.Forms.Label lblDealer3;
        private System.Windows.Forms.Label lblUser1;
        private System.Windows.Forms.Label lblUser2;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblUserTotal;
        private System.Windows.Forms.Label lblUser3;
        private System.Windows.Forms.Button btnStart;
    }
}

