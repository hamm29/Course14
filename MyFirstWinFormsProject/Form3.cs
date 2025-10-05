using System;
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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			button1.Enabled = checkBox1.Checked;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(checkBox1.Checked.ToString());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(rbSmall.Checked.ToString());
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			gbSize.Enabled = false;
		}
	}
}
