namespace ece_calculator_bg4
{
	partial class VoltageDivider
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
            this.voltDivider_picBox = new System.Windows.Forms.PictureBox();
            this.voltDivider_menu = new System.Windows.Forms.TabControl();
            this.voltD_page1 = new System.Windows.Forms.TabPage();
            this.voltD_page2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.R1_textbox = new System.Windows.Forms.TextBox();
            this.R1_label = new System.Windows.Forms.Label();
            this.R2_textbox = new System.Windows.Forms.TextBox();
            this.R2_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).BeginInit();
            this.voltDivider_menu.SuspendLayout();
            this.voltD_page1.SuspendLayout();
            this.voltD_page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltDivider_picBox
            // 
            this.voltDivider_picBox.Image = global::ece_calculator_bg4.Properties.Resources.volt_divider_photo_tr;
            this.voltDivider_picBox.Location = new System.Drawing.Point(35, 33);
            this.voltDivider_picBox.Name = "voltDivider_picBox";
            this.voltDivider_picBox.Size = new System.Drawing.Size(270, 533);
            this.voltDivider_picBox.TabIndex = 0;
            this.voltDivider_picBox.TabStop = false;
            this.voltDivider_picBox.Click += new System.EventHandler(this.voltDivider_picBox_Click);
            // 
            // voltDivider_menu
            // 
            this.voltDivider_menu.Controls.Add(this.voltD_page1);
            this.voltDivider_menu.Controls.Add(this.voltD_page2);
            this.voltDivider_menu.Location = new System.Drawing.Point(322, 33);
            this.voltDivider_menu.Name = "voltDivider_menu";
            this.voltDivider_menu.SelectedIndex = 0;
            this.voltDivider_menu.Size = new System.Drawing.Size(1161, 858);
            this.voltDivider_menu.TabIndex = 10;
            // 
            // voltD_page1
            // 
            this.voltD_page1.Controls.Add(this.R1_textbox);
            this.voltD_page1.Controls.Add(this.R1_label);
            this.voltD_page1.Controls.Add(this.R2_textbox);
            this.voltD_page1.Controls.Add(this.R2_label);
            this.voltD_page1.Location = new System.Drawing.Point(10, 48);
            this.voltD_page1.Name = "voltD_page1";
            this.voltD_page1.Padding = new System.Windows.Forms.Padding(3);
            this.voltD_page1.Size = new System.Drawing.Size(1141, 800);
            this.voltD_page1.TabIndex = 0;
            this.voltD_page1.Text = "Generate Vout";
            this.voltD_page1.UseVisualStyleBackColor = true;
            // 
            // voltD_page2
            // 
            this.voltD_page2.Controls.Add(this.textBox2);
            this.voltD_page2.Controls.Add(this.label1);
            this.voltD_page2.Controls.Add(this.textBox1);
            this.voltD_page2.Controls.Add(this.label2);
            this.voltD_page2.Location = new System.Drawing.Point(10, 48);
            this.voltD_page2.Name = "voltD_page2";
            this.voltD_page2.Padding = new System.Windows.Forms.Padding(3);
            this.voltD_page2.Size = new System.Drawing.Size(1141, 800);
            this.voltD_page2.TabIndex = 1;
            this.voltD_page2.Text = "Generate R Values";
            this.voltD_page2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 38);
            this.textBox2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Vout Desired:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 38);
            this.textBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vin:";
            // 
            // R1_textbox
            // 
            this.R1_textbox.Location = new System.Drawing.Point(522, 351);
            this.R1_textbox.Name = "R1_textbox";
            this.R1_textbox.Size = new System.Drawing.Size(161, 38);
            this.R1_textbox.TabIndex = 21;
            // 
            // R1_label
            // 
            this.R1_label.AutoSize = true;
            this.R1_label.Location = new System.Drawing.Point(457, 351);
            this.R1_label.Name = "R1_label";
            this.R1_label.Size = new System.Drawing.Size(59, 32);
            this.R1_label.TabIndex = 22;
            this.R1_label.Text = "R1:";
            // 
            // R2_textbox
            // 
            this.R2_textbox.Location = new System.Drawing.Point(522, 411);
            this.R2_textbox.Name = "R2_textbox";
            this.R2_textbox.Size = new System.Drawing.Size(161, 38);
            this.R2_textbox.TabIndex = 23;
            // 
            // R2_label
            // 
            this.R2_label.AutoSize = true;
            this.R2_label.Location = new System.Drawing.Point(457, 411);
            this.R2_label.Name = "R2_label";
            this.R2_label.Size = new System.Drawing.Size(59, 32);
            this.R2_label.TabIndex = 24;
            this.R2_label.Text = "R2:";
            // 
            // VoltageDivider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 919);
            this.Controls.Add(this.voltDivider_menu);
            this.Controls.Add(this.voltDivider_picBox);
            this.Name = "VoltageDivider";
            this.Text = "VoltageDivider";
            ((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).EndInit();
            this.voltDivider_menu.ResumeLayout(false);
            this.voltD_page1.ResumeLayout(false);
            this.voltD_page1.PerformLayout();
            this.voltD_page2.ResumeLayout(false);
            this.voltD_page2.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.PictureBox voltDivider_picBox;
        private System.Windows.Forms.TabControl voltDivider_menu;
        private System.Windows.Forms.TabPage voltD_page1;
        private System.Windows.Forms.TabPage voltD_page2;
        private System.Windows.Forms.TextBox R1_textbox;
        private System.Windows.Forms.Label R1_label;
        private System.Windows.Forms.TextBox R2_textbox;
        private System.Windows.Forms.Label R2_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}