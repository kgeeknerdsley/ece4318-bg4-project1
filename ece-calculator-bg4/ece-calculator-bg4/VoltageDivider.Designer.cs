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
			this.voltDivider_menu = new System.Windows.Forms.TabControl();
			this.voltD_page1 = new System.Windows.Forms.TabPage();
			this.label_voutWarning = new System.Windows.Forms.Label();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.R2Val = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.R1Val = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.clear_butt = new System.Windows.Forms.Button();
			this.Generate = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Rcheck = new System.Windows.Forms.CheckBox();
			this.MaxPower = new System.Windows.Forms.TextBox();
			this.labe12 = new System.Windows.Forms.Label();
			this.Vin = new System.Windows.Forms.TextBox();
			this.labelq = new System.Windows.Forms.Label();
			this.Vout = new System.Windows.Forms.TextBox();
			this.labelb = new System.Windows.Forms.Label();
			this.R1 = new System.Windows.Forms.TextBox();
			this.label_r1manualEntry = new System.Windows.Forms.Label();
			this.voltDivider_picBox = new System.Windows.Forms.PictureBox();
			this.voltDivider_menu.SuspendLayout();
			this.voltD_page1.SuspendLayout();
			this.groupBox_outputs.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.voltD_page2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// voltDivider_menu
			// 
			this.voltDivider_menu.Controls.Add(this.voltD_page1);
			this.voltDivider_menu.Controls.Add(this.voltD_page2);
			this.voltDivider_menu.Location = new System.Drawing.Point(341, 14);
			this.voltDivider_menu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.voltDivider_menu.Name = "voltDivider_menu";
			this.voltDivider_menu.SelectedIndex = 0;
			this.voltDivider_menu.Size = new System.Drawing.Size(435, 364);
			this.voltDivider_menu.TabIndex = 10;
			// 
			// voltD_page1
			// 
			this.voltD_page1.Controls.Add(this.label_voutWarning);
			this.voltD_page1.Controls.Add(this.groupBox_outputs);
			this.voltD_page1.Controls.Add(this.button_clear);
			this.voltD_page1.Controls.Add(this.button_calcVout);
			this.voltD_page1.Controls.Add(this.groupBox1);
			this.voltD_page1.Location = new System.Drawing.Point(4, 22);
			this.voltD_page1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.voltD_page1.Name = "voltD_page1";
			this.voltD_page1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.voltD_page1.Size = new System.Drawing.Size(427, 338);
			this.voltD_page1.TabIndex = 0;
			this.voltD_page1.Text = "Generate Vout";
			this.voltD_page1.UseVisualStyleBackColor = true;
			// 
			// label_voutWarning
			// 
			this.label_voutWarning.AutoSize = true;
			this.label_voutWarning.ForeColor = System.Drawing.Color.Red;
			this.label_voutWarning.Location = new System.Drawing.Point(207, 210);
			this.label_voutWarning.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_voutWarning.Name = "label_voutWarning";
			this.label_voutWarning.Size = new System.Drawing.Size(208, 26);
			this.label_voutWarning.TabIndex = 39;
			this.label_voutWarning.Text = "Vout skewed due to small load resistance. \r\nConsider increasing load resistance.";
			// 
			// groupBox_outputs
			// 
			this.groupBox_outputs.Controls.Add(this.richTextBox_pwr);
			this.groupBox_outputs.Controls.Add(this.label_pwr);
			this.groupBox_outputs.Controls.Add(this.textBox_vout);
			this.groupBox_outputs.Controls.Add(this.label_vout);
			this.groupBox_outputs.Location = new System.Drawing.Point(232, 44);
			this.groupBox_outputs.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox_outputs.Name = "groupBox_outputs";
			this.groupBox_outputs.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox_outputs.Size = new System.Drawing.Size(167, 118);
			this.groupBox_outputs.TabIndex = 38;
			this.groupBox_outputs.TabStop = false;
			this.groupBox_outputs.Text = "Outputs";
			// 
			// richTextBox_pwr
			// 
			this.richTextBox_pwr.Location = new System.Drawing.Point(11, 88);
			this.richTextBox_pwr.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.richTextBox_pwr.Name = "richTextBox_pwr";
			this.richTextBox_pwr.Size = new System.Drawing.Size(146, 18);
			this.richTextBox_pwr.TabIndex = 29;
			this.richTextBox_pwr.Text = "";
			// 
			// label_pwr
			// 
			this.label_pwr.AutoSize = true;
			this.label_pwr.Location = new System.Drawing.Point(9, 69);
			this.label_pwr.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_pwr.Name = "label_pwr";
			this.label_pwr.Size = new System.Drawing.Size(122, 13);
			this.label_pwr.TabIndex = 30;
			this.label_pwr.Text = "Power Dissipation (mW):";
			// 
			// textBox_vout
			// 
			this.textBox_vout.Location = new System.Drawing.Point(11, 45);
			this.textBox_vout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textBox_vout.Name = "textBox_vout";
			this.textBox_vout.Size = new System.Drawing.Size(146, 18);
			this.textBox_vout.TabIndex = 27;
			this.textBox_vout.Text = "";
			this.textBox_vout.TextChanged += new System.EventHandler(this.textBox_vout_TextChanged);
			// 
			// label_vout
			// 
			this.label_vout.AutoSize = true;
			this.label_vout.Location = new System.Drawing.Point(9, 25);
			this.label_vout.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_vout.Name = "label_vout";
			this.label_vout.Size = new System.Drawing.Size(64, 13);
			this.label_vout.TabIndex = 28;
			this.label_vout.Text = "Vout (Volts):";
			// 
			// button_clear
			// 
			this.button_clear.Location = new System.Drawing.Point(116, 243);
			this.button_clear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(79, 46);
			this.button_clear.TabIndex = 37;
			this.button_clear.Text = "Clear";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// button_calcVout
			// 
			this.button_calcVout.Location = new System.Drawing.Point(27, 243);
			this.button_calcVout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button_calcVout.Name = "button_calcVout";
			this.button_calcVout.Size = new System.Drawing.Size(86, 46);
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
			this.groupBox1.Location = new System.Drawing.Point(27, 44);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox1.Size = new System.Drawing.Size(167, 169);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Inputs";
			// 
			// textBox_rload
			// 
			this.textBox_rload.Location = new System.Drawing.Point(56, 132);
			this.textBox_rload.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textBox_rload.Name = "textBox_rload";
			this.textBox_rload.Size = new System.Drawing.Size(63, 20);
			this.textBox_rload.TabIndex = 38;
			// 
			// label_rload
			// 
			this.label_rload.AutoSize = true;
			this.label_rload.Location = new System.Drawing.Point(16, 133);
			this.label_rload.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_rload.Name = "label_rload";
			this.label_rload.Size = new System.Drawing.Size(38, 13);
			this.label_rload.TabIndex = 39;
			this.label_rload.Text = "Rload:";
			// 
			// checkBox_load
			// 
			this.checkBox_load.AutoSize = true;
			this.checkBox_load.Location = new System.Drawing.Point(32, 109);
			this.checkBox_load.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.checkBox_load.Name = "checkBox_load";
			this.checkBox_load.Size = new System.Drawing.Size(114, 17);
			this.checkBox_load.TabIndex = 37;
			this.checkBox_load.Text = "Account for Load?";
			this.checkBox_load.UseVisualStyleBackColor = true;
			this.checkBox_load.CheckedChanged += new System.EventHandler(this.checkBox_load_CheckedChanged);
			// 
			// textbox_vin
			// 
			this.textbox_vin.Location = new System.Drawing.Point(56, 31);
			this.textbox_vin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.textbox_vin.Name = "textbox_vin";
			this.textbox_vin.Size = new System.Drawing.Size(63, 20);
			this.textbox_vin.TabIndex = 34;
			this.textbox_vin.TextChanged += new System.EventHandler(this.textbox_vin_TextChanged);
			// 
			// label_inputVolt
			// 
			this.label_inputVolt.AutoSize = true;
			this.label_inputVolt.Location = new System.Drawing.Point(30, 31);
			this.label_inputVolt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_inputVolt.Name = "label_inputVolt";
			this.label_inputVolt.Size = new System.Drawing.Size(25, 13);
			this.label_inputVolt.TabIndex = 35;
			this.label_inputVolt.Text = "Vin:";
			// 
			// R1_textbox
			// 
			this.R1_textbox.Location = new System.Drawing.Point(56, 55);
			this.R1_textbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.R1_textbox.Name = "R1_textbox";
			this.R1_textbox.Size = new System.Drawing.Size(63, 20);
			this.R1_textbox.TabIndex = 30;
			this.R1_textbox.TextChanged += new System.EventHandler(this.R1_textbox_TextChanged);
			// 
			// R1_label
			// 
			this.R1_label.AutoSize = true;
			this.R1_label.Location = new System.Drawing.Point(31, 55);
			this.R1_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.R1_label.Name = "R1_label";
			this.R1_label.Size = new System.Drawing.Size(24, 13);
			this.R1_label.TabIndex = 31;
			this.R1_label.Text = "R1:";
			// 
			// R2_textbox
			// 
			this.R2_textbox.Location = new System.Drawing.Point(56, 80);
			this.R2_textbox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.R2_textbox.Name = "R2_textbox";
			this.R2_textbox.Size = new System.Drawing.Size(63, 20);
			this.R2_textbox.TabIndex = 32;
			this.R2_textbox.TextChanged += new System.EventHandler(this.R2_textbox_TextChanged);
			// 
			// R2_label
			// 
			this.R2_label.AutoSize = true;
			this.R2_label.Location = new System.Drawing.Point(31, 80);
			this.R2_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.R2_label.Name = "R2_label";
			this.R2_label.Size = new System.Drawing.Size(24, 13);
			this.R2_label.TabIndex = 33;
			this.R2_label.Text = "R2:";
			// 
			// voltD_page2
			// 
			this.voltD_page2.Controls.Add(this.groupBox2);
			this.voltD_page2.Controls.Add(this.clear_butt);
			this.voltD_page2.Controls.Add(this.Generate);
			this.voltD_page2.Controls.Add(this.groupBox3);
			this.voltD_page2.Location = new System.Drawing.Point(4, 22);
			this.voltD_page2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.voltD_page2.Name = "voltD_page2";
			this.voltD_page2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.voltD_page2.Size = new System.Drawing.Size(427, 338);
			this.voltD_page2.TabIndex = 1;
			this.voltD_page2.Text = "Generate R Values";
			this.voltD_page2.UseVisualStyleBackColor = true;
			this.voltD_page2.Click += new System.EventHandler(this.voltD_page2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.R2Val);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.R1Val);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(224, 26);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox2.Size = new System.Drawing.Size(186, 186);
			this.groupBox2.TabIndex = 43;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Outputs";
			// 
			// R2Val
			// 
			this.R2Val.Location = new System.Drawing.Point(11, 88);
			this.R2Val.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.R2Val.Name = "R2Val";
			this.R2Val.Size = new System.Drawing.Size(146, 18);
			this.R2Val.TabIndex = 29;
			this.R2Val.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 30;
			this.label2.Text = "R2 Value:";
			// 
			// R1Val
			// 
			this.R1Val.Location = new System.Drawing.Point(11, 45);
			this.R1Val.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.R1Val.Name = "R1Val";
			this.R1Val.Size = new System.Drawing.Size(146, 18);
			this.R1Val.TabIndex = 27;
			this.R1Val.Text = "";
			this.R1Val.TextChanged += new System.EventHandler(this.R1Val_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 25);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "R1 Value:";
			// 
			// clear_butt
			// 
			this.clear_butt.Location = new System.Drawing.Point(224, 266);
			this.clear_butt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.clear_butt.Name = "clear_butt";
			this.clear_butt.Size = new System.Drawing.Size(186, 46);
			this.clear_butt.TabIndex = 42;
			this.clear_butt.Text = "Clear";
			this.clear_butt.UseVisualStyleBackColor = true;
			this.clear_butt.Click += new System.EventHandler(this.clear_butt_Click);
			// 
			// Generate
			// 
			this.Generate.Location = new System.Drawing.Point(19, 266);
			this.Generate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Generate.Name = "Generate";
			this.Generate.Size = new System.Drawing.Size(203, 46);
			this.Generate.TabIndex = 41;
			this.Generate.Text = "Generate R values";
			this.Generate.UseVisualStyleBackColor = true;
			this.Generate.Click += new System.EventHandler(this.Generate_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.Rcheck);
			this.groupBox3.Controls.Add(this.MaxPower);
			this.groupBox3.Controls.Add(this.labe12);
			this.groupBox3.Controls.Add(this.Vin);
			this.groupBox3.Controls.Add(this.labelq);
			this.groupBox3.Controls.Add(this.Vout);
			this.groupBox3.Controls.Add(this.labelb);
			this.groupBox3.Controls.Add(this.R1);
			this.groupBox3.Controls.Add(this.label_r1manualEntry);
			this.groupBox3.Location = new System.Drawing.Point(19, 26);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.groupBox3.Size = new System.Drawing.Size(203, 225);
			this.groupBox3.TabIndex = 40;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Inputs";
			// 
			// Rcheck
			// 
			this.Rcheck.AutoSize = true;
			this.Rcheck.Location = new System.Drawing.Point(12, 117);
			this.Rcheck.Name = "Rcheck";
			this.Rcheck.Size = new System.Drawing.Size(180, 30);
			this.Rcheck.TabIndex = 42;
			this.Rcheck.Text = "Check if you have a pre-existing \r\nresistor value to enter";
			this.Rcheck.UseVisualStyleBackColor = true;
			this.Rcheck.CheckedChanged += new System.EventHandler(this.Rcheck_CheckedChanged);
			// 
			// MaxPower
			// 
			this.MaxPower.Location = new System.Drawing.Point(66, 88);
			this.MaxPower.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.MaxPower.Name = "MaxPower";
			this.MaxPower.Size = new System.Drawing.Size(63, 20);
			this.MaxPower.TabIndex = 40;
			this.MaxPower.TextChanged += new System.EventHandler(this.MaxPower_TextChanged);
			// 
			// labe12
			// 
			this.labe12.AutoSize = true;
			this.labe12.Location = new System.Drawing.Point(3, 77);
			this.labe12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labe12.Name = "labe12";
			this.labe12.Size = new System.Drawing.Size(66, 26);
			this.labe12.TabIndex = 41;
			this.labe12.Text = "Max Power  \r\n         (mW):";
			this.labe12.Click += new System.EventHandler(this.MaxPower_Click);
			// 
			// Vin
			// 
			this.Vin.Location = new System.Drawing.Point(66, 31);
			this.Vin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Vin.Name = "Vin";
			this.Vin.Size = new System.Drawing.Size(63, 20);
			this.Vin.TabIndex = 34;
			// 
			// labelq
			// 
			this.labelq.AutoSize = true;
			this.labelq.Location = new System.Drawing.Point(39, 31);
			this.labelq.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelq.Name = "labelq";
			this.labelq.Size = new System.Drawing.Size(25, 13);
			this.labelq.TabIndex = 35;
			this.labelq.Text = "Vin:";
			// 
			// Vout
			// 
			this.Vout.Location = new System.Drawing.Point(66, 55);
			this.Vout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Vout.Name = "Vout";
			this.Vout.Size = new System.Drawing.Size(63, 20);
			this.Vout.TabIndex = 30;
			// 
			// labelb
			// 
			this.labelb.AutoSize = true;
			this.labelb.Location = new System.Drawing.Point(32, 55);
			this.labelb.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.labelb.Name = "labelb";
			this.labelb.Size = new System.Drawing.Size(32, 13);
			this.labelb.TabIndex = 31;
			this.labelb.Text = "Vout:";
			// 
			// R1
			// 
			this.R1.Location = new System.Drawing.Point(66, 166);
			this.R1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.R1.Name = "R1";
			this.R1.Size = new System.Drawing.Size(63, 20);
			this.R1.TabIndex = 32;
			// 
			// label_r1manualEntry
			// 
			this.label_r1manualEntry.AutoSize = true;
			this.label_r1manualEntry.Location = new System.Drawing.Point(11, 169);
			this.label_r1manualEntry.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label_r1manualEntry.Name = "label_r1manualEntry";
			this.label_r1manualEntry.Size = new System.Drawing.Size(56, 13);
			this.label_r1manualEntry.TabIndex = 33;
			this.label_r1manualEntry.Text = "R1 value: ";
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
			// VoltageDivider
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(781, 519);
			this.Controls.Add(this.voltDivider_menu);
			this.Controls.Add(this.voltDivider_picBox);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "VoltageDivider";
			this.Text = "Voltage Divider Calc";
			this.Load += new System.EventHandler(this.VoltageDivider_Load);
			this.voltDivider_menu.ResumeLayout(false);
			this.voltD_page1.ResumeLayout(false);
			this.voltD_page1.PerformLayout();
			this.groupBox_outputs.ResumeLayout(false);
			this.groupBox_outputs.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.voltD_page2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.voltDivider_picBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox voltDivider_picBox;
		private System.Windows.Forms.TabControl voltDivider_menu;
		private System.Windows.Forms.TabPage voltD_page1;
		private System.Windows.Forms.TabPage voltD_page2;
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox R2Val;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox R1Val;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button clear_butt;
		private System.Windows.Forms.Button Generate;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox Vin;
		private System.Windows.Forms.Label labelq;
		private System.Windows.Forms.TextBox Vout;
		private System.Windows.Forms.Label labelb;
		private System.Windows.Forms.TextBox R1;
		private System.Windows.Forms.Label label_r1manualEntry;
		private System.Windows.Forms.TextBox MaxPower;
		private System.Windows.Forms.Label labe12;
		private System.Windows.Forms.CheckBox Rcheck;
	}
}