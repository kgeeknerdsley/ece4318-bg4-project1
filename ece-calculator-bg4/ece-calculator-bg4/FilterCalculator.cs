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


		}
	}
}
