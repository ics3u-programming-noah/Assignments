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
            this.lblOrderTax = new System.Windows.Forms.Label();
            this.nudPizzaSize = new System.Windows.Forms.NumericUpDown();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.nudDrinks = new System.Windows.Forms.NumericUpDown();
            this.nudOrderTax = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            this.lblSubtotalQ = new System.Windows.Forms.Label();
            this.lblTotalQ = new System.Windows.Forms.Label();
            this.lblTaxQ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderTax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(12, 57);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(382, 13);
            this.lblPizzaSize.TabIndex = 0;
            this.lblPizzaSize.Text = "Select which pizza size you would like! (1 = Medium, 2 = Large, 3 = Extra Large)";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(12, 139);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(262, 13);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Select the amount of toppings you would like! (Max: 5)";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Location = new System.Drawing.Point(12, 221);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(233, 13);
            this.lblDrinks.TabIndex = 2;
            this.lblDrinks.Text = "Select how many drinks you would like! (Max: 4)";
            // 
            // lblOrderTax
            // 
            this.lblOrderTax.AutoSize = true;
            this.lblOrderTax.Location = new System.Drawing.Point(12, 297);
            this.lblOrderTax.Name = "lblOrderTax";
            this.lblOrderTax.Size = new System.Drawing.Size(196, 13);
            this.lblOrderTax.TabIndex = 3;
            this.lblOrderTax.Text = "Select your tax rate! (1 = HST, 2 = GST)";
            // 
            // nudPizzaSize
            // 
            this.nudPizzaSize.Location = new System.Drawing.Point(274, 85);
            this.nudPizzaSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPizzaSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaSize.Name = "nudPizzaSize";
            this.nudPizzaSize.Size = new System.Drawing.Size(120, 20);
            this.nudPizzaSize.TabIndex = 4;
            this.nudPizzaSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(274, 166);
            this.nudToppings.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 5;
            // 
            // nudDrinks
            // 
            this.nudDrinks.Location = new System.Drawing.Point(274, 245);
            this.nudDrinks.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDrinks.Name = "nudDrinks";
            this.nudDrinks.Size = new System.Drawing.Size(120, 20);
            this.nudDrinks.TabIndex = 6;
            // 
            // nudOrderTax
            // 
            this.nudOrderTax.Location = new System.Drawing.Point(274, 324);
            this.nudOrderTax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudOrderTax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrderTax.Name = "nudOrderTax";
            this.nudOrderTax.Size = new System.Drawing.Size(120, 20);
            this.nudOrderTax.TabIndex = 7;
            this.nudOrderTax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(461, 213);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(687, 123);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(687, 213);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label1";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Location = new System.Drawing.Point(687, 297);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblTaxAnswer.TabIndex = 11;
            this.lblTaxAnswer.Text = "label1";
            // 
            // lblSubtotalQ
            // 
            this.lblSubtotalQ.AutoSize = true;
            this.lblSubtotalQ.Location = new System.Drawing.Point(582, 123);
            this.lblSubtotalQ.Name = "lblSubtotalQ";
            this.lblSubtotalQ.Size = new System.Drawing.Size(82, 13);
            this.lblSubtotalQ.TabIndex = 12;
            this.lblSubtotalQ.Text = "Your subtotal is:";
            // 
            // lblTotalQ
            // 
            this.lblTotalQ.AutoSize = true;
            this.lblTotalQ.Location = new System.Drawing.Point(582, 213);
            this.lblTotalQ.Name = "lblTotalQ";
            this.lblTotalQ.Size = new System.Drawing.Size(65, 13);
            this.lblTotalQ.TabIndex = 13;
            this.lblTotalQ.Text = "Your total is:";
            // 
            // lblTaxQ
            // 
            this.lblTaxQ.AutoSize = true;
            this.lblTaxQ.Location = new System.Drawing.Point(582, 297);
            this.lblTaxQ.Name = "lblTaxQ";
            this.lblTaxQ.Size = new System.Drawing.Size(59, 13);
            this.lblTaxQ.TabIndex = 14;
            this.lblTaxQ.Text = "Your tax is:";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTaxQ);
            this.Controls.Add(this.lblTotalQ);
            this.Controls.Add(this.lblSubtotalQ);
            this.Controls.Add(this.lblTaxAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudOrderTax);
            this.Controls.Add(this.nudDrinks);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.nudPizzaSize);
            this.Controls.Add(this.lblOrderTax);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Noah";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.Label lblOrderTax;
        private System.Windows.Forms.NumericUpDown nudPizzaSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.NumericUpDown nudDrinks;
        private System.Windows.Forms.NumericUpDown nudOrderTax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTaxAnswer;
        private System.Windows.Forms.Label lblSubtotalQ;
        private System.Windows.Forms.Label lblTotalQ;
        private System.Windows.Forms.Label lblTaxQ;
    }
}

