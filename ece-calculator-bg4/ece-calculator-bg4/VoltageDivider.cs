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
		

        private void GenerateRval_Click(object sender, EventArgs e)
        {
            decimal R1, R2;

            //setting V1 and V2
            int V1 = int.Parse(Vin.Text);
            int V2 = int.Parse(Vout.Text);
            int Mpower = int.Parse(Maxpwr.Text);


            //    PWR = V^2 / R
            int Voltdif = V2 - V1;
            int tempR = (Voltdif * Voltdif) / Mpower;


            // if output is half of input
            if (V2 == (V1/2))
                {
                R1 = V2 / (V1 * 2);
                R1val.Text = R1.ToString();
                R2val.Text = R1.ToString();
                }
            
           



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

        private void label3_Click(object sender, EventArgs e)
        {

        }
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
