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


        private void button_calcVout_Click_1(object sender, EventArgs e)
        {
            bool isEmpty = checkforEmptyInputs();
            if (!isEmpty)
            {
                bool vinValid, r1Valid, r2Valid;
                vinValid = Decimal.TryParse(textbox_vin.Text, out decimal vinEntry);
                r1Valid = UInt16.TryParse(R1_textbox.Text, out ushort r1);
                r2Valid = UInt16.TryParse(R2_textbox.Text, out ushort r2);

                if (vinValid && r1Valid && r2Valid)
                {
                
                    //if valid calculate Vout
                    decimal vout = (vinEntry * ((decimal)r2 / (r2 + r1)));
                    textBox_vout.Text = vout.ToString();
                }

                else MessageBox.Show("Please enter numbers only", "You fucked up",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private bool checkforEmptyInputs()
        {
            int vin, r1, r2;
            vin = textbox_vin.TextLength;
            r1 = R1_textbox.TextLength;
            r2 = R2_textbox.TextLength;

            if ((vin + r1 + r2) < 3)
            {
                MessageBox.Show("Please enter information for all inputs.");
                return true;
            }
            else return false;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textbox_vin.Clear();
            R1_textbox.Clear();
            R2_textbox.Clear();
            textbox_vin.Focus();
        }
    }
}
