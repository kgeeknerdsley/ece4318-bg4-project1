using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ece_calculator_bg4
{
    public partial class CervezaCalculator : Form
    {
        public CervezaCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal PAC = 5;
            decimal.TryParse(richTextBox_numDrinks.Text, out decimal numCervezas);
            decimal.TryParse(richTextBox_hours.Text, out decimal numHours);
            decimal.TryParse(richTextBox_minutes.Text, out decimal numMinutes);
            decimal.TryParse(richTextBox_weight.Text, out decimal weightLbs);

            decimal oz = numCervezas * 12;
            decimal totalHours = numHours + (numMinutes / 60);
            decimal bac = ((oz * PAC * 0.075m) / weightLbs) - (totalHours * 0.015m);
            decimal deathNum = ((((0.40m + (totalHours * 0.015m)) * weightLbs) / (12 * PAC * 0.075m))) - numCervezas;
            richTextBox_bac.Text = bac.ToString("F2");
            richTextBox_cervezasDeath.Text = deathNum.ToString("F0");
            //pictureBox_currentGif.Image = beer_gifs.Images[0];
            if (bac > 0.10m)
            {
                linkLabel_alcHelp.Visible = true;
            }
            else linkLabel_alcHelp.Visible = false;
            pictureBox_currentGif.Visible = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CervezaCalculator_Load(object sender, EventArgs e)
        {
            linkLabel_alcHelp.Visible = false;
            pictureBox_currentGif.Visible = false;
        }

        private void linkLabel_alcHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://drugabuse.com/alcohol/hotlines/");
            Process.Start(sInfo);
        }
    }
}
