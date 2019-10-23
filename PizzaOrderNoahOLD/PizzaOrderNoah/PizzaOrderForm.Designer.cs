namespace PizzaOrderNoah
{
    partial class frmPizzaOrder
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
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.nudPizzaSize = new System.Windows.Forms.NumericUpDown();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.nudDrinks = new System.Windows.Forms.NumericUpDown();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            this.lblOrderTax = new System.Windows.Forms.Label();
            this.nudOrderTax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderTax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(12, 18);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(382, 13);
            this.lblPizzaSize.TabIndex = 0;
            this.lblPizzaSize.Text = "Select which pizza size you would like! (1 = Medium, 2 = Large, 3 = Extra Large)";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(13, 109);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(218, 13);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Select the amoun of toppings you would like!";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(19, 193);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(192, 13);
            this.lblDrinks.TabIndex = 2;
            this.lblDrinks.Text = "Select how many drinks you would like!";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(13, 367);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(198, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Select Your tax rate! (1 = HST, 2 = GST)";
            // 
            // nudPizzaSize
            // 
            this.nudPizzaSize.Location = new System.Drawing.Point(275, 50);
            this.nudPizzaSize.Name = "nudPizzaSize";
            this.nudPizzaSize.Size = new System.Drawing.Size(120, 20);
            this.nudPizzaSize.TabIndex = 4;
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(275, 141);
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 5;
            // 
            // nudDrinks
            // 
            this.nudDrinks.Location = new System.Drawing.Point(274, 221);
            this.nudDrinks.Name = "nudDrinks";
            this.nudDrinks.Size = new System.Drawing.Size(120, 20);
            this.nudDrinks.TabIndex = 6;
            // 
            // nudTax
            // 
            this.nudTax.Location = new System.Drawing.Point(275, 403);
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(120, 20);
            this.nudTax.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(441, 221);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(676, 123);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(676, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label2";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Location = new System.Drawing.Point(676, 262);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblTaxAnswer.TabIndex = 11;
            this.lblTaxAnswer.Text = "label3";
            // 
            // lblOrderTax
            // 
            this.lblOrderTax.AutoSize = true;
            this.lblOrderTax.Location = new System.Drawing.Point(13, 274);
            this.lblOrderTax.Name = "lblOrderTax";
            this.lblOrderTax.Size = new System.Drawing.Size(196, 13);
            this.lblOrderTax.TabIndex = 12;
            this.lblOrderTax.Text = "Select your tax rate! (1 = HST, 2 = GST)";
            // 
            // nudOrderTax
            // 
            this.nudOrderTax.Location = new System.Drawing.Point(275, 288);
            this.nudOrderTax.Name = "nudOrderTax";
            this.nudOrderTax.Size = new System.Drawing.Size(120, 20);
            this.nudOrderTax.TabIndex = 13;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudOrderTax);
            this.Controls.Add(this.lblOrderTax);
            this.Controls.Add(this.lblTaxAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudTax);
            this.Controls.Add(this.nudDrinks);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.nudPizzaSize);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Noah";
            this.Load += new System.EventHandler(this.FrmPizzaOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.NumericUpDown nudPizzaSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.NumericUpDown nudDrinks;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTaxAnswer;
        private System.Windows.Forms.Label lblOrderTax;
        private System.Windows.Forms.NumericUpDown nudOrderTax;
    }
}

