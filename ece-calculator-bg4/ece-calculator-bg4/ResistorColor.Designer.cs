namespace ece_calculator_bg4
{
	partial class ResistorColor
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
            this.value0 = new System.Windows.Forms.ComboBox();
            this.value1 = new System.Windows.Forms.ComboBox();
            this.multiplier = new System.Windows.Forms.ComboBox();
            this.tolerance = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // value0
            // 
            this.value0.FormattingEnabled = true;
            this.value0.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey",
            "White"});
            this.value0.Location = new System.Drawing.Point(197, 276);
            this.value0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.value0.Name = "value0";
            this.value0.Size = new System.Drawing.Size(160, 24);
            this.value0.TabIndex = 0;
            this.value0.SelectedIndexChanged += new System.EventHandler(this.value0_changed);
            // 
            // value1
            // 
            this.value1.FormattingEnabled = true;
            this.value1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey",
            "White"});
            this.value1.Location = new System.Drawing.Point(367, 276);
            this.value1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(160, 24);
            this.value1.TabIndex = 1;
            this.value1.SelectedIndexChanged += new System.EventHandler(this.value1_changed);
            // 
            // multiplier
            // 
            this.multiplier.FormattingEnabled = true;
            this.multiplier.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey",
            "White"});
            this.multiplier.Location = new System.Drawing.Point(536, 276);
            this.multiplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(149, 24);
            this.multiplier.TabIndex = 2;
            this.multiplier.SelectedIndexChanged += new System.EventHandler(this.multiplier_changed);
            // 
            // tolerance
            // 
            this.tolerance.FormattingEnabled = true;
            this.tolerance.Items.AddRange(new object[] {
            "Gold",
            "Silver"});
            this.tolerance.Location = new System.Drawing.Point(695, 276);
            this.tolerance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(160, 24);
            this.tolerance.TabIndex = 3;
            this.tolerance.SelectedIndexChanged += new System.EventHandler(this.tolerance_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Band 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Band 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Multiplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tolerance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 352);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resistance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Brown",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(69, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Resistor Color";
            // 
            // ResistorColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tolerance);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.value0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResistorColor";
            this.Text = "ResistorColor";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.ComboBox value0;
        private System.Windows.Forms.ComboBox value1;
        private System.Windows.Forms.ComboBox multiplier;
        private System.Windows.Forms.ComboBox tolerance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
<<<<<<< Updated upstream
        private System.Windows.Forms.Label label6;
	}
=======
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
>>>>>>> Stashed changes
}