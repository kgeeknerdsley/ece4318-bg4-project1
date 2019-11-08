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
			this.SuspendLayout();
			// 
			// filterCalcStart
			// 
			this.filterCalcStart.Location = new System.Drawing.Point(22, 28);
			this.filterCalcStart.Name = "filterCalcStart";
			this.filterCalcStart.Size = new System.Drawing.Size(82, 61);
			this.filterCalcStart.TabIndex = 0;
			this.filterCalcStart.Text = "Filter Calculator";
			this.filterCalcStart.UseVisualStyleBackColor = true;
			this.filterCalcStart.Click += new System.EventHandler(this.filterCalcStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 450);
			this.Controls.Add(this.filterCalcStart);
			this.Name = "Form1";
			this.Text = "CPP ECE Calculator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button filterCalcStart;
	}
}

