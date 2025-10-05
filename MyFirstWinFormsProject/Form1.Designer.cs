namespace MyFirstWinFormsProject
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMain = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(288, 155);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox1.Size = new System.Drawing.Size(235, 29);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(125, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Copy on mouse click";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button2.Location = new System.Drawing.Point(125, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 36);
			this.button2.TabIndex = 4;
			this.button2.Text = "Copy on mouse enter";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button3.Location = new System.Drawing.Point(125, 318);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(129, 36);
			this.button3.TabIndex = 7;
			this.button3.Text = "Disable Text 1";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button4.Location = new System.Drawing.Point(593, 214);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(129, 36);
			this.button4.TabIndex = 3;
			this.button4.Text = "Enable Text 1";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button5.Location = new System.Drawing.Point(593, 266);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(129, 36);
			this.button5.TabIndex = 6;
			this.button5.Text = "Hide Text 1";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button6.Location = new System.Drawing.Point(593, 318);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(129, 36);
			this.button6.TabIndex = 8;
			this.button6.Text = "Show Text 1";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button7.Location = new System.Drawing.Point(125, 370);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(129, 36);
			this.button7.TabIndex = 9;
			this.button7.Text = "Text 1 to RED";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button8.Location = new System.Drawing.Point(349, 370);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(129, 36);
			this.button8.TabIndex = 10;
			this.button8.Text = "Change form title";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button9.Location = new System.Drawing.Point(349, 214);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(129, 36);
			this.button9.TabIndex = 2;
			this.button9.Text = "Change form COLOR";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SWRomnt", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(177, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(447, 37);
			this.label1.TabIndex = 11;
			this.label1.Text = "This is practice project";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button10.Location = new System.Drawing.Point(349, 266);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(129, 36);
			this.button10.TabIndex = 5;
			this.button10.Text = "Change Label 1";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button11.FlatAppearance.BorderSize = 5;
			this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Location = new System.Drawing.Point(349, 318);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(129, 36);
			this.button11.TabIndex = 13;
			this.button11.TabStop = false;
			this.button11.Text = "Change Label 1";
			this.button11.UseVisualStyleBackColor = false;
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button12.FlatAppearance.BorderSize = 5;
			this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Location = new System.Drawing.Point(593, 370);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(129, 36);
			this.button12.TabIndex = 14;
			this.button12.TabStop = false;
			this.button12.Text = "Change Label 1";
			this.button12.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(288, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBox2.Size = new System.Drawing.Size(235, 29);
			this.textBox2.TabIndex = 15;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.LightCoral;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.btnClose.FlatAppearance.BorderSize = 3;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(364, 468);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 35);
			this.btnClose.TabIndex = 16;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnMain
			// 
			this.btnMain.BackColor = System.Drawing.Color.YellowGreen;
			this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
			this.btnMain.FlatAppearance.BorderSize = 3;
			this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMain.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMain.ForeColor = System.Drawing.Color.Black;
			this.btnMain.Location = new System.Drawing.Point(364, 12);
			this.btnMain.Name = "btnMain";
			this.btnMain.Size = new System.Drawing.Size(88, 35);
			this.btnMain.TabIndex = 17;
			this.btnMain.Text = "Main";
			this.btnMain.UseVisualStyleBackColor = false;
			this.btnMain.Click += new System.EventHandler(this.button13_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 530);
			this.Controls.Add(this.btnMain);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMain;
	}
}

