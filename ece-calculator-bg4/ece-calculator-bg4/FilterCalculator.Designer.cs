namespace ece_calculator_bg4
{
	partial class FilterCalculator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.selectFilterType = new System.Windows.Forms.ComboBox();
			this.dropdownInstruction = new System.Windows.Forms.Label();
			this.circuitDisplay = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.circuitDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// selectFilterType
			// 
			this.selectFilterType.FormattingEnabled = true;
			this.selectFilterType.Items.AddRange(new object[] {
            "Low Pass",
            "High Pass",
            "Band Pass",
            "Band Stop"});
			this.selectFilterType.Location = new System.Drawing.Point(76, 18);
			this.selectFilterType.Name = "selectFilterType";
			this.selectFilterType.Size = new System.Drawing.Size(121, 21);
			this.selectFilterType.TabIndex = 0;
			this.selectFilterType.SelectedIndexChanged += new System.EventHandler(this.selectFilterType_SelectedIndexChanged);
			// 
			// dropdownInstruction
			// 
			this.dropdownInstruction.AutoSize = true;
			this.dropdownInstruction.Location = new System.Drawing.Point(12, 18);
			this.dropdownInstruction.Name = "dropdownInstruction";
			this.dropdownInstruction.Size = new System.Drawing.Size(58, 13);
			this.dropdownInstruction.TabIndex = 1;
			this.dropdownInstruction.Text = "Filter type: ";
			// 
			// circuitDisplay
			// 
			this.circuitDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.circuitDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.lowpass_placeholder;
			this.circuitDisplay.InitialImage = global::ece_calculator_bg4.Properties.Resources.lowpass_placeholder;
			this.circuitDisplay.Location = new System.Drawing.Point(3, 105);
			this.circuitDisplay.Name = "circuitDisplay";
			this.circuitDisplay.Size = new System.Drawing.Size(550, 350);
			this.circuitDisplay.TabIndex = 2;
			this.circuitDisplay.TabStop = false;
			// 
			// FilterCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 601);
			this.Controls.Add(this.circuitDisplay);
			this.Controls.Add(this.dropdownInstruction);
			this.Controls.Add(this.selectFilterType);
			this.Name = "FilterCalculator";
			this.Text = "RC Filter Calculator";
			((System.ComponentModel.ISupportInitialize)(this.circuitDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox selectFilterType;
		private System.Windows.Forms.Label dropdownInstruction;
		private System.Windows.Forms.PictureBox circuitDisplay;
	}
}