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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FilterCalculator filterCalc = new FilterCalculator(); //all forms are classes, make a new instance
			filterCalc.Show();//show the new form
		}

		private void filterCalcStart_Click(object sender, EventArgs e)
		{
			FilterCalculator filterCalc = new FilterCalculator(); //all forms are classes, make a new instance
			filterCalc.Show();//show the new form
		}
	}
}