using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main3
{
    public partial class frPizzaOrderForm : Form
    {

        float Price = 0;
        public frPizzaOrderForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
      
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Size: ");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                lbSize.Text = "Small";
                //Console.WriteLine("Small");
            }
            else if (rbMedium.Checked)
            {
                lbSize.Text = "Medium";

                //Console.WriteLine("Medium");
            }
            else
            {
                lbSize.Text = "Large";

                //Console.WriteLine("Large");
            }
        }

        private void rbSmall_MouseClick(object sender, MouseEventArgs e)
        {
            lbSize.Text = "Small";

            Price += 10;
       
            lbTotalPrice.Text = Price.ToString();
        }

        private void rbMedium_MouseClick(object sender, MouseEventArgs e)
        {
            lbSize.Text = "Medium";
            Price += 15;

            lbTotalPrice.Text = Price.ToString();
        }

        private void rbLarge_MouseClick(object sender, MouseEventArgs e)
        {
            lbSize.Text = "Large";
            Price += 20;

            lbTotalPrice.Text = Price.ToString();
        }

        private void gbTotalPrice_Enter(object sender, EventArgs e)
        {

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
            float price = 0;
        }

		private void rbSmall_CheckedChanged(object sender, EventArgs e)
		{
      
		}

		private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
		{
      if (chkExtraCheese.Checked == true)
      {

      }
		}

		private void gbOrderSummary_Enter(object sender, EventArgs e)
		{

		}

		private void btOrderPizza_Click(object sender, EventArgs e)
		{
      gbSize.Enabled = false;
			gbCrustType.Enabled = false;
			gbToppings.Enabled = false;
			gbWhereToEat.Enabled = false;

      MessageBox.Show("Successfully Ordered");
		}

		private void btResetForm_Click(object sender, EventArgs e)
		{
			gbSize.Enabled = true;
			gbCrustType.Enabled = true;
			gbToppings.Enabled = true;
			gbWhereToEat.Enabled = true;
		}

		private void lbToppings_Click(object sender, EventArgs e)
		{

		}
	}
}
