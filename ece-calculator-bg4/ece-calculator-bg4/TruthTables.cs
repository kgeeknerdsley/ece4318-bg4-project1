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
    public partial class TruthTables : Form
    {

        public TruthTables()
        {
            InitializeComponent();
        }

        private void nOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Image image = global::ece_calculator_bg4.Properties.Resources.NOT;
			pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void aNDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.AND;
			pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void oRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.OR;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void nANDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.NAND;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void nORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.NOR;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.XOR;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void xNORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.XNOR;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void MUXtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.MUX;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void DEMUXtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.DEMUX;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void threeStateLogicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.TSL;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void dECODER24ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.DECODER;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }

        private void eNCODER24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image image = global::ece_calculator_bg4.Properties.Resources.ENCODER;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;
        }
    }
}
