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
            comboBox1.SelectedIndex = 0;
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

            Graphics myGraphics0 = base.CreateGraphics();
            SolidBrush mySolidBrush0 = new SolidBrush(Color.Black);
            if(comboBox1.SelectedIndex != 0)
            {
                switch (value0.SelectedIndex)
                {
                    case 0:
                        mySolidBrush0 = new SolidBrush(Color.Black);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 1:
                        mySolidBrush0 = new SolidBrush(Color.Brown);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 2:
                        mySolidBrush0 = new SolidBrush(Color.Red);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 3:
                        mySolidBrush0 = new SolidBrush(Color.Orange);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 4:
                        mySolidBrush0 = new SolidBrush(Color.Yellow);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 5:
                        mySolidBrush0 = new SolidBrush(Color.Green);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 6:
                        mySolidBrush0 = new SolidBrush(Color.Blue);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 7:
                        mySolidBrush0 = new SolidBrush(Color.Violet);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 8:
                        mySolidBrush0 = new SolidBrush(Color.Gray);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                    case 9:
                        mySolidBrush0 = new SolidBrush(Color.White);
                        myGraphics0.FillRectangle(mySolidBrush0, 50, 50, 50, 150);
                        break;
                }
            }
            
        }
        private void value1_changed(object sender, EventArgs e)
        {
            temp_resistance /= 10;
            temp_resistance *= 10;
            temp_resistance += value1.SelectedIndex;
            calculate();
            final_value(sender, e);
            Graphics myGraphics1 = base.CreateGraphics();
            SolidBrush mySolidBrush1 = new SolidBrush(Color.Black);
            if(comboBox1.SelectedIndex != 0)
            {
                switch (value1.SelectedIndex)
                {
                    case 0:
                        mySolidBrush1 = new SolidBrush(Color.Black);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 1:
                        mySolidBrush1 = new SolidBrush(Color.Brown);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 2:
                        mySolidBrush1 = new SolidBrush(Color.Red);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 3:
                        mySolidBrush1 = new SolidBrush(Color.Orange);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 4:
                        mySolidBrush1 = new SolidBrush(Color.Yellow);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 5:
                        mySolidBrush1 = new SolidBrush(Color.Green);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 6:
                        mySolidBrush1 = new SolidBrush(Color.Blue);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 7:
                        mySolidBrush1 = new SolidBrush(Color.Violet);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 8:
                        mySolidBrush1 = new SolidBrush(Color.Gray);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                    case 9:
                        mySolidBrush1 = new SolidBrush(Color.White);
                        myGraphics1.FillRectangle(mySolidBrush1, 150, 50, 50, 150);
                        break;
                }
            }
            
        }

        private void multiplier_changed(object sender, EventArgs e)
        {
            calculate();
            final_value(sender, e);
            Graphics myGraphics2 = base.CreateGraphics();
            SolidBrush mySolidBrush2 = new SolidBrush(Color.Black);
            if(comboBox1.SelectedIndex != 0)
            {
                switch (multiplier.SelectedIndex)
                {
                    case 0:
                        mySolidBrush2 = new SolidBrush(Color.Black);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 1:
                        mySolidBrush2 = new SolidBrush(Color.Brown);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 2:
                        mySolidBrush2 = new SolidBrush(Color.Red);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 3:
                        mySolidBrush2 = new SolidBrush(Color.Orange);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 4:
                        mySolidBrush2 = new SolidBrush(Color.Yellow);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 5:
                        mySolidBrush2 = new SolidBrush(Color.Green);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 6:
                        mySolidBrush2 = new SolidBrush(Color.Blue);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 7:
                        mySolidBrush2 = new SolidBrush(Color.Violet);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 8:
                        mySolidBrush2 = new SolidBrush(Color.Gray);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                    case 9:
                        mySolidBrush2 = new SolidBrush(Color.White);
                        myGraphics2.FillRectangle(mySolidBrush2, 250, 50, 50, 150);
                        break;
                }
            }
            
        }

        private void tolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics myGraphics3 = base.CreateGraphics();
            SolidBrush mySolidBrush3 = new SolidBrush(Color.Black);
            if (comboBox1.SelectedIndex != 0)
            {
                switch (tolerance.SelectedIndex)
                {
                    case 0:
                        toler = "5%";
                        mySolidBrush3 = new SolidBrush(Color.Gold);
                        myGraphics3.FillRectangle(mySolidBrush3, 350, 50, 50, 150);
                        break;
                    case 1:
                        toler = "10%";
                        mySolidBrush3 = new SolidBrush(Color.Silver);
                        myGraphics3.FillRectangle(mySolidBrush3, 350, 50, 50, 150);
                        break;
                }
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
            if (i > 2)
                textBox1.Text = temp + " GΩ";
            else if (i > 1)
                textBox1.Text = temp + " MΩ";
            else if (i > 0)
                textBox1.Text = temp + " KΩ";
            else if (i == 0)
                textBox1.Text = temp + " Ω";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics myGraphics4 = base.CreateGraphics();
            SolidBrush mySolidBrush4 = new SolidBrush(Color.SandyBrown);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.Invalidate();
                    break;
                case 1:
                    mySolidBrush4 = new SolidBrush(Color.SandyBrown);
                    myGraphics4.FillRectangle(mySolidBrush4, 25, 50, 450, 150);
                    break;
                case 2:
                    SolidBrush mySolidBrush = new SolidBrush(Color.DarkBlue);
                    myGraphics4.FillRectangle(mySolidBrush, 25, 50, 450, 150);
                    break;
            }

    }
    }
}
