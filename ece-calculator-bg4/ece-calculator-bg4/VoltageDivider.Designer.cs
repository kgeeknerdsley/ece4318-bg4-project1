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
            this.groupBox_outputs = new System.Windows.Forms.GroupBox();
            this.richTextBox_pwr = new System.Windows.Forms.RichTextBox();
            this.label_pwr = new System.Windows.Forms.Label();
            this.textBox_vout = new System.Windows.Forms.RichTextBox();
            this.label_vout = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_calcVout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_rload = new System.Windows.Forms.TextBox();
            this.label_rload = new System.Windows.Forms.Label();
            this.checkBox_load = new System.Windows.Forms.CheckBox();
            this.textbox_vin = new System.Windows.Forms.TextBox();
            this.label_inputVolt = new System.Windows.Forms.Label();
            this.R1_textbox = new System.Windows.Forms.TextBox();
            this.R1_label = new System.Windows.Forms.Label();
            this.R2_textbox = new System.Windows.Forms.TextBox();
            this.R2_label = new System.Windows.Forms.Label();
            this.voltD_page2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValOut3 = new System.Windows.Forms.TextBox();
            this.ValOut2 = new System.Windows.Forms.TextBox();
            this.ValOut1 = new System.Windows.Forms.TextBox();
            this.GenerateRval = new System.Windows.Forms.Button();
            this.Vin = new System.Windows.Forms.TextBox();
            this.Temp2 = new System.Windows.Forms.Label();
            this.Vout = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_voutWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).BeginInit();
            this.voltDivider_menu.SuspendLayout();
            this.voltD_page1.SuspendLayout();
            this.groupBox_outputs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.voltD_page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltDivider_picBox
            // 
            this.voltDivider_picBox.Image = global::ece_calculator_bg4.Properties.Resources.volt_divider_photo_tr;
            this.voltDivider_picBox.Location = new System.Drawing.Point(27, 24);
            this.voltDivider_picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltDivider_picBox.Name = "voltDivider_picBox";
            this.voltDivider_picBox.Size = new System.Drawing.Size(752, 1154);
            this.voltDivider_picBox.TabIndex = 0;
            this.voltDivider_picBox.TabStop = false;
            this.voltDivider_picBox.Click += new System.EventHandler(this.voltDivider_picBox_Click);
            // 
            // voltDivider_menu
            // 
            this.voltDivider_menu.Controls.Add(this.voltD_page1);
            this.voltDivider_menu.Controls.Add(this.voltD_page2);
            this.voltDivider_menu.Location = new System.Drawing.Point(909, 33);
            this.voltDivider_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltDivider_menu.Name = "voltDivider_menu";
            this.voltDivider_menu.SelectedIndex = 0;
            this.voltDivider_menu.Size = new System.Drawing.Size(1160, 868);
            this.voltDivider_menu.TabIndex = 10;
            // 
            // voltD_page1
            // 
            this.voltD_page1.Controls.Add(this.label_voutWarning);
            this.voltD_page1.Controls.Add(this.groupBox_outputs);
            this.voltD_page1.Controls.Add(this.button_clear);
            this.voltD_page1.Controls.Add(this.button_calcVout);
            this.voltD_page1.Controls.Add(this.groupBox1);
            this.voltD_page1.Location = new System.Drawing.Point(10, 48);
            this.voltD_page1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltD_page1.Name = "voltD_page1";
            this.voltD_page1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltD_page1.Size = new System.Drawing.Size(1140, 810);
            this.voltD_page1.TabIndex = 0;
            this.voltD_page1.Text = "Generate Vout";
            this.voltD_page1.UseVisualStyleBackColor = true;
            // 
            // groupBox_outputs
            // 
            this.groupBox_outputs.Controls.Add(this.richTextBox_pwr);
            this.groupBox_outputs.Controls.Add(this.label_pwr);
            this.groupBox_outputs.Controls.Add(this.textBox_vout);
            this.groupBox_outputs.Controls.Add(this.label_vout);
            this.groupBox_outputs.Location = new System.Drawing.Point(618, 104);
            this.groupBox_outputs.Name = "groupBox_outputs";
            this.groupBox_outputs.Size = new System.Drawing.Size(446, 282);
            this.groupBox_outputs.TabIndex = 38;
            this.groupBox_outputs.TabStop = false;
            this.groupBox_outputs.Text = "Outputs";
            // 
            // richTextBox_pwr
            // 
            this.richTextBox_pwr.Location = new System.Drawing.Point(29, 211);
            this.richTextBox_pwr.Name = "richTextBox_pwr";
            this.richTextBox_pwr.Size = new System.Drawing.Size(384, 38);
            this.richTextBox_pwr.TabIndex = 29;
            this.richTextBox_pwr.Text = "";
            // 
            // label_pwr
            // 
            this.label_pwr.AutoSize = true;
            this.label_pwr.Location = new System.Drawing.Point(23, 164);
            this.label_pwr.Name = "label_pwr";
            this.label_pwr.Size = new System.Drawing.Size(325, 32);
            this.label_pwr.TabIndex = 30;
            this.label_pwr.Text = "Power Dissipation (mW):";
            // 
            // textBox_vout
            // 
            this.textBox_vout.Location = new System.Drawing.Point(29, 107);
            this.textBox_vout.Name = "textBox_vout";
            this.textBox_vout.Size = new System.Drawing.Size(384, 38);
            this.textBox_vout.TabIndex = 27;
            this.textBox_vout.Text = "";
            // 
            // label_vout
            // 
            this.label_vout.AutoSize = true;
            this.label_vout.Location = new System.Drawing.Point(23, 60);
            this.label_vout.Name = "label_vout";
            this.label_vout.Size = new System.Drawing.Size(171, 32);
            this.label_vout.TabIndex = 28;
            this.label_vout.Text = "Vout (Volts):";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(309, 579);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(210, 110);
            this.button_clear.TabIndex = 37;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_calcVout
            // 
            this.button_calcVout.Location = new System.Drawing.Point(73, 579);
            this.button_calcVout.Name = "button_calcVout";
            this.button_calcVout.Size = new System.Drawing.Size(230, 110);
            this.button_calcVout.TabIndex = 36;
            this.button_calcVout.Text = "Calculate";
            this.button_calcVout.UseVisualStyleBackColor = true;
            this.button_calcVout.Click += new System.EventHandler(this.button_calcVout_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_rload);
            this.groupBox1.Controls.Add(this.label_rload);
            this.groupBox1.Controls.Add(this.checkBox_load);
            this.groupBox1.Controls.Add(this.textbox_vin);
            this.groupBox1.Controls.Add(this.label_inputVolt);
            this.groupBox1.Controls.Add(this.R1_textbox);
            this.groupBox1.Controls.Add(this.R1_label);
            this.groupBox1.Controls.Add(this.R2_textbox);
            this.groupBox1.Controls.Add(this.R2_label);
            this.groupBox1.Location = new System.Drawing.Point(73, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 402);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // textBox_rload
            // 
            this.textBox_rload.Location = new System.Drawing.Point(150, 315);
            this.textBox_rload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_rload.Name = "textBox_rload";
            this.textBox_rload.Size = new System.Drawing.Size(161, 38);
            this.textBox_rload.TabIndex = 38;
            // 
            // label_rload
            // 
            this.label_rload.AutoSize = true;
            this.label_rload.Location = new System.Drawing.Point(44, 318);
            this.label_rload.Name = "label_rload";
            this.label_rload.Size = new System.Drawing.Size(98, 32);
            this.label_rload.TabIndex = 39;
            this.label_rload.Text = "Rload:";
            // 
            // checkBox_load
            // 
            this.checkBox_load.AutoSize = true;
            this.checkBox_load.Location = new System.Drawing.Point(85, 259);
            this.checkBox_load.Name = "checkBox_load";
            this.checkBox_load.Size = new System.Drawing.Size(283, 36);
            this.checkBox_load.TabIndex = 37;
            this.checkBox_load.Text = "Account for Load?";
            this.checkBox_load.UseVisualStyleBackColor = true;
            this.checkBox_load.CheckedChanged += new System.EventHandler(this.checkBox_load_CheckedChanged);
            // 
            // textbox_vin
            // 
            this.textbox_vin.Location = new System.Drawing.Point(150, 75);
            this.textbox_vin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_vin.Name = "textbox_vin";
            this.textbox_vin.Size = new System.Drawing.Size(161, 38);
            this.textbox_vin.TabIndex = 34;
            this.textbox_vin.TextChanged += new System.EventHandler(this.textbox_vin_TextChanged);
            // 
            // label_inputVolt
            // 
            this.label_inputVolt.AutoSize = true;
            this.label_inputVolt.Location = new System.Drawing.Point(79, 75);
            this.label_inputVolt.Name = "label_inputVolt";
            this.label_inputVolt.Size = new System.Drawing.Size(65, 32);
            this.label_inputVolt.TabIndex = 35;
            this.label_inputVolt.Text = "Vin:";
            // 
            // R1_textbox
            // 
            this.R1_textbox.Location = new System.Drawing.Point(150, 131);
            this.R1_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R1_textbox.Name = "R1_textbox";
            this.R1_textbox.Size = new System.Drawing.Size(161, 38);
            this.R1_textbox.TabIndex = 30;
            this.R1_textbox.TextChanged += new System.EventHandler(this.R1_textbox_TextChanged);
            // 
            // R1_label
            // 
            this.R1_label.AutoSize = true;
            this.R1_label.Location = new System.Drawing.Point(83, 131);
            this.R1_label.Name = "R1_label";
            this.R1_label.Size = new System.Drawing.Size(59, 32);
            this.R1_label.TabIndex = 31;
            this.R1_label.Text = "R1:";
            // 
            // R2_textbox
            // 
            this.R2_textbox.Location = new System.Drawing.Point(150, 190);
            this.R2_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R2_textbox.Name = "R2_textbox";
            this.R2_textbox.Size = new System.Drawing.Size(161, 38);
            this.R2_textbox.TabIndex = 32;
            this.R2_textbox.TextChanged += new System.EventHandler(this.R2_textbox_TextChanged);
            // 
            // R2_label
            // 
            this.R2_label.AutoSize = true;
            this.R2_label.Location = new System.Drawing.Point(83, 190);
            this.R2_label.Name = "R2_label";
            this.R2_label.Size = new System.Drawing.Size(59, 32);
            this.R2_label.TabIndex = 33;
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
            this.voltD_page2.Location = new System.Drawing.Point(10, 48);
            this.voltD_page2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltD_page2.Name = "voltD_page2";
            this.voltD_page2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltD_page2.Size = new System.Drawing.Size(1140, 810);
            this.voltD_page2.TabIndex = 1;
            this.voltD_page2.Text = "Generate R Values";
            this.voltD_page2.UseVisualStyleBackColor = true;
            this.voltD_page2.Click += new System.EventHandler(this.voltD_page2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 596);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "R2 > R1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 489);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "R1 > R2";
            // 
            // ValOut3
            // 
            this.ValOut3.Location = new System.Drawing.Point(56, 634);
            this.ValOut3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ValOut3.Multiline = true;
            this.ValOut3.Name = "ValOut3";
            this.ValOut3.Size = new System.Drawing.Size(1015, 47);
            this.ValOut3.TabIndex = 28;
            // 
            // ValOut2
            // 
            this.ValOut2.Location = new System.Drawing.Point(56, 527);
            this.ValOut2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ValOut2.Multiline = true;
            this.ValOut2.Name = "ValOut2";
            this.ValOut2.Size = new System.Drawing.Size(1015, 47);
            this.ValOut2.TabIndex = 27;
            // 
            // ValOut1
            // 
            this.ValOut1.Location = new System.Drawing.Point(56, 429);
            this.ValOut1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ValOut1.Multiline = true;
            this.ValOut1.Name = "ValOut1";
            this.ValOut1.Size = new System.Drawing.Size(1015, 47);
            this.ValOut1.TabIndex = 26;
            this.ValOut1.TextChanged += new System.EventHandler(this.ValOut_TextChanged);
            // 
            // GenerateRval
            // 
            this.GenerateRval.Location = new System.Drawing.Point(56, 153);
            this.GenerateRval.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GenerateRval.Name = "GenerateRval";
            this.GenerateRval.Size = new System.Drawing.Size(1021, 134);
            this.GenerateRval.TabIndex = 25;
            this.GenerateRval.Text = "BUNGUS";
            this.GenerateRval.UseVisualStyleBackColor = true;
            this.GenerateRval.Click += new System.EventHandler(this.GenerateRval_Click);
            // 
            // Vin
            // 
            this.Vin.Location = new System.Drawing.Point(120, 48);
            this.Vin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(161, 38);
            this.Vin.TabIndex = 21;
            this.Vin.TextChanged += new System.EventHandler(this.Vin_TextChanged);
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.Location = new System.Drawing.Point(48, 114);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(187, 32);
            this.Temp2.TabIndex = 24;
            this.Temp2.Text = "Vout Desired:";
            this.Temp2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Vout
            // 
            this.Vout.Location = new System.Drawing.Point(243, 98);
            this.Vout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vout.Name = "Vout";
            this.Vout.Size = new System.Drawing.Size(161, 38);
            this.Vout.TabIndex = 23;
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(48, 55);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(65, 32);
            this.Temp.TabIndex = 22;
            this.Temp.Text = "Vin:";
            this.Temp.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 128);
            this.label2.TabIndex = 30;
            this.label2.Text = "If you want both R1 and R2 to be the same. \r\nR1 and R2:\r\n\r\n\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label_voutWarning
            // 
            this.label_voutWarning.AutoSize = true;
            this.label_voutWarning.ForeColor = System.Drawing.Color.Red;
            this.label_voutWarning.Location = new System.Drawing.Point(552, 500);
            this.label_voutWarning.Name = "label_voutWarning";
            this.label_voutWarning.Size = new System.Drawing.Size(548, 64);
            this.label_voutWarning.TabIndex = 39;
            this.label_voutWarning.Text = "Vout skewed due to large load resistance. \r\nConsider increasing load resistance.";
            // 
            // VoltageDivider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2176, 1183);
            this.Controls.Add(this.voltDivider_menu);
            this.Controls.Add(this.voltDivider_picBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VoltageDivider";
            this.Text = "VoltageDivider";
            this.Load += new System.EventHandler(this.VoltageDivider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).EndInit();
            this.voltDivider_menu.ResumeLayout(false);
            this.voltD_page1.ResumeLayout(false);
            this.voltD_page1.PerformLayout();
            this.groupBox_outputs.ResumeLayout(false);
            this.groupBox_outputs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.voltD_page2.ResumeLayout(false);
            this.voltD_page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox voltDivider_picBox;
        private System.Windows.Forms.TabControl voltDivider_menu;
        private System.Windows.Forms.TabPage voltD_page1;
        private System.Windows.Forms.TabPage voltD_page2;
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
        private System.Windows.Forms.Label label_vout;
        private System.Windows.Forms.RichTextBox textBox_vout;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_calcVout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_vin;
        private System.Windows.Forms.Label label_inputVolt;
        private System.Windows.Forms.TextBox R1_textbox;
        private System.Windows.Forms.Label R1_label;
        private System.Windows.Forms.TextBox R2_textbox;
        private System.Windows.Forms.Label R2_label;
        private System.Windows.Forms.GroupBox groupBox_outputs;
        private System.Windows.Forms.RichTextBox richTextBox_pwr;
        private System.Windows.Forms.Label label_pwr;
        private System.Windows.Forms.CheckBox checkBox_load;
        private System.Windows.Forms.TextBox textBox_rload;
        private System.Windows.Forms.Label label_rload;
        private System.Windows.Forms.Label label_voutWarning;
    }
}