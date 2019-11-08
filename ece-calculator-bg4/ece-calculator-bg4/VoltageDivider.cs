using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ece_calculator_bg4
{
	public partial class VoltageDivider : Form
	{
		public VoltageDivider()
		{
			InitializeComponent();
		}

        private void voltDivider_picBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VoltageDivider_Load(object sender, EventArgs e)
        {

        }

        private void voltD_page2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GenerateRval_Click(object sender, EventArgs e)
        {
            decimal SR12, BR1, BR2, SR1, SR2; 
            //test 

            decimal V1 = decimal.Parse(Vin.Text);
            decimal V2 = decimal.Parse(Vout.Text);
            // Both R values the same
            SR12 = V2 / (V1 * 2);
            ValOut1.Text = SR12.ToString();





        }

        private void Vin_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ValOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Vout_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
