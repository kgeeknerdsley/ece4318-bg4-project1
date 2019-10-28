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

		private void filterCalcStart_Click(object sender, EventArgs e)
		{
			FilterCalculator filterCalc = new FilterCalculator(); //all forms are classes, make a new instance
			filterCalc.Show();//show the new form
		}

		private void resistorCalcStart_Click(object sender, EventArgs e)
		{
			ResistorColor resistorCalc = new ResistorColor();
			resistorCalc.Show();
		}

		private void voltageDivStart_Click(object sender, EventArgs e)
		{
			VoltageDivider voltDiv = new VoltageDivider();
			voltDiv.Show();
		}

		private void commonChipStart_Click(object sender, EventArgs e)
		{
			CommonChipPins comChipPin = new CommonChipPins();
			comChipPin.Show();
		}

		private void truthTableStart_Click(object sender, EventArgs e)
		{
			TruthTables truthTable = new TruthTables();
			truthTable.Show();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Credit: \n" +
				"RLC Filter: Robert Herndon, Kevin Worsley \n" +
				"Voltage Divider: Rafed El-Issa, Cameron Wu\n" +
				"Resistor Color Code: Josiah DeLeon, Keane Ong\n" +
				"Common Chip Pinouts: Grant Genie, Eun Koo\n" +
				"Truth Tables: Steven Baker, Daniel Heer");
		}
	}
}