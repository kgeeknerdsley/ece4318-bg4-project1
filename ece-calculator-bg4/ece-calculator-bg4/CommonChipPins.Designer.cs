namespace ece_calculator_bg4
{
	partial class CommonChipPins
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.classText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addClassBtn);
            this.groupBox1.Controls.Add(this.classText);
            this.groupBox1.Location = new System.Drawing.Point(78, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Class";
            // 
            // addClassBtn
            // 
            this.addClassBtn.Location = new System.Drawing.Point(297, 50);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(124, 48);
            this.addClassBtn.TabIndex = 1;
            this.addClassBtn.Text = "Add";
            this.addClassBtn.UseVisualStyleBackColor = true;
            this.addClassBtn.Click += new System.EventHandler(this.addNewClassBtn);
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(6, 56);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(285, 38);
            this.classText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Location = new System.Drawing.Point(78, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing Classes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Checked";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.removeClassBtn);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(409, 284);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addFileBtn);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.fileListBox);
            this.groupBox3.Location = new System.Drawing.Point(600, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 559);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Course Datasheets";
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(6, 41);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(169, 53);
            this.addFileBtn.TabIndex = 3;
            this.addFileBtn.Text = "Add File";
            this.addFileBtn.UseVisualStyleBackColor = true;
            this.addFileBtn.Click += new System.EventHandler(this.addFileBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 490);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(390, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "Remove Selected";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.ItemHeight = 31;
            this.fileListBox.Location = new System.Drawing.Point(6, 108);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(390, 376);
            this.fileListBox.TabIndex = 0;
            this.fileListBox.SelectedIndexChanged += new System.EventHandler(this.fileListBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CommonChipPins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommonChipPins";
            this.Text = "CommonChipPins";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addClassBtn;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button addFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}