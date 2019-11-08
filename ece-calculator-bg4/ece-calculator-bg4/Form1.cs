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

		//Initialize all forms, but set them to null
		//This lets us see if they've actually been created or are just empty pointers
		//Then we can ensure we're only generating the form once
		FilterCalculator filterCalc = null;
		ResistorColor resistorCalc = null;
		TruthTables truthTable = null;
		CommonChipPins comChipPin = null;
		VoltageDivider voltDiv = null;

		private void filterCalcStart_Click(object sender, EventArgs e)
		{
			if(filterCalc == null)
			{
				filterCalc = new FilterCalculator();  //all forms are classes, make a new instance
				filterCalc.Show();//show the new form
			} else
			{
				filterCalc.BringToFront();
			}	
		}

		private void resistorCalcStart_Click(object sender, EventArgs e)
		{
			if(resistorCalc == null)
			{
				resistorCalc = new ResistorColor();
				resistorCalc.Show();
			} else
			{
				resistorCalc.BringToFront();
			}

			
		}

		private void voltageDivStart_Click(object sender, EventArgs e)
		{
			if(voltDiv == null)
			{
				voltDiv = new VoltageDivider();
				voltDiv.Show();
			} else
			{
				voltDiv.BringToFront();
			}

		}

		private void commonChipStart_Click(object sender, EventArgs e)
		{
			if(comChipPin == null)
			{
				comChipPin = new CommonChipPins();
				comChipPin.Show();
			} else
			{
				comChipPin.BringToFront();
			}
			
		}

		private void truthTableStart_Click(object sender, EventArgs e)
		{
			if(truthTable == null)
			{
				truthTable = new TruthTables();
				truthTable.Show();
			} else
			{
				truthTable.BringToFront();
			}

			
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