namespace Main3
{
    partial class frPizzaOrderForm
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWhereToEatTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCrustTypeTitle = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbToppingsTitle = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbSizeTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.chkThickCrust = new System.Windows.Forms.RadioButton();
            this.chkThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(82, 137);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 199);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            this.gbSize.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(18, 119);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(98, 29);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbLarge_MouseClick);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(18, 86);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(119, 29);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbMedium_MouseClick);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(18, 51);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(96, 29);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbSmall_MouseClick);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(353, 137);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(429, 199);
            this.gbToppings.TabIndex = 1;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(208, 119);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(189, 29);
            this.chkGreenPeppers.TabIndex = 8;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(28, 119);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(139, 29);
            this.chkTomatoes.TabIndex = 7;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(208, 86);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(104, 29);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(28, 87);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(156, 29);
            this.chkMushrooms.TabIndex = 5;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(208, 51);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(101, 29);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(28, 52);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(174, 29);
            this.chkExtraCheese.TabIndex = 3;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.lbWhereToEatTitle);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Controls.Add(this.lbCrustTypeTitle);
            this.gbOrderSummary.Controls.Add(this.lbToppings);
            this.gbOrderSummary.Controls.Add(this.lbToppingsTitle);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.Controls.Add(this.lbSizeTitle);
            this.gbOrderSummary.Controls.Add(this.groupBox1);
            this.gbOrderSummary.Location = new System.Drawing.Point(801, 137);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(249, 387);
            this.gbOrderSummary.TabIndex = 1;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "--";
            // 
            // lbWhereToEatTitle
            // 
            this.lbWhereToEatTitle.AutoSize = true;
            this.lbWhereToEatTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEatTitle.Location = new System.Drawing.Point(6, 308);
            this.lbWhereToEatTitle.Name = "lbWhereToEatTitle";
            this.lbWhereToEatTitle.Size = new System.Drawing.Size(158, 24);
            this.lbWhereToEatTitle.TabIndex = 9;
            this.lbWhereToEatTitle.Text = "Where To Eat: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "--";
            // 
            // lbCrustTypeTitle
            // 
            this.lbCrustTypeTitle.AutoSize = true;
            this.lbCrustTypeTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustTypeTitle.Location = new System.Drawing.Point(6, 257);
            this.lbCrustTypeTitle.Name = "lbCrustTypeTitle";
            this.lbCrustTypeTitle.Size = new System.Drawing.Size(131, 24);
            this.lbCrustTypeTitle.TabIndex = 7;
            this.lbCrustTypeTitle.Text = "Crust Type: ";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(77, 124);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(0, 24);
            this.lbToppings.TabIndex = 6;
            // 
            // lbToppingsTitle
            // 
            this.lbToppingsTitle.AutoSize = true;
            this.lbToppingsTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingsTitle.Location = new System.Drawing.Point(6, 92);
            this.lbToppingsTitle.Name = "lbToppingsTitle";
            this.lbToppingsTitle.Size = new System.Drawing.Size(117, 24);
            this.lbToppingsTitle.TabIndex = 5;
            this.lbToppingsTitle.Text = "Toppings: ";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(71, 51);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(60, 24);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Small";
            this.lbSize.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbSizeTitle
            // 
            this.lbSizeTitle.AutoSize = true;
            this.lbSizeTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeTitle.Location = new System.Drawing.Point(6, 51);
            this.lbSizeTitle.Name = "lbSizeTitle";
            this.lbSizeTitle.Size = new System.Drawing.Size(65, 24);
            this.lbSizeTitle.TabIndex = 3;
            this.lbSizeTitle.Text = "Size: ";
            this.lbSizeTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.chkThickCrust);
            this.gbCrustType.Controls.Add(this.chkThinCrust);
            this.gbCrustType.Location = new System.Drawing.Point(82, 380);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 199);
            this.gbCrustType.TabIndex = 9;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // chkThickCrust
            // 
            this.chkThickCrust.AutoSize = true;
            this.chkThickCrust.Location = new System.Drawing.Point(18, 86);
            this.chkThickCrust.Name = "chkThickCrust";
            this.chkThickCrust.Size = new System.Drawing.Size(152, 29);
            this.chkThickCrust.TabIndex = 10;
            this.chkThickCrust.TabStop = true;
            this.chkThickCrust.Text = "Thick Crust";
            this.chkThickCrust.UseVisualStyleBackColor = true;
            // 
            // chkThinCrust
            // 
            this.chkThinCrust.AutoSize = true;
            this.chkThinCrust.Location = new System.Drawing.Point(18, 51);
            this.chkThinCrust.Name = "chkThinCrust";
            this.chkThinCrust.Size = new System.Drawing.Size(142, 29);
            this.chkThinCrust.TabIndex = 9;
            this.chkThinCrust.TabStop = true;
            this.chkThinCrust.Text = "Thin Crust";
            this.chkThinCrust.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(353, 380);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(399, 199);
            this.gbWhereToEat.TabIndex = 10;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(197, 86);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(131, 29);
            this.rbTakeOut.TabIndex = 12;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.bt2_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(18, 86);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(98, 29);
            this.rbEatIn.TabIndex = 11;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.Controls.Add(this.lbPrice);
            this.gbTotalPrice.Controls.Add(this.groupBox4);
            this.gbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalPrice.Location = new System.Drawing.Point(801, 547);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(249, 135);
            this.gbTotalPrice.TabIndex = 3;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "Total Price:";
            this.gbTotalPrice.Enter += new System.EventHandler(this.gbTotalPrice_Enter);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(80, 41);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(113, 74);
            this.lbPrice.TabIndex = 9;
            this.lbPrice.Text = "dg";
            this.lbPrice.Click += new System.EventHandler(this.lbPrice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 112);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(330, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(509, 74);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Make you Pizza";
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Location = new System.Drawing.Point(280, 625);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(149, 40);
            this.btOrderPizza.TabIndex = 13;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            // 
            // btResetForm
            // 
            this.btResetForm.Location = new System.Drawing.Point(537, 625);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(149, 40);
            this.btResetForm.TabIndex = 14;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = true;
            // 
            // frPizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 734);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gbTotalPrice);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Name = "frPizzaOrderForm";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbTotalPrice.ResumeLayout(false);
            this.gbTotalPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton chkThickCrust;
        private System.Windows.Forms.RadioButton chkThinCrust;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTotalPrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.Label lbSizeTitle;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbToppingsTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCrustTypeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWhereToEatTitle;
        private System.Windows.Forms.Label lbPrice;
    }
}

