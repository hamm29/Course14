namespace MyFirstWinFormsProject
{
	partial class Form3
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.eventLog1 = new System.Diagnostics.EventLog();
			this.button2 = new System.Windows.Forms.Button();
			this.gbCrust = new System.Windows.Forms.GroupBox();
			this.rbThick = new System.Windows.Forms.RadioButton();
			this.rbThin = new System.Windows.Forms.RadioButton();
			this.gbSize = new System.Windows.Forms.GroupBox();
			this.rbLarge = new System.Windows.Forms.RadioButton();
			this.rbMedium = new System.Windows.Forms.RadioButton();
			this.rbSmall = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.gbCrust.SuspendLayout();
			this.gbSize.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(66, 146);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(53, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 45);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// eventLog1
			// 
			this.eventLog1.SynchronizingObject = this;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(276, 232);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 45);
			this.button2.TabIndex = 5;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// gbCrust
			// 
			this.gbCrust.Controls.Add(this.rbThick);
			this.gbCrust.Controls.Add(this.rbThin);
			this.gbCrust.Location = new System.Drawing.Point(515, 89);
			this.gbCrust.Name = "gbCrust";
			this.gbCrust.Size = new System.Drawing.Size(200, 100);
			this.gbCrust.TabIndex = 9;
			this.gbCrust.TabStop = false;
			this.gbCrust.Text = "Crust";
			this.gbCrust.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rbThick
			// 
			this.rbThick.AutoSize = true;
			this.rbThick.Location = new System.Drawing.Point(16, 69);
			this.rbThick.Name = "rbThick";
			this.rbThick.Size = new System.Drawing.Size(52, 17);
			this.rbThick.TabIndex = 10;
			this.rbThick.TabStop = true;
			this.rbThick.Text = "Thick";
			this.rbThick.UseVisualStyleBackColor = true;
			// 
			// rbThin
			// 
			this.rbThin.AutoSize = true;
			this.rbThin.Location = new System.Drawing.Point(16, 27);
			this.rbThin.Name = "rbThin";
			this.rbThin.Size = new System.Drawing.Size(46, 17);
			this.rbThin.TabIndex = 9;
			this.rbThin.TabStop = true;
			this.rbThin.Text = "Thin";
			this.rbThin.UseVisualStyleBackColor = true;
			// 
			// gbSize
			// 
			this.gbSize.Controls.Add(this.rbLarge);
			this.gbSize.Controls.Add(this.rbMedium);
			this.gbSize.Controls.Add(this.rbSmall);
			this.gbSize.Location = new System.Drawing.Point(248, 89);
			this.gbSize.Name = "gbSize";
			this.gbSize.Size = new System.Drawing.Size(200, 137);
			this.gbSize.TabIndex = 10;
			this.gbSize.TabStop = false;
			this.gbSize.Text = "Size";
			// 
			// rbLarge
			// 
			this.rbLarge.AutoSize = true;
			this.rbLarge.Location = new System.Drawing.Point(16, 114);
			this.rbLarge.Name = "rbLarge";
			this.rbLarge.Size = new System.Drawing.Size(52, 17);
			this.rbLarge.TabIndex = 7;
			this.rbLarge.TabStop = true;
			this.rbLarge.Text = "Large";
			this.rbLarge.UseVisualStyleBackColor = true;
			// 
			// rbMedium
			// 
			this.rbMedium.AutoSize = true;
			this.rbMedium.Location = new System.Drawing.Point(16, 69);
			this.rbMedium.Name = "rbMedium";
			this.rbMedium.Size = new System.Drawing.Size(62, 17);
			this.rbMedium.TabIndex = 6;
			this.rbMedium.TabStop = true;
			this.rbMedium.Text = "Medium";
			this.rbMedium.UseVisualStyleBackColor = true;
			// 
			// rbSmall
			// 
			this.rbSmall.AutoSize = true;
			this.rbSmall.Location = new System.Drawing.Point(16, 27);
			this.rbSmall.Name = "rbSmall";
			this.rbSmall.Size = new System.Drawing.Size(50, 17);
			this.rbSmall.TabIndex = 5;
			this.rbSmall.TabStop = true;
			this.rbSmall.Text = "Small";
			this.rbSmall.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(531, 232);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(107, 45);
			this.button3.TabIndex = 11;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.gbSize);
			this.Controls.Add(this.gbCrust);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Name = "Form3";
			this.Text = "Form3";
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.gbCrust.ResumeLayout(false);
			this.gbCrust.PerformLayout();
			this.gbSize.ResumeLayout(false);
			this.gbSize.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Diagnostics.EventLog eventLog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox gbCrust;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox gbSize;
		private System.Windows.Forms.RadioButton rbLarge;
		private System.Windows.Forms.RadioButton rbMedium;
		private System.Windows.Forms.RadioButton rbSmall;
		private System.Windows.Forms.RadioButton rbThick;
		private System.Windows.Forms.RadioButton rbThin;
	}
}