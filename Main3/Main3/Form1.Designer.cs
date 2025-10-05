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
			this.lbTotalPrice = new System.Windows.Forms.Label();
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
			this.gbSize.Location = new System.Drawing.Point(41, 71);
			this.gbSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbSize.Name = "gbSize";
			this.gbSize.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbSize.Size = new System.Drawing.Size(100, 103);
			this.gbSize.TabIndex = 0;
			this.gbSize.TabStop = false;
			this.gbSize.Text = "Size";
			this.gbSize.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rbLarge
			// 
			this.rbLarge.AutoSize = true;
			this.rbLarge.Location = new System.Drawing.Point(9, 62);
			this.rbLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rbLarge.Name = "rbLarge";
			this.rbLarge.Size = new System.Drawing.Size(52, 17);
			this.rbLarge.TabIndex = 2;
			this.rbLarge.Tag = "20";
			this.rbLarge.Text = "Large";
			this.rbLarge.UseVisualStyleBackColor = true;
			this.rbLarge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbLarge_MouseClick);
			// 
			// rbMedium
			// 
			this.rbMedium.AutoSize = true;
			this.rbMedium.Location = new System.Drawing.Point(9, 45);
			this.rbMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rbMedium.Name = "rbMedium";
			this.rbMedium.Size = new System.Drawing.Size(62, 17);
			this.rbMedium.TabIndex = 1;
			this.rbMedium.Tag = "15";
			this.rbMedium.Text = "Medium";
			this.rbMedium.UseVisualStyleBackColor = true;
			this.rbMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbMedium_MouseClick);
			// 
			// rbSmall
			// 
			this.rbSmall.AutoSize = true;
			this.rbSmall.Location = new System.Drawing.Point(9, 27);
			this.rbSmall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rbSmall.Name = "rbSmall";
			this.rbSmall.Size = new System.Drawing.Size(50, 17);
			this.rbSmall.TabIndex = 0;
			this.rbSmall.Tag = "10";
			this.rbSmall.Text = "Small";
			this.rbSmall.UseVisualStyleBackColor = true;
			this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
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
			this.gbToppings.Location = new System.Drawing.Point(176, 71);
			this.gbToppings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbToppings.Name = "gbToppings";
			this.gbToppings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbToppings.Size = new System.Drawing.Size(214, 103);
			this.gbToppings.TabIndex = 1;
			this.gbToppings.TabStop = false;
			this.gbToppings.Text = "Toppings";
			this.gbToppings.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// chkGreenPeppers
			// 
			this.chkGreenPeppers.AutoSize = true;
			this.chkGreenPeppers.Location = new System.Drawing.Point(104, 62);
			this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkGreenPeppers.Name = "chkGreenPeppers";
			this.chkGreenPeppers.Size = new System.Drawing.Size(97, 17);
			this.chkGreenPeppers.TabIndex = 8;
			this.chkGreenPeppers.Tag = "5";
			this.chkGreenPeppers.Text = "Green Peppers";
			this.chkGreenPeppers.UseVisualStyleBackColor = true;
			// 
			// chkTomatoes
			// 
			this.chkTomatoes.AutoSize = true;
			this.chkTomatoes.Location = new System.Drawing.Point(14, 62);
			this.chkTomatoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkTomatoes.Name = "chkTomatoes";
			this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
			this.chkTomatoes.TabIndex = 7;
			this.chkTomatoes.Tag = "5";
			this.chkTomatoes.Text = "Tomatoes";
			this.chkTomatoes.UseVisualStyleBackColor = true;
			// 
			// chkOlives
			// 
			this.chkOlives.AutoSize = true;
			this.chkOlives.Location = new System.Drawing.Point(104, 45);
			this.chkOlives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkOlives.Name = "chkOlives";
			this.chkOlives.Size = new System.Drawing.Size(55, 17);
			this.chkOlives.TabIndex = 6;
			this.chkOlives.Tag = "5";
			this.chkOlives.Text = "Olives";
			this.chkOlives.UseVisualStyleBackColor = true;
			this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
			// 
			// chkMushrooms
			// 
			this.chkMushrooms.AutoSize = true;
			this.chkMushrooms.Location = new System.Drawing.Point(14, 45);
			this.chkMushrooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkMushrooms.Name = "chkMushrooms";
			this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
			this.chkMushrooms.TabIndex = 5;
			this.chkMushrooms.Tag = "5";
			this.chkMushrooms.Text = "Mushrooms";
			this.chkMushrooms.UseVisualStyleBackColor = true;
			this.chkMushrooms.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// chkOnion
			// 
			this.chkOnion.AutoSize = true;
			this.chkOnion.Location = new System.Drawing.Point(104, 27);
			this.chkOnion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkOnion.Name = "chkOnion";
			this.chkOnion.Size = new System.Drawing.Size(54, 17);
			this.chkOnion.TabIndex = 4;
			this.chkOnion.Tag = "5";
			this.chkOnion.Text = "Onion";
			this.chkOnion.UseVisualStyleBackColor = true;
			// 
			// chkExtraCheese
			// 
			this.chkExtraCheese.AutoSize = true;
			this.chkExtraCheese.Location = new System.Drawing.Point(14, 27);
			this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkExtraCheese.Name = "chkExtraCheese";
			this.chkExtraCheese.Size = new System.Drawing.Size(89, 17);
			this.chkExtraCheese.TabIndex = 3;
			this.chkExtraCheese.Tag = "5";
			this.chkExtraCheese.Text = "Extra Cheese";
			this.chkExtraCheese.UseVisualStyleBackColor = true;
			this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
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
			this.gbOrderSummary.Location = new System.Drawing.Point(400, 71);
			this.gbOrderSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbOrderSummary.Name = "gbOrderSummary";
			this.gbOrderSummary.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbOrderSummary.Size = new System.Drawing.Size(124, 201);
			this.gbOrderSummary.TabIndex = 1;
			this.gbOrderSummary.TabStop = false;
			this.gbOrderSummary.Text = "Order Summary";
			this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 173);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 14);
			this.label2.TabIndex = 10;
			this.label2.Text = "--";
			// 
			// lbWhereToEatTitle
			// 
			this.lbWhereToEatTitle.AutoSize = true;
			this.lbWhereToEatTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWhereToEatTitle.Location = new System.Drawing.Point(3, 160);
			this.lbWhereToEatTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbWhereToEatTitle.Name = "lbWhereToEatTitle";
			this.lbWhereToEatTitle.Size = new System.Drawing.Size(84, 14);
			this.lbWhereToEatTitle.TabIndex = 9;
			this.lbWhereToEatTitle.Text = "Where To Eat: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(68, 134);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 14);
			this.label1.TabIndex = 8;
			this.label1.Text = "--";
			// 
			// lbCrustTypeTitle
			// 
			this.lbCrustTypeTitle.AutoSize = true;
			this.lbCrustTypeTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCrustTypeTitle.Location = new System.Drawing.Point(3, 134);
			this.lbCrustTypeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbCrustTypeTitle.Name = "lbCrustTypeTitle";
			this.lbCrustTypeTitle.Size = new System.Drawing.Size(73, 14);
			this.lbCrustTypeTitle.TabIndex = 7;
			this.lbCrustTypeTitle.Text = "Crust Type: ";
			// 
			// lbToppings
			// 
			this.lbToppings.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lbToppings.AutoSize = true;
			this.lbToppings.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbToppings.Location = new System.Drawing.Point(21, 65);
			this.lbToppings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbToppings.Name = "lbToppings";
			this.lbToppings.Size = new System.Drawing.Size(66, 14);
			this.lbToppings.TabIndex = 6;
			this.lbToppings.Text = "No Toppings";
			this.lbToppings.Click += new System.EventHandler(this.lbToppings_Click);
			// 
			// lbToppingsTitle
			// 
			this.lbToppingsTitle.AutoSize = true;
			this.lbToppingsTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbToppingsTitle.Location = new System.Drawing.Point(3, 48);
			this.lbToppingsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbToppingsTitle.Name = "lbToppingsTitle";
			this.lbToppingsTitle.Size = new System.Drawing.Size(62, 12);
			this.lbToppingsTitle.TabIndex = 5;
			this.lbToppingsTitle.Text = "Toppings: ";
			// 
			// lbSize
			// 
			this.lbSize.AutoSize = true;
			this.lbSize.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSize.Location = new System.Drawing.Point(36, 27);
			this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbSize.Name = "lbSize";
			this.lbSize.Size = new System.Drawing.Size(11, 14);
			this.lbSize.TabIndex = 4;
			this.lbSize.Text = "-";
			this.lbSize.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// lbSizeTitle
			// 
			this.lbSizeTitle.AutoSize = true;
			this.lbSizeTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSizeTitle.Location = new System.Drawing.Point(3, 27);
			this.lbSizeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbSizeTitle.Name = "lbSizeTitle";
			this.lbSizeTitle.Size = new System.Drawing.Size(36, 14);
			this.lbSizeTitle.TabIndex = 3;
			this.lbSizeTitle.Text = "Size: ";
			this.lbSizeTitle.Click += new System.EventHandler(this.label1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 254);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(124, 58);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// gbCrustType
			// 
			this.gbCrustType.Controls.Add(this.chkThickCrust);
			this.gbCrustType.Controls.Add(this.chkThinCrust);
			this.gbCrustType.Location = new System.Drawing.Point(41, 198);
			this.gbCrustType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbCrustType.Name = "gbCrustType";
			this.gbCrustType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbCrustType.Size = new System.Drawing.Size(100, 103);
			this.gbCrustType.TabIndex = 9;
			this.gbCrustType.TabStop = false;
			this.gbCrustType.Text = "Crust Type";
			// 
			// chkThickCrust
			// 
			this.chkThickCrust.AutoSize = true;
			this.chkThickCrust.Location = new System.Drawing.Point(9, 45);
			this.chkThickCrust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkThickCrust.Name = "chkThickCrust";
			this.chkThickCrust.Size = new System.Drawing.Size(79, 17);
			this.chkThickCrust.TabIndex = 10;
			this.chkThickCrust.TabStop = true;
			this.chkThickCrust.Tag = "5";
			this.chkThickCrust.Text = "Thick Crust";
			this.chkThickCrust.UseVisualStyleBackColor = true;
			// 
			// chkThinCrust
			// 
			this.chkThinCrust.AutoSize = true;
			this.chkThinCrust.Location = new System.Drawing.Point(9, 27);
			this.chkThinCrust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkThinCrust.Name = "chkThinCrust";
			this.chkThinCrust.Size = new System.Drawing.Size(73, 17);
			this.chkThinCrust.TabIndex = 9;
			this.chkThinCrust.TabStop = true;
			this.chkThinCrust.Tag = "0";
			this.chkThinCrust.Text = "Thin Crust";
			this.chkThinCrust.UseVisualStyleBackColor = true;
			// 
			// gbWhereToEat
			// 
			this.gbWhereToEat.Controls.Add(this.rbTakeOut);
			this.gbWhereToEat.Controls.Add(this.rbEatIn);
			this.gbWhereToEat.Location = new System.Drawing.Point(176, 198);
			this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbWhereToEat.Name = "gbWhereToEat";
			this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbWhereToEat.Size = new System.Drawing.Size(200, 103);
			this.gbWhereToEat.TabIndex = 10;
			this.gbWhereToEat.TabStop = false;
			this.gbWhereToEat.Text = "Where To Eat";
			// 
			// rbTakeOut
			// 
			this.rbTakeOut.AutoSize = true;
			this.rbTakeOut.Location = new System.Drawing.Point(98, 45);
			this.rbTakeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rbTakeOut.Name = "rbTakeOut";
			this.rbTakeOut.Size = new System.Drawing.Size(70, 17);
			this.rbTakeOut.TabIndex = 12;
			this.rbTakeOut.TabStop = true;
			this.rbTakeOut.Text = "Take Out";
			this.rbTakeOut.UseVisualStyleBackColor = true;
			this.rbTakeOut.CheckedChanged += new System.EventHandler(this.bt2_CheckedChanged);
			// 
			// rbEatIn
			// 
			this.rbEatIn.AutoSize = true;
			this.rbEatIn.Location = new System.Drawing.Point(9, 45);
			this.rbEatIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rbEatIn.Name = "rbEatIn";
			this.rbEatIn.Size = new System.Drawing.Size(53, 17);
			this.rbEatIn.TabIndex = 11;
			this.rbEatIn.TabStop = true;
			this.rbEatIn.Text = "Eat In";
			this.rbEatIn.UseVisualStyleBackColor = true;
			// 
			// gbTotalPrice
			// 
			this.gbTotalPrice.Controls.Add(this.lbTotalPrice);
			this.gbTotalPrice.Controls.Add(this.groupBox4);
			this.gbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTotalPrice.Location = new System.Drawing.Point(400, 284);
			this.gbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbTotalPrice.Name = "gbTotalPrice";
			this.gbTotalPrice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbTotalPrice.Size = new System.Drawing.Size(124, 70);
			this.gbTotalPrice.TabIndex = 3;
			this.gbTotalPrice.TabStop = false;
			this.gbTotalPrice.Text = "Total Price:";
			this.gbTotalPrice.Enter += new System.EventHandler(this.gbTotalPrice_Enter);
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.AutoSize = true;
			this.lbTotalPrice.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPrice.Location = new System.Drawing.Point(40, 21);
			this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(41, 37);
			this.lbTotalPrice.TabIndex = 9;
			this.lbTotalPrice.Text = "--";
			this.lbTotalPrice.Click += new System.EventHandler(this.lbPrice_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(0, 254);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox4.Size = new System.Drawing.Size(124, 58);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "groupBox4";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Showcard Gothic", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbTitle.Location = new System.Drawing.Point(165, 14);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(284, 37);
			this.lbTitle.TabIndex = 11;
			this.lbTitle.Text = "Make your Pizza";
			// 
			// btOrderPizza
			// 
			this.btOrderPizza.Location = new System.Drawing.Point(135, 317);
			this.btOrderPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btOrderPizza.Name = "btOrderPizza";
			this.btOrderPizza.Size = new System.Drawing.Size(103, 37);
			this.btOrderPizza.TabIndex = 13;
			this.btOrderPizza.Text = "Order Pizza";
			this.btOrderPizza.UseVisualStyleBackColor = true;
			this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
			// 
			// btResetForm
			// 
			this.btResetForm.Location = new System.Drawing.Point(257, 317);
			this.btResetForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btResetForm.Name = "btResetForm";
			this.btResetForm.Size = new System.Drawing.Size(103, 37);
			this.btResetForm.TabIndex = 14;
			this.btResetForm.Text = "Reset Form";
			this.btResetForm.UseVisualStyleBackColor = true;
			this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
			// 
			// frPizzaOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 419);
			this.Controls.Add(this.btResetForm);
			this.Controls.Add(this.btOrderPizza);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.gbTotalPrice);
			this.Controls.Add(this.gbWhereToEat);
			this.Controls.Add(this.gbCrustType);
			this.Controls.Add(this.gbOrderSummary);
			this.Controls.Add(this.gbToppings);
			this.Controls.Add(this.gbSize);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lbTotalPrice;
    }
}

