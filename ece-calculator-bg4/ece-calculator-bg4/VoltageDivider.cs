﻿using System;
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
            label_rload.Visible = checkBox_load.Checked;
            textBox_rload.Visible = checkBox_load.Checked;
            label_voutWarning.Visible = false;

            R1.Visible = Rcheck.Checked;
            label_r1manualEntry.Visible = Rcheck.Checked;

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
                bool accountLoad = checkBox_load.Checked;
                bool vinValid, r1Valid, r2Valid, rlValid;
                decimal rL = 0;


                vinValid = Decimal.TryParse(textbox_vin.Text, out decimal vinEntry);
                r1Valid = Decimal.TryParse(R1_textbox.Text, out decimal r1);
                r2Valid = Decimal.TryParse(R2_textbox.Text, out decimal r2);
                bool inputCheck = vinValid && r1Valid && r2Valid;

                if (accountLoad)
                {
                    rlValid = Decimal.TryParse(textBox_rload.Text, out rL);
                    inputCheck = vinValid && r1Valid && r2Valid && rlValid;
                }

                if (inputCheck)
                {
                    if (r1 < 0 || r2 < 0 || rL < 0)
                    {
                        MessageBox.Show("Enter positive resistor values only.");
                        return;
                    }

                    decimal voutNormal = (vinEntry * (r2 / (r2 + r1)));
                    decimal voutwLoad = 0;
                    if (accountLoad)
                    {
                        voutwLoad = calculateVoutLoad(vinEntry, r1, r2, rL);
                        if (Math.Abs(voutwLoad/voutNormal) < 0.90m)
                        {
                            label_voutWarning.Visible = true;    
                        }

                        else
                        {
                            label_voutWarning.Visible = false;
                        }

                        textBox_vout.Text = voutwLoad.ToString("F2");
                        decimal req = ((r2 * rL) / (r2 + rL));
                        calculatePower(vinEntry, (req + r1));


                    }
                    else
                    {
                        label_voutWarning.Visible = false;
                        textBox_vout.Text = voutNormal.ToString("F2");
                        calculatePower(vinEntry, (r2 + r1));
                    }
                }

                else MessageBox.Show("Please enter positive or negative numbers only.", "You fucked up",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private bool checkforEmptyInputs()
        {
            int vin, r1, r2, rLoad, minLength, sum;
            minLength = 3;

            vin = textbox_vin.TextLength;
            r1 = R1_textbox.TextLength;
            r2 = R2_textbox.TextLength;

            sum = vin + r1 + r2;

            if (checkBox_load.Checked)
            {
                rLoad = textBox_rload.TextLength;
                minLength = 4;
                sum = vin + r1 + r2 + rLoad;
            }

            if (sum < minLength)
            {
                MessageBox.Show("Please enter information for all inputs.");
                return true;
            }
            else return false;
        }

        private decimal calculateVoutLoad(decimal vin, decimal r1, decimal r2, decimal rL)
        {
            decimal req = (r2 * rL) / (r2 + rL);
            return (vin * (req / (req + r1)));
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            textbox_vin.Clear();
            R1_textbox.Clear();
            R2_textbox.Clear();
            textBox_rload.Clear();
            textbox_vin.Focus();
        }

        //not using this function, here in case
        private void checkforNegative(bool[] negFlags)
        {
            String r1Text, r2Text;
            r1Text = R1_textbox.Text;
            r2Text = R2_textbox.Text;
            if (r1Text[0].Equals('-')) negFlags[0] = true;
            if (r2Text[0].Equals('-')) negFlags[1] = true;
        }

        private void calculatePower(decimal vin, decimal req)
        {
            decimal current = vin / req;
            decimal powerMW = (vin * current) * 1000;
            richTextBox_pwr.Text = powerMW.ToString("F5");
        }

        private void textbox_vin_TextChanged(object sender, EventArgs e)
        {
            richTextBox_pwr.Clear();
            textBox_vout.Clear();
            label_voutWarning.Visible = false;
        }

        private void R1_textbox_TextChanged(object sender, EventArgs e)
        {
            richTextBox_pwr.Clear();
            textBox_vout.Clear();
            label_voutWarning.Visible = false;
        }

        private void R2_textbox_TextChanged(object sender, EventArgs e)
        {
            richTextBox_pwr.Clear();
            textBox_vout.Clear();
            label_voutWarning.Visible = false;
        }

        private void checkBox_load_CheckedChanged(object sender, EventArgs e)
        {
            label_rload.Visible = checkBox_load.Checked;
            textBox_rload.Visible = checkBox_load.Checked;
            textBox_rload.Clear();
        }

        private void MaxPower_Click(object sender, EventArgs e)
        {

        }

        private void clear_butt_Click(object sender, EventArgs e)
        {
            R1.Clear();
            Vin.Clear();
            Vout.Clear();
            MaxPower.Clear();
            R1Val.Clear();
            R2Val.Clear();

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            bool emptycheck = EmptyInputs();
            if (!emptycheck)
            {
                decimal R1v, R2v;
                decimal.TryParse(Vin.Text, out decimal vin);
                decimal.TryParse(Vout.Text, out decimal vout);
                decimal.TryParse(MaxPower.Text, out decimal maxpower);

                decimal Rratio = vout / vin;

                if (Rratio >= 1)
                {
                    //show error message and ask to re-enter values
                    //cant have == 1 or greater than 1
                    return;
                }

                // equation for volt divider is Vout = (r2/(r1+r2))*Vin
                if (Rcheck.Checked)
                {   
                    //uses entered value instead of 1000 default
                    decimal.TryParse(R1.Text, out decimal r1);
                    R1v = r1;
                    R2v = (R1v * Rratio) / (1 - Rratio);
                    R1Val.Text = R1v.ToString("F2");
                    R2Val.Text = R2v.ToString("F2");


                }
                else
                {
                    R1v = 1000;
                    R2v = (R1v * Rratio) / (1 - Rratio);
                    //scaleResistors()
                    R1Val.Text = R1v.ToString("F2");
                    R2Val.Text = R2v.ToString("F2");

                    
                }

            }

            else return;




        }

        private bool EmptyInputs()
        {
            int vin, vout, r1, maxpower, sum, mininputs;


            vin = Vin.TextLength;
            vout = Vout.TextLength;
            r1 = R1.TextLength;
            maxpower = MaxPower.TextLength;

            if (Rcheck.Checked)
            {
                mininputs = 4;
            }
            else
            {
                mininputs = 3;
            }
            
            sum = vin + vout + r1 + maxpower;

            if (sum < mininputs)
            {
                MessageBox.Show("Please enter all neecessary inputs.");
                return true;
            }
            else return false;

        }

        private void textBox_vout_TextChanged(object sender, EventArgs e)
        {

        }

        private void R1Val_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rcheck_CheckedChanged(object sender, EventArgs e)
        {
            label_r1manualEntry.Visible = Rcheck.Checked;
            R1.Visible = Rcheck.Checked;
            R1.Clear();
        }

        /*
        private void scaleResistors()
        {
            Takes in R1 and R2 after calculation above
            Multiplier = 1
            calculates power

            while (power >= Maxpower)
                multiplier++ or multiplier = multiplier*10
                R1new = R1*Multiplier
                R2new = R2*multiplier
                re calculate power

            return scaled Resistor values
        }
        */
    }


}

