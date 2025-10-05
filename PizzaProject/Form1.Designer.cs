namespace PizzaProject
{
	partial class frPizzaOrder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPizzaOrder));
			this.lbMakeYourPizza = new System.Windows.Forms.Label();
			this.gbSize = new System.Windows.Forms.GroupBox();
			this.gbToppings = new System.Windows.Forms.GroupBox();
			this.gbOrderSummary = new System.Windows.Forms.GroupBox();
			this.gbWhereToEat = new System.Windows.Forms.GroupBox();
			this.btOrderPizza = new System.Windows.Forms.Button();
			this.btResetForm = new System.Windows.Forms.Button();
			this.rbLarge = new System.Windows.Forms.RadioButton();
			this.rbMedium = new System.Windows.Forms.RadioButton();
			this.rbSmall = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.radioButton9 = new System.Windows.Forms.RadioButton();
			this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
			this.chkOnion = new System.Windows.Forms.CheckBox();
			this.chkMushrooms = new System.Windows.Forms.CheckBox();
			this.chkOlives = new System.Windows.Forms.CheckBox();
			this.chkTomatoes = new System.Windows.Forms.CheckBox();
			this.chkExtraCheese = new System.Windows.Forms.CheckBox();
			this.gbTotalPrice = new System.Windows.Forms.GroupBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.gbCrustType = new System.Windows.Forms.GroupBox();
			this.gbSize.SuspendLayout();
			this.gbToppings.SuspendLayout();
			this.gbWhereToEat.SuspendLayout();
			this.gbCrustType.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbMakeYourPizza
			// 
			this.lbMakeYourPizza.AutoSize = true;
			this.lbMakeYourPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lbMakeYourPizza.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMakeYourPizza.Location = new System.Drawing.Point(240, 42);
			this.lbMakeYourPizza.Name = "lbMakeYourPizza";
			this.lbMakeYourPizza.Size = new System.Drawing.Size(362, 46);
			this.lbMakeYourPizza.TabIndex = 0;
			this.lbMakeYourPizza.Text = "Make your Pizza";
			this.lbMakeYourPizza.Click += new System.EventHandler(this.label1_Click);
			// 
			// gbSize
			// 
			this.gbSize.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.gbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.gbSize.Controls.Add(this.rbLarge);
			this.gbSize.Controls.Add(this.rbMedium);
			this.gbSize.Controls.Add(this.rbSmall);
			this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbSize.Location = new System.Drawing.Point(36, 127);
			this.gbSize.Name = "gbSize";
			this.gbSize.Size = new System.Drawing.Size(143, 113);
			this.gbSize.TabIndex = 1;
			this.gbSize.TabStop = false;
			this.gbSize.Text = "Size";
			this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
			// 
			// gbToppings
			// 
			this.gbToppings.Controls.Add(this.chkGreenPeppers);
			this.gbToppings.Controls.Add(this.chkOnion);
			this.gbToppings.Controls.Add(this.chkMushrooms);
			this.gbToppings.Controls.Add(this.chkOlives);
			this.gbToppings.Controls.Add(this.chkTomatoes);
			this.gbToppings.Controls.Add(this.chkExtraCheese);
			this.gbToppings.Location = new System.Drawing.Point(243, 127);
			this.gbToppings.Name = "gbToppings";
			this.gbToppings.Size = new System.Drawing.Size(229, 113);
			this.gbToppings.TabIndex = 2;
			this.gbToppings.TabStop = false;
			this.gbToppings.Text = "Toppings";
			// 
			// gbOrderSummary
			// 
			this.gbOrderSummary.Location = new System.Drawing.Point(593, 127);
			this.gbOrderSummary.Name = "gbOrderSummary";
			this.gbOrderSummary.Size = new System.Drawing.Size(200, 242);
			this.gbOrderSummary.TabIndex = 2;
			this.gbOrderSummary.TabStop = false;
			this.gbOrderSummary.Text = "Order Summary";
			// 
			// gbWhereToEat
			// 
			this.gbWhereToEat.Controls.Add(this.radioButton8);
			this.gbWhereToEat.Controls.Add(this.radioButton9);
			this.gbWhereToEat.Location = new System.Drawing.Point(248, 300);
			this.gbWhereToEat.Name = "gbWhereToEat";
			this.gbWhereToEat.Size = new System.Drawing.Size(200, 69);
			this.gbWhereToEat.TabIndex = 2;
			this.gbWhereToEat.TabStop = false;
			this.gbWhereToEat.Text = "Where To Eat";
			// 
			// btOrderPizza
			// 
			this.btOrderPizza.Location = new System.Drawing.Point(239, 430);
			this.btOrderPizza.Name = "btOrderPizza";
			this.btOrderPizza.Size = new System.Drawing.Size(124, 34);
			this.btOrderPizza.TabIndex = 3;
			this.btOrderPizza.Text = "Order Pizza";
			this.btOrderPizza.UseVisualStyleBackColor = true;
			// 
			// btResetForm
			// 
			this.btResetForm.Location = new System.Drawing.Point(404, 430);
			this.btResetForm.Name = "btResetForm";
			this.btResetForm.Size = new System.Drawing.Size(124, 34);
			this.btResetForm.TabIndex = 4;
			this.btResetForm.Text = "Reset Form";
			this.btResetForm.UseVisualStyleBackColor = true;
			this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
			// 
			// rbLarge
			// 
			this.rbLarge.AutoSize = true;
			this.rbLarge.Location = new System.Drawing.Point(23, 75);
			this.rbLarge.Name = "rbLarge";
			this.rbLarge.Size = new System.Drawing.Size(52, 17);
			this.rbLarge.TabIndex = 10;
			this.rbLarge.TabStop = true;
			this.rbLarge.Text = "Large";
			this.rbLarge.UseVisualStyleBackColor = true;
			// 
			// rbMedium
			// 
			this.rbMedium.AutoSize = true;
			this.rbMedium.Location = new System.Drawing.Point(23, 52);
			this.rbMedium.Name = "rbMedium";
			this.rbMedium.Size = new System.Drawing.Size(62, 17);
			this.rbMedium.TabIndex = 9;
			this.rbMedium.TabStop = true;
			this.rbMedium.Text = "Medium";
			this.rbMedium.UseVisualStyleBackColor = true;
			// 
			// rbSmall
			// 
			this.rbSmall.AutoSize = true;
			this.rbSmall.Location = new System.Drawing.Point(23, 29);
			this.rbSmall.Name = "rbSmall";
			this.rbSmall.Size = new System.Drawing.Size(50, 17);
			this.rbSmall.TabIndex = 0;
			this.rbSmall.TabStop = true;
			this.rbSmall.Text = "Small";
			this.rbSmall.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(98, 33);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(85, 17);
			this.radioButton8.TabIndex = 9;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "radioButton8";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// radioButton9
			// 
			this.radioButton9.AutoSize = true;
			this.radioButton9.Location = new System.Drawing.Point(6, 33);
			this.radioButton9.Name = "radioButton9";
			this.radioButton9.Size = new System.Drawing.Size(85, 17);
			this.radioButton9.TabIndex = 8;
			this.radioButton9.TabStop = true;
			this.radioButton9.Text = "radioButton9";
			this.radioButton9.UseVisualStyleBackColor = true;
			// 
			// chkGreenPeppers
			// 
			this.chkGreenPeppers.AutoSize = true;
			this.chkGreenPeppers.Location = new System.Drawing.Point(127, 74);
			this.chkGreenPeppers.Name = "chkGreenPeppers";
			this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
			this.chkGreenPeppers.TabIndex = 16;
			this.chkGreenPeppers.Text = "Green Peppers";
			this.chkGreenPeppers.UseVisualStyleBackColor = true;
			// 
			// chkOnion
			// 
			this.chkOnion.AutoSize = true;
			this.chkOnion.Location = new System.Drawing.Point(127, 34);
			this.chkOnion.Name = "chkOnion";
			this.chkOnion.Size = new System.Drawing.Size(54, 17);
			this.chkOnion.TabIndex = 15;
			this.chkOnion.Text = "Onion";
			this.chkOnion.UseVisualStyleBackColor = true;
			// 
			// chkMushrooms
			// 
			this.chkMushrooms.AutoSize = true;
			this.chkMushrooms.Location = new System.Drawing.Point(24, 54);
			this.chkMushrooms.Name = "chkMushrooms";
			this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
			this.chkMushrooms.TabIndex = 14;
			this.chkMushrooms.Text = "Mushrooms";
			this.chkMushrooms.UseVisualStyleBackColor = true;
			// 
			// chkOlives
			// 
			this.chkOlives.AutoSize = true;
			this.chkOlives.Location = new System.Drawing.Point(127, 53);
			this.chkOlives.Name = "chkOlives";
			this.chkOlives.Size = new System.Drawing.Size(55, 17);
			this.chkOlives.TabIndex = 13;
			this.chkOlives.Text = "Olives";
			this.chkOlives.UseVisualStyleBackColor = true;
			// 
			// chkTomatoes
			// 
			this.chkTomatoes.AutoSize = true;
			this.chkTomatoes.Location = new System.Drawing.Point(24, 74);
			this.chkTomatoes.Name = "chkTomatoes";
			this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
			this.chkTomatoes.TabIndex = 12;
			this.chkTomatoes.Text = "Tomatoes";
			this.chkTomatoes.UseVisualStyleBackColor = true;
			// 
			// chkExtraCheese
			// 
			this.chkExtraCheese.AutoSize = true;
			this.chkExtraCheese.Location = new System.Drawing.Point(24, 34);
			this.chkExtraCheese.Name = "chkExtraCheese";
			this.chkExtraCheese.Size = new System.Drawing.Size(89, 17);
			this.chkExtraCheese.TabIndex = 11;
			this.chkExtraCheese.Text = "Extra Cheese";
			this.chkExtraCheese.UseVisualStyleBackColor = true;
			// 
			// gbTotalPrice
			// 
			this.gbTotalPrice.Location = new System.Drawing.Point(593, 377);
			this.gbTotalPrice.Name = "gbTotalPrice";
			this.gbTotalPrice.Size = new System.Drawing.Size(200, 88);
			this.gbTotalPrice.TabIndex = 3;
			this.gbTotalPrice.TabStop = false;
			this.gbTotalPrice.Text = "Total Price";
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(23, 31);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(85, 17);
			this.radioButton6.TabIndex = 8;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "radioButton6";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(23, 54);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(85, 17);
			this.radioButton5.TabIndex = 9;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "radioButton5";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(23, 77);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(85, 17);
			this.radioButton4.TabIndex = 10;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "radioButton4";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// gbCrustType
			// 
			this.gbCrustType.Controls.Add(this.radioButton4);
			this.gbCrustType.Controls.Add(this.radioButton5);
			this.gbCrustType.Controls.Add(this.radioButton6);
			this.gbCrustType.Location = new System.Drawing.Point(36, 300);
			this.gbCrustType.Name = "gbCrustType";
			this.gbCrustType.Size = new System.Drawing.Size(174, 109);
			this.gbCrustType.TabIndex = 2;
			this.gbCrustType.TabStop = false;
			this.gbCrustType.Text = "Crust Type";
			// 
			// frPizzaOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(874, 516);
			this.Controls.Add(this.gbTotalPrice);
			this.Controls.Add(this.btResetForm);
			this.Controls.Add(this.btOrderPizza);
			this.Controls.Add(this.gbWhereToEat);
			this.Controls.Add(this.gbCrustType);
			this.Controls.Add(this.gbOrderSummary);
			this.Controls.Add(this.gbToppings);
			this.Controls.Add(this.gbSize);
			this.Controls.Add(this.lbMakeYourPizza);
			this.Name = "frPizzaOrder";
			this.Text = "Pizza Order";
			this.gbSize.ResumeLayout(false);
			this.gbSize.PerformLayout();
			this.gbToppings.ResumeLayout(false);
			this.gbToppings.PerformLayout();
			this.gbWhereToEat.ResumeLayout(false);
			this.gbWhereToEat.PerformLayout();
			this.gbCrustType.ResumeLayout(false);
			this.gbCrustType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbMakeYourPizza;
		private System.Windows.Forms.GroupBox gbSize;
		private System.Windows.Forms.GroupBox gbToppings;
		private System.Windows.Forms.GroupBox gbOrderSummary;
		private System.Windows.Forms.GroupBox gbWhereToEat;
		private System.Windows.Forms.RadioButton rbLarge;
		private System.Windows.Forms.RadioButton rbMedium;
		private System.Windows.Forms.RadioButton rbSmall;
		private System.Windows.Forms.CheckBox chkGreenPeppers;
		private System.Windows.Forms.CheckBox chkOnion;
		private System.Windows.Forms.CheckBox chkMushrooms;
		private System.Windows.Forms.CheckBox chkOlives;
		private System.Windows.Forms.CheckBox chkTomatoes;
		private System.Windows.Forms.CheckBox chkExtraCheese;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.Button btOrderPizza;
		private System.Windows.Forms.Button btResetForm;
		private System.Windows.Forms.GroupBox gbTotalPrice;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox gbCrustType;
	}
}

