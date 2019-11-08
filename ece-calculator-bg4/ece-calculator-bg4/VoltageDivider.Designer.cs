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
            this.R1_textbox = new System.Windows.Forms.TextBox();
            this.R1_label = new System.Windows.Forms.Label();
            this.R2_textbox = new System.Windows.Forms.TextBox();
            this.R2_label = new System.Windows.Forms.Label();
            this.voltD_page2 = new System.Windows.Forms.TabPage();
            this.ValOut1 = new System.Windows.Forms.TextBox();
            this.GenerateRval = new System.Windows.Forms.Button();
            this.Vin = new System.Windows.Forms.TextBox();
            this.Temp2 = new System.Windows.Forms.Label();
            this.Vout = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.Label();
            this.ValOut2 = new System.Windows.Forms.TextBox();
            this.ValOut3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).BeginInit();
            this.voltDivider_menu.SuspendLayout();
            this.voltD_page1.SuspendLayout();
            this.voltD_page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltDivider_picBox
            // 
            this.voltDivider_picBox.Image = global::ece_calculator_bg4.Properties.Resources.volt_divider_photo_tr;
            this.voltDivider_picBox.Location = new System.Drawing.Point(10, 10);
            this.voltDivider_picBox.Margin = new System.Windows.Forms.Padding(1);
            this.voltDivider_picBox.Name = "voltDivider_picBox";
            this.voltDivider_picBox.Size = new System.Drawing.Size(282, 484);
            this.voltDivider_picBox.TabIndex = 0;
            this.voltDivider_picBox.TabStop = false;
            this.voltDivider_picBox.Click += new System.EventHandler(this.voltDivider_picBox_Click);
            // 
            // voltDivider_menu
            // 
            this.voltDivider_menu.Controls.Add(this.voltD_page1);
            this.voltDivider_menu.Controls.Add(this.voltD_page2);
            this.voltDivider_menu.Location = new System.Drawing.Point(341, 14);
            this.voltDivider_menu.Margin = new System.Windows.Forms.Padding(1);
            this.voltDivider_menu.Name = "voltDivider_menu";
            this.voltDivider_menu.SelectedIndex = 0;
            this.voltDivider_menu.Size = new System.Drawing.Size(435, 364);
            this.voltDivider_menu.TabIndex = 10;
            // 
            // voltD_page1
            // 
            this.voltD_page1.Controls.Add(this.R1_textbox);
            this.voltD_page1.Controls.Add(this.R1_label);
            this.voltD_page1.Controls.Add(this.R2_textbox);
            this.voltD_page1.Controls.Add(this.R2_label);
            this.voltD_page1.Location = new System.Drawing.Point(4, 22);
            this.voltD_page1.Margin = new System.Windows.Forms.Padding(1);
            this.voltD_page1.Name = "voltD_page1";
            this.voltD_page1.Padding = new System.Windows.Forms.Padding(1);
            this.voltD_page1.Size = new System.Drawing.Size(427, 338);
            this.voltD_page1.TabIndex = 0;
            this.voltD_page1.Text = "Generate Vout";
            this.voltD_page1.UseVisualStyleBackColor = true;
            // 
            // R1_textbox
            // 
            this.R1_textbox.Location = new System.Drawing.Point(196, 147);
            this.R1_textbox.Margin = new System.Windows.Forms.Padding(1);
            this.R1_textbox.Name = "R1_textbox";
            this.R1_textbox.Size = new System.Drawing.Size(63, 20);
            this.R1_textbox.TabIndex = 21;
            // 
            // R1_label
            // 
            this.R1_label.AutoSize = true;
            this.R1_label.Location = new System.Drawing.Point(171, 147);
            this.R1_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.R1_label.Name = "R1_label";
            this.R1_label.Size = new System.Drawing.Size(24, 13);
            this.R1_label.TabIndex = 22;
            this.R1_label.Text = "R1:";
            // 
            // R2_textbox
            // 
            this.R2_textbox.Location = new System.Drawing.Point(196, 172);
            this.R2_textbox.Margin = new System.Windows.Forms.Padding(1);
            this.R2_textbox.Name = "R2_textbox";
            this.R2_textbox.Size = new System.Drawing.Size(63, 20);
            this.R2_textbox.TabIndex = 23;
            // 
            // R2_label
            // 
            this.R2_label.AutoSize = true;
            this.R2_label.Location = new System.Drawing.Point(171, 172);
            this.R2_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.R2_label.Name = "R2_label";
            this.R2_label.Size = new System.Drawing.Size(24, 13);
            this.R2_label.TabIndex = 24;
            this.R2_label.Text = "R2:";
            // 
            // voltD_page2
            // 
            this.voltD_page2.Controls.Add(this.label4);
            this.voltD_page2.Controls.Add(this.label3);
            this.voltD_page2.Controls.Add(this.ValOut3);
            this.voltD_page2.Controls.Add(this.ValOut2);
            this.voltD_page2.Controls.Add(this.ValOut1);
            this.voltD_page2.Controls.Add(this.GenerateRval);
            this.voltD_page2.Controls.Add(this.Vin);
            this.voltD_page2.Controls.Add(this.Temp2);
            this.voltD_page2.Controls.Add(this.Vout);
            this.voltD_page2.Controls.Add(this.Temp);
            this.voltD_page2.Controls.Add(this.label2);
            this.voltD_page2.Location = new System.Drawing.Point(4, 22);
            this.voltD_page2.Margin = new System.Windows.Forms.Padding(1);
            this.voltD_page2.Name = "voltD_page2";
            this.voltD_page2.Padding = new System.Windows.Forms.Padding(1);
            this.voltD_page2.Size = new System.Drawing.Size(427, 338);
            this.voltD_page2.TabIndex = 1;
            this.voltD_page2.Text = "Generate R Values";
            this.voltD_page2.UseVisualStyleBackColor = true;
            this.voltD_page2.Click += new System.EventHandler(this.voltD_page2_Click);
            // 
            // ValOut1
            // 
            this.ValOut1.Location = new System.Drawing.Point(21, 180);
            this.ValOut1.Multiline = true;
            this.ValOut1.Name = "ValOut1";
            this.ValOut1.Size = new System.Drawing.Size(383, 22);
            this.ValOut1.TabIndex = 26;
            this.ValOut1.TextChanged += new System.EventHandler(this.ValOut_TextChanged);
            // 
            // GenerateRval
            // 
            this.GenerateRval.Location = new System.Drawing.Point(21, 64);
            this.GenerateRval.Name = "GenerateRval";
            this.GenerateRval.Size = new System.Drawing.Size(383, 56);
            this.GenerateRval.TabIndex = 25;
            this.GenerateRval.Text = "BUNGUS";
            this.GenerateRval.UseVisualStyleBackColor = true;
            this.GenerateRval.Click += new System.EventHandler(this.GenerateRval_Click);
            // 
            // Vin
            // 
            this.Vin.Location = new System.Drawing.Point(45, 20);
            this.Vin.Margin = new System.Windows.Forms.Padding(1);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(63, 20);
            this.Vin.TabIndex = 21;
            this.Vin.TextChanged += new System.EventHandler(this.Vin_TextChanged);
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(18, 48);
            this.Temp2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(71, 13);
            this.Temp2.TabIndex = 24;
            this.Temp2.Text = "Vout Desired:";
            this.Temp2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Vout
            // 
            this.Vout.Location = new System.Drawing.Point(91, 41);
            this.Vout.Margin = new System.Windows.Forms.Padding(1);
            this.Vout.Name = "Vout";
            this.Vout.Size = new System.Drawing.Size(63, 20);
            this.Vout.TabIndex = 23;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(18, 23);
            this.Temp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(25, 13);
            this.Temp.TabIndex = 22;
            this.Temp.Text = "Vin:";
            this.Temp.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ValOut2
            // 
            this.ValOut2.Location = new System.Drawing.Point(21, 221);
            this.ValOut2.Multiline = true;
            this.ValOut2.Name = "ValOut2";
            this.ValOut2.Size = new System.Drawing.Size(383, 22);
            this.ValOut2.TabIndex = 27;
            // 
            // ValOut3
            // 
            this.ValOut3.Location = new System.Drawing.Point(21, 266);
            this.ValOut3.Multiline = true;
            this.ValOut3.Name = "ValOut3";
            this.ValOut3.Size = new System.Drawing.Size(383, 22);
            this.ValOut3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 52);
            this.label2.TabIndex = 30;
            this.label2.Text = "If you want both R1 and R2 to be the same. \r\nR1 and R2:\r\n\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "R1 > R2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "R2 > R1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VoltageDivider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 496);
            this.Controls.Add(this.voltDivider_menu);
            this.Controls.Add(this.voltDivider_picBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "VoltageDivider";
            this.Text = "VoltageDivider";
            this.Load += new System.EventHandler(this.VoltageDivider_Load);
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
        private System.Windows.Forms.TextBox Vin;
        private System.Windows.Forms.Label Temp2;
        private System.Windows.Forms.TextBox Vout;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.TextBox ValOut1;
        private System.Windows.Forms.Button GenerateRval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValOut3;
        private System.Windows.Forms.TextBox ValOut2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}