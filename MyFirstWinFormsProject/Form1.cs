﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			textBox2.Text = textBox1.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox2.Text = textBox1.Text;

			label1.Text = textBox1.Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Enabled = false;

			button1.Enabled = false;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Enabled = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Visible = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Visible = true;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Red;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Text = "KOKO";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.Green;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			label1.Text = "Hammad Muslim Abdu-ussattar";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Form frmMain = new frMain();
			frmMain.Show();
		}
	}
}
