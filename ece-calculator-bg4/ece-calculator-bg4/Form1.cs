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
			if(!isFormOpen("FilterCalculator"))
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
			if(!isFormOpen("ResistorColor"))
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
			if(!isFormOpen("VoltageDivider"))
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
			if(!isFormOpen("CommonChipPins"))
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
			if(!isFormOpen("TruthTables"))
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

		private bool isFormOpen(string formName)
		{
			bool result = false;

			foreach(var item in Application.OpenForms) //iterate through the collection of open forms
			{
				if(item.GetType().Name == formName)
				{
					result = true; //if we find a form with the type we want, return true
				}
			}
			return result; //otherwise return false
		}
    }
}