namespace MyFirstWinFormsProject
{
	partial class frMain
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
			this.btnShowPart1 = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnShowAsDialog = new System.Windows.Forms.Button();
			this.btnShowMessageBoxForm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShowPart1
			// 
			this.btnShowPart1.Location = new System.Drawing.Point(149, 131);
			this.btnShowPart1.Name = "btnShowPart1";
			this.btnShowPart1.Size = new System.Drawing.Size(209, 72);
			this.btnShowPart1.TabIndex = 0;
			this.btnShowPart1.Text = "Show Part1";
			this.btnShowPart1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnShowPart1.UseVisualStyleBackColor = true;
			this.btnShowPart1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.LightCoral;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
			this.btnClose.FlatAppearance.BorderSize = 3;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Rockwell Nova", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(366, 368);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(88, 35);
			this.btnClose.TabIndex = 17;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnShowAsDialog
			// 
			this.btnShowAsDialog.Location = new System.Drawing.Point(149, 226);
			this.btnShowAsDialog.Name = "btnShowAsDialog";
			this.btnShowAsDialog.Size = new System.Drawing.Size(209, 72);
			this.btnShowAsDialog.TabIndex = 18;
			this.btnShowAsDialog.Text = "Show Form as Dialog";
			this.btnShowAsDialog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnShowAsDialog.UseVisualStyleBackColor = true;
			this.btnShowAsDialog.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnShowMessageBoxForm
			// 
			this.btnShowMessageBoxForm.Location = new System.Drawing.Point(388, 131);
			this.btnShowMessageBoxForm.Name = "btnShowMessageBoxForm";
			this.btnShowMessageBoxForm.Size = new System.Drawing.Size(209, 72);
			this.btnShowMessageBoxForm.TabIndex = 19;
			this.btnShowMessageBoxForm.Text = "Show Message box form";
			this.btnShowMessageBoxForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btnShowMessageBoxForm.UseVisualStyleBackColor = true;
			this.btnShowMessageBoxForm.Click += new System.EventHandler(this.button1_Click_2);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(388, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(209, 72);
			this.button1.TabIndex = 20;
			this.button1.Text = "Check Box/ Radio/ Group";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_3);
			// 
			// frMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnShowMessageBoxForm);
			this.Controls.Add(this.btnShowAsDialog);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnShowPart1);
			this.Name = "frMain";
			this.Text = "Main Form";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShowPart1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnShowAsDialog;
		private System.Windows.Forms.Button btnShowMessageBoxForm;
		private System.Windows.Forms.Button button1;
	}
}