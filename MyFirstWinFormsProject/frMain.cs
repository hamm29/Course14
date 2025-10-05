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
	public partial class frMain : Form
	{
		public frMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form frm1 = new Form1();

			frm1.Show();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Form frm = new Form1();
			frm.ShowDialog();
		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			Form frm1 = new frmMessageBox();
			frm1.Show();
		}

		private void button1_Click_3(object sender, EventArgs e)
		{
			Form frm = new Form3();
			frm.Show();
		}
	}
}
