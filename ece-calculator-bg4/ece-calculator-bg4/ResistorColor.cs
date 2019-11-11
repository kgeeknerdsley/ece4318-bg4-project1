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
	public partial class ResistorColor : Form
	{
		public ResistorColor()
		{
			InitializeComponent();
            value0.SelectedIndex = 0;
            value1.SelectedIndex = 0;
            multiplier.SelectedIndex = 0;
            tolerance.SelectedIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
		}

        int temp_resistance = 0;
        double resistance = 0;
        double power = 0;
        string toler;


        private void value0_changed(object sender, EventArgs e)
        {
            temp_resistance = temp_resistance % 10;
            temp_resistance += (value0.SelectedIndex * 10);
            calculate();
            final_value(sender, e);
        }

        private void value1_changed(object sender, EventArgs e)
        {
            temp_resistance /= 10;
            temp_resistance *= 10;
            temp_resistance += value1.SelectedIndex;
            calculate();
            final_value(sender, e);
        }

        private void multiplier_changed(object sender, EventArgs e)
        {
            calculate();
            final_value(sender, e);
        }

        private void tolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tolerance.SelectedIndex)
            {
                case 0:
                    toler = "5%";
                    break;
                case 1:
                    toler = "10%";
                    break;
            }
            label6.Text = "+- " + toler;
        }
        void calculate()
        {
            power = Math.Pow(10, multiplier.SelectedIndex);
            resistance = temp_resistance * power;
        }

        private void final_value(object sender, EventArgs e)
        {
            int i;
            for (i = 0; resistance >= 1000; i++)
                resistance /= 1000;

            string temp = resistance.ToString();
            if(i > 2)
                textBox1.Text = temp + " GΩ";
            else if(i > 1)
                textBox1.Text = temp + " MΩ";
            else if( i > 0)
                textBox1.Text = temp + " KΩ";
            else if(i == 0)
                textBox1.Text = temp + " Ω";

        }
	}
}
