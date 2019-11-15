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
			this.R1Box = new System.Windows.Forms.TextBox();
			this.R2Box = new System.Windows.Forms.TextBox();
			this.C1Box = new System.Windows.Forms.TextBox();
			this.C2Box = new System.Windows.Forms.TextBox();
			this.fcBox = new System.Windows.Forms.TextBox();
			this.startFilterCalc = new System.Windows.Forms.Button();
			this.r1Label = new System.Windows.Forms.Label();
			this.r2Label = new System.Windows.Forms.Label();
			this.c1Label = new System.Windows.Forms.Label();
			this.c2Label = new System.Windows.Forms.Label();
			this.fcLabel = new System.Windows.Forms.Label();
			this.r1Units = new System.Windows.Forms.ComboBox();
			this.r2Units = new System.Windows.Forms.ComboBox();
			this.fcUnitLabel = new System.Windows.Forms.Label();
			this.c1Units = new System.Windows.Forms.ComboBox();
			this.c2Units = new System.Windows.Forms.ComboBox();
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
			this.selectFilterType.Text = "Low Pass";
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
			// R1Box
			// 
			this.R1Box.Location = new System.Drawing.Point(618, 75);
			this.R1Box.Name = "R1Box";
			this.R1Box.Size = new System.Drawing.Size(75, 20);
			this.R1Box.TabIndex = 3;
			// 
			// R2Box
			// 
			this.R2Box.Location = new System.Drawing.Point(618, 140);
			this.R2Box.Name = "R2Box";
			this.R2Box.Size = new System.Drawing.Size(75, 20);
			this.R2Box.TabIndex = 4;
			// 
			// C1Box
			// 
			this.C1Box.Location = new System.Drawing.Point(618, 209);
			this.C1Box.Name = "C1Box";
			this.C1Box.Size = new System.Drawing.Size(75, 20);
			this.C1Box.TabIndex = 5;
			// 
			// C2Box
			// 
			this.C2Box.Location = new System.Drawing.Point(618, 275);
			this.C2Box.Name = "C2Box";
			this.C2Box.Size = new System.Drawing.Size(75, 20);
			this.C2Box.TabIndex = 6;
			// 
			// fcBox
			// 
			this.fcBox.Location = new System.Drawing.Point(619, 332);
			this.fcBox.Name = "fcBox";
			this.fcBox.Size = new System.Drawing.Size(75, 20);
			this.fcBox.TabIndex = 7;
			// 
			// startFilterCalc
			// 
			this.startFilterCalc.Location = new System.Drawing.Point(576, 374);
			this.startFilterCalc.Name = "startFilterCalc";
			this.startFilterCalc.Size = new System.Drawing.Size(170, 35);
			this.startFilterCalc.TabIndex = 9;
			this.startFilterCalc.Text = "Calculate";
			this.startFilterCalc.UseVisualStyleBackColor = true;
			this.startFilterCalc.Click += new System.EventHandler(this.startFilterCalc_Click);
			// 
			// r1Label
			// 
			this.r1Label.AutoSize = true;
			this.r1Label.Location = new System.Drawing.Point(572, 82);
			this.r1Label.Name = "r1Label";
			this.r1Label.Size = new System.Drawing.Size(27, 13);
			this.r1Label.TabIndex = 10;
			this.r1Label.Text = "R1: ";
			// 
			// r2Label
			// 
			this.r2Label.AutoSize = true;
			this.r2Label.Location = new System.Drawing.Point(572, 147);
			this.r2Label.Name = "r2Label";
			this.r2Label.Size = new System.Drawing.Size(27, 13);
			this.r2Label.TabIndex = 11;
			this.r2Label.Text = "R2: ";
			// 
			// c1Label
			// 
			this.c1Label.AutoSize = true;
			this.c1Label.Location = new System.Drawing.Point(572, 215);
			this.c1Label.Name = "c1Label";
			this.c1Label.Size = new System.Drawing.Size(26, 13);
			this.c1Label.TabIndex = 12;
			this.c1Label.Text = "C1: ";
			// 
			// c2Label
			// 
			this.c2Label.AutoSize = true;
			this.c2Label.Location = new System.Drawing.Point(573, 278);
			this.c2Label.Name = "c2Label";
			this.c2Label.Size = new System.Drawing.Size(26, 13);
			this.c2Label.TabIndex = 13;
			this.c2Label.Text = "C2: ";
			// 
			// fcLabel
			// 
			this.fcLabel.AutoSize = true;
			this.fcLabel.Location = new System.Drawing.Point(577, 332);
			this.fcLabel.Name = "fcLabel";
			this.fcLabel.Size = new System.Drawing.Size(22, 13);
			this.fcLabel.TabIndex = 14;
			this.fcLabel.Text = "fc: ";
			// 
			// r1Units
			// 
			this.r1Units.FormattingEnabled = true;
			this.r1Units.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
			this.r1Units.Location = new System.Drawing.Point(699, 74);
			this.r1Units.Name = "r1Units";
			this.r1Units.Size = new System.Drawing.Size(39, 21);
			this.r1Units.TabIndex = 16;
			this.r1Units.Text = "Ω";
			// 
			// r2Units
			// 
			this.r2Units.FormattingEnabled = true;
			this.r2Units.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
			this.r2Units.Location = new System.Drawing.Point(699, 140);
			this.r2Units.Name = "r2Units";
			this.r2Units.Size = new System.Drawing.Size(39, 21);
			this.r2Units.TabIndex = 17;
			this.r2Units.Text = "Ω";
			// 
			// fcUnitLabel
			// 
			this.fcUnitLabel.AutoSize = true;
			this.fcUnitLabel.Location = new System.Drawing.Point(699, 338);
			this.fcUnitLabel.Name = "fcUnitLabel";
			this.fcUnitLabel.Size = new System.Drawing.Size(57, 13);
			this.fcUnitLabel.TabIndex = 18;
			this.fcUnitLabel.Text = "Hz (1/sec)";
			// 
			// c1Units
			// 
			this.c1Units.FormattingEnabled = true;
			this.c1Units.Items.AddRange(new object[] {
            "F",
            "μF",
            "nF",
            "pF"});
			this.c1Units.Location = new System.Drawing.Point(699, 207);
			this.c1Units.Name = "c1Units";
			this.c1Units.Size = new System.Drawing.Size(39, 21);
			this.c1Units.TabIndex = 19;
			this.c1Units.Text = "μF";
			// 
			// c2Units
			// 
			this.c2Units.FormattingEnabled = true;
			this.c2Units.Items.AddRange(new object[] {
            "F",
            "μF",
            "nF",
            "pF"});
			this.c2Units.Location = new System.Drawing.Point(699, 274);
			this.c2Units.Name = "c2Units";
			this.c2Units.Size = new System.Drawing.Size(39, 21);
			this.c2Units.TabIndex = 20;
			this.c2Units.Text = "μF";
			// 
			// circuitDisplay
			// 
			this.circuitDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.circuitDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.circuitDisplay.Image = global::ece_calculator_bg4.Properties.Resources.lowpass_final;
			this.circuitDisplay.InitialImage = global::ece_calculator_bg4.Properties.Resources.lowpass_placeholder;
			this.circuitDisplay.Location = new System.Drawing.Point(12, 59);
			this.circuitDisplay.Name = "circuitDisplay";
			this.circuitDisplay.Size = new System.Drawing.Size(550, 350);
			this.circuitDisplay.TabIndex = 2;
			this.circuitDisplay.TabStop = false;
			// 
			// FilterCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 430);
			this.Controls.Add(this.c2Units);
			this.Controls.Add(this.c1Units);
			this.Controls.Add(this.fcUnitLabel);
			this.Controls.Add(this.r2Units);
			this.Controls.Add(this.r1Units);
			this.Controls.Add(this.fcLabel);
			this.Controls.Add(this.c2Label);
			this.Controls.Add(this.c1Label);
			this.Controls.Add(this.r2Label);
			this.Controls.Add(this.r1Label);
			this.Controls.Add(this.startFilterCalc);
			this.Controls.Add(this.fcBox);
			this.Controls.Add(this.C2Box);
			this.Controls.Add(this.C1Box);
			this.Controls.Add(this.R2Box);
			this.Controls.Add(this.R1Box);
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
		private System.Windows.Forms.TextBox R1Box;
		private System.Windows.Forms.TextBox R2Box;
		private System.Windows.Forms.TextBox C1Box;
		private System.Windows.Forms.TextBox C2Box;
		private System.Windows.Forms.TextBox fcBox;
		private System.Windows.Forms.Button startFilterCalc;
		private System.Windows.Forms.Label r1Label;
		private System.Windows.Forms.Label r2Label;
		private System.Windows.Forms.Label c1Label;
		private System.Windows.Forms.Label c2Label;
		private System.Windows.Forms.Label fcLabel;
		private System.Windows.Forms.ComboBox r1Units;
		private System.Windows.Forms.ComboBox r2Units;
		private System.Windows.Forms.Label fcUnitLabel;
		private System.Windows.Forms.ComboBox c1Units;
		private System.Windows.Forms.ComboBox c2Units;
	}
}