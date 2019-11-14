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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterCalcStart
            // 
            this.filterCalcStart.Location = new System.Drawing.Point(59, 67);
            this.filterCalcStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.filterCalcStart.Name = "filterCalcStart";
            this.filterCalcStart.Size = new System.Drawing.Size(219, 145);
            this.filterCalcStart.TabIndex = 0;
            this.filterCalcStart.Text = "Filter Calculator";
            this.filterCalcStart.UseVisualStyleBackColor = true;
            this.filterCalcStart.Click += new System.EventHandler(this.filterCalcStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 145);
            this.button1.TabIndex = 1;
            this.button1.Text = "Common Pin Layouts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.commonChipStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 1073);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterCalcStart);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "CPP ECE Calculator";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button filterCalcStart;
        private System.Windows.Forms.Button button1;
    }
}

