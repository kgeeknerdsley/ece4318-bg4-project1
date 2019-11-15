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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.filterCalcStart = new System.Windows.Forms.Button();
			this.resistorCalcStart = new System.Windows.Forms.Button();
			this.commonChipStart = new System.Windows.Forms.Button();
			this.voltageDivStart = new System.Windows.Forms.Button();
			this.truthTableStart = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// filterCalcStart
			// 
			this.filterCalcStart.Location = new System.Drawing.Point(6, 28);
			this.filterCalcStart.Name = "filterCalcStart";
			this.filterCalcStart.Size = new System.Drawing.Size(70, 52);
			this.filterCalcStart.TabIndex = 0;
			this.filterCalcStart.Text = "Filter Calculator";
			this.filterCalcStart.UseVisualStyleBackColor = true;
			this.filterCalcStart.Click += new System.EventHandler(this.filterCalcStart_Click);
			// 
			// resistorCalcStart
			// 
			this.resistorCalcStart.Location = new System.Drawing.Point(182, 28);
			this.resistorCalcStart.Name = "resistorCalcStart";
			this.resistorCalcStart.Size = new System.Drawing.Size(70, 52);
			this.resistorCalcStart.TabIndex = 1;
			this.resistorCalcStart.Text = "Resistor Color Code Calculator";
			this.resistorCalcStart.UseVisualStyleBackColor = true;
			this.resistorCalcStart.Click += new System.EventHandler(this.resistorCalcStart_Click);
			// 
			// commonChipStart
			// 
			this.commonChipStart.Location = new System.Drawing.Point(47, 19);
			this.commonChipStart.Name = "commonChipStart";
			this.commonChipStart.Size = new System.Drawing.Size(70, 52);
			this.commonChipStart.TabIndex = 2;
			this.commonChipStart.Text = "Common Chip Pinouts";
			this.commonChipStart.UseVisualStyleBackColor = true;
			this.commonChipStart.Click += new System.EventHandler(this.commonChipStart_Click);
			// 
			// voltageDivStart
			// 
			this.voltageDivStart.Location = new System.Drawing.Point(92, 28);
			this.voltageDivStart.Name = "voltageDivStart";
			this.voltageDivStart.Size = new System.Drawing.Size(70, 52);
			this.voltageDivStart.TabIndex = 3;
			this.voltageDivStart.Text = "Voltage Divider Calculator";
			this.voltageDivStart.UseVisualStyleBackColor = true;
			this.voltageDivStart.Click += new System.EventHandler(this.voltageDivStart_Click);
			// 
			// truthTableStart
			// 
			this.truthTableStart.Location = new System.Drawing.Point(138, 19);
			this.truthTableStart.Name = "truthTableStart";
			this.truthTableStart.Size = new System.Drawing.Size(70, 52);
			this.truthTableStart.TabIndex = 4;
			this.truthTableStart.Text = "Truth Table Charts";
			this.truthTableStart.UseVisualStyleBackColor = true;
			this.truthTableStart.Click += new System.EventHandler(this.truthTableStart_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 203);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(282, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Info";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.filterCalcStart);
			this.groupBox1.Controls.Add(this.resistorCalcStart);
			this.groupBox1.Controls.Add(this.voltageDivStart);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(258, 97);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Calculators";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.commonChipStart);
			this.groupBox2.Controls.Add(this.truthTableStart);
			this.groupBox2.Location = new System.Drawing.Point(12, 115);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(258, 85);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Reference Tools";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 227);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "CPP ECE Calculator";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button filterCalcStart;

		private System.Windows.Forms.Button resistorCalcStart;
		private System.Windows.Forms.Button commonChipStart;
		private System.Windows.Forms.Button voltageDivStart;
		private System.Windows.Forms.Button truthTableStart;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
	}

}

