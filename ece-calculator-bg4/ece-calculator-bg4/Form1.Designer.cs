namespace ece_calculator_bg4
{
	partial class Form1
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
			this.filterCalcStart = new System.Windows.Forms.Button();
			this.resistorCalcStart = new System.Windows.Forms.Button();
			this.commonChipStart = new System.Windows.Forms.Button();
			this.voltageDivStart = new System.Windows.Forms.Button();
			this.truthTableStart = new System.Windows.Forms.Button();
			this.refLabel = new System.Windows.Forms.Label();
			this.calcLabel = new System.Windows.Forms.Label();
			this.underline = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// filterCalcStart
			// 
			this.filterCalcStart.Location = new System.Drawing.Point(12, 45);
			this.filterCalcStart.Name = "filterCalcStart";
			this.filterCalcStart.Size = new System.Drawing.Size(82, 61);
			this.filterCalcStart.TabIndex = 0;
			this.filterCalcStart.Text = "Filter Calculator";
			this.filterCalcStart.UseVisualStyleBackColor = true;
			this.filterCalcStart.Click += new System.EventHandler(this.filterCalcStart_Click);
			// 
			// resistorCalcStart
			// 
			this.resistorCalcStart.Location = new System.Drawing.Point(129, 83);
			this.resistorCalcStart.Name = "resistorCalcStart";
			this.resistorCalcStart.Size = new System.Drawing.Size(82, 61);
			this.resistorCalcStart.TabIndex = 1;
			this.resistorCalcStart.Text = "Resistor Color Code Calculator";
			this.resistorCalcStart.UseVisualStyleBackColor = true;
			this.resistorCalcStart.Click += new System.EventHandler(this.resistorCalcStart_Click);
			// 
			// commonChipStart
			// 
			this.commonChipStart.Location = new System.Drawing.Point(12, 300);
			this.commonChipStart.Name = "commonChipStart";
			this.commonChipStart.Size = new System.Drawing.Size(82, 61);
			this.commonChipStart.TabIndex = 2;
			this.commonChipStart.Text = "Common Chip Pinouts";
			this.commonChipStart.UseVisualStyleBackColor = true;
			this.commonChipStart.Click += new System.EventHandler(this.commonChipStart_Click);
			// 
			// voltageDivStart
			// 
			this.voltageDivStart.Location = new System.Drawing.Point(12, 133);
			this.voltageDivStart.Name = "voltageDivStart";
			this.voltageDivStart.Size = new System.Drawing.Size(82, 61);
			this.voltageDivStart.TabIndex = 3;
			this.voltageDivStart.Text = "Voltage Divider Calculator";
			this.voltageDivStart.UseVisualStyleBackColor = true;
			this.voltageDivStart.Click += new System.EventHandler(this.voltageDivStart_Click);
			// 
			// truthTableStart
			// 
			this.truthTableStart.Location = new System.Drawing.Point(129, 300);
			this.truthTableStart.Name = "truthTableStart";
			this.truthTableStart.Size = new System.Drawing.Size(82, 61);
			this.truthTableStart.TabIndex = 4;
			this.truthTableStart.Text = "Truth Table Charts";
			this.truthTableStart.UseVisualStyleBackColor = true;
			this.truthTableStart.Click += new System.EventHandler(this.truthTableStart_Click);
			// 
			// refLabel
			// 
			this.refLabel.AutoSize = true;
			this.refLabel.Location = new System.Drawing.Point(2, 252);
			this.refLabel.Name = "refLabel";
			this.refLabel.Size = new System.Drawing.Size(85, 13);
			this.refLabel.TabIndex = 5;
			this.refLabel.Text = "Reference Items";
			// 
			// calcLabel
			// 
			this.calcLabel.AutoSize = true;
			this.calcLabel.Location = new System.Drawing.Point(12, 9);
			this.calcLabel.Name = "calcLabel";
			this.calcLabel.Size = new System.Drawing.Size(59, 13);
			this.calcLabel.TabIndex = 6;
			this.calcLabel.Text = "Calculators";
			// 
			// underline
			// 
			this.underline.AutoSize = true;
			this.underline.Location = new System.Drawing.Point(36, 22);
			this.underline.Name = "underline";
			this.underline.Size = new System.Drawing.Size(175, 13);
			this.underline.TabIndex = 7;
			this.underline.Text = "____________________________";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "____________________________";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 381);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(228, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 405);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.underline);
			this.Controls.Add(this.calcLabel);
			this.Controls.Add(this.refLabel);
			this.Controls.Add(this.truthTableStart);
			this.Controls.Add(this.voltageDivStart);
			this.Controls.Add(this.commonChipStart);
			this.Controls.Add(this.resistorCalcStart);
			this.Controls.Add(this.filterCalcStart);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "CPP ECE Calculator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button filterCalcStart;
		private System.Windows.Forms.Button resistorCalcStart;
		private System.Windows.Forms.Button commonChipStart;
		private System.Windows.Forms.Button voltageDivStart;
		private System.Windows.Forms.Button truthTableStart;
		private System.Windows.Forms.Label refLabel;
		private System.Windows.Forms.Label calcLabel;
		private System.Windows.Forms.Label underline;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
	}
}

