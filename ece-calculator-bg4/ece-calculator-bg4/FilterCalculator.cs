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
	public partial class FilterCalculator : Form
	{
		public FilterCalculator()
		{
			InitializeComponent();
		}

		//0 = low pass
		//1 = high pass
		//2 = band pass
		//3 = band stop
		int calcType = 0;
		string calcSelection;

		//List<TextBox> listOfBoxes = new List<TextBox>();

		//When calculator button clicked:
		//Detect the missing variable
		//Ensure all filled boxes have only numerical values
		//If more than one is missing, show a dialog
		//Calculate the missing variable
		//Use the unit dropdown to change the input units

		private void selectFilterType_SelectedIndexChanged(object sender, EventArgs e)
		{
			calcSelection = selectFilterType.SelectedItem.ToString();

			//figures out what calculator is selected
			switch(calcSelection)
			{
				case "Low Pass":
					calcType = 0;
					circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.lowpass_placeholder;
					break;
				case "High Pass":
					calcType = 1;
					circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.highpass_placeholder;
					break;
				case "Band Pass":
					circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.bandpass_placeholder;
					calcType = 2;
					break;
				case "Band Stop":
					calcType = 3;
					circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.bandstop_placeholder;
					break;
			}

			//clear all the boxes when calculator type switches
			R1Box.Text = "";
			R2Box.Text = "";
			C1Box.Text = "";
			C2Box.Text = "";
			fcBox.Text = "";
		}

		private void startFilterCalc_Click(object sender, EventArgs e)
		{
			int missingBox = -1;
			int blankCount = 0;
			float r1_val = -1;
			float r2_val = -1;
			float c1_val = -1;
			float c2_val = -1;
			float fc_val = -1;

			//determine if we have 1 or 2 RCs
			if(calcType == 0 || calcType == 1) //working with low and high pass here
			{

				R2Box.Text = "Unused";
				C2Box.Text = "Unused";

				//check for the box with a -1, if it's -1 that means it's blank

				if(isElementMissing(R1Box)) //0 is missing r1
				{
					missingBox = 0;
					blankCount++;
				}

				if (isElementMissing(C1Box)) //1 is missing c1
				{
					missingBox = 1;
					blankCount++;
				}

				if (isElementMissing(fcBox)) //2 is missing fc
				{
					missingBox = 2;
					blankCount++;
				}
				
				if(blankCount > 1) //if too many missing
				{
					MessageBox.Show("Only one box may be blank. Please fill in missing variables.");
				} else if(blankCount < 1) //if nothing missing
				{
					MessageBox.Show("You must leave one box blank to complete the calculation.");
				} else //if we pass those checks
				{
					//if any of the try parse fails, it won't continue
					if(validateNumerical(ref r1_val, ref c1_val, ref fc_val, missingBox))
					{
						//MessageBox.Show(r1_val.ToString() + " " + c1_val.ToString() + " " + fc_val.ToString());
						if(missingBox == 0)
						{
							R1Box.Text = calculateLP_HP(r1_val, c1_val, fc_val).ToString();
						} else if(missingBox == 1)
						{
							C1Box.Text = calculateLP_HP(r1_val, c1_val, fc_val).ToString();
						} else if(missingBox == 2)
						{
							fcBox.Text = calculateLP_HP(r1_val, c1_val, fc_val).ToString();
						}

						
					} else
					{
						MessageBox.Show("All inputs must be numerical input only!");
					}
				}
			} else
			{
				MessageBox.Show("Band pass or stop");
			}
		}

		private bool isElementMissing(TextBox box)
		{
			bool result = false;

			if(box.TextLength == 0)
			{
				result = true;
			}

			return result;
		}

		private float r1UnitMultiplier()
		{
			string units = r1Units.Text;
			float result = -1;

			

			return result;
		}

		private float unitMultiplier(TextBox box)
		{
			string units = box.Text;
			float result = -1;

			if(box == R1Box || box == R2Box)
			{
				if(units == "Ω")
				{
					result = (float)1;
				} else if(units == "kΩ")
				{
					result = (float)1000;
				} else if(units == "MΩ")
				{
					result = (float)1000000;
				}
			} else
			{
				if (units == "F")
				{
					result = (float)1;
				}
				else if (units == "μF")
				{
					result = (float)0.00001;
				}
				else if (units == "nF")
				{
					result = (float)0.000000001;
				}
				else if (units == "pF")
				{
					result = (float)0.000000000001;
				}
			}

			return result;
		}

		private float calculateLP_HP(float r1, float c1, float fc)
		{
			float result = -1;

			if(r1 == -1) //if resistor 1 is missing
			{
				result = (float)(1.0 / (2 * Math.PI * (c1*unitMultiplier(C1Box)) * fc));
			} else if(c1 == -1)
			{
				result = (float)(1.0 / (2 * Math.PI * (r1*unitMultiplier(R1Box)) * fc));
			} else
			{
				result = (float)(1.0 / (2 * Math.PI * (c1*unitMultiplier(C1Box)) * (r1*unitMultiplier(R1Box))));
			}

			
			return result;
		}

		private bool validateNumerical(ref float r1, ref float c1, ref float fc, int missingBox)
		{
			bool result = false;
			bool r1_success = false;
			bool c1_success = false;
			bool fc_success = false;

			switch (missingBox)
			{
				case 0:
					c1_success = float.TryParse(C1Box.Text, out c1);
					fc_success = float.TryParse(fcBox.Text, out fc);
					//return c1_success && fc_success;
					result = c1_success && fc_success;
					break;
				case 1:
					r1_success = float.TryParse(R1Box.Text, out r1);
					fc_success = float.TryParse(fcBox.Text, out fc);
					result = r1_success && fc_success;
					break;
				case 2:
					r1_success = float.TryParse(R1Box.Text, out r1);
					c1_success = float.TryParse(C1Box.Text, out c1);
					result = r1_success && c1_success;
					break;
			}

			return result;
		}

		private bool validateNumerical(ref float r1, ref float r2, ref float c1, ref float c2, ref float fc, int missingBox)
		{
			return false;
		}
	}
}