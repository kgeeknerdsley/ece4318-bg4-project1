namespace ece_calculator_bg4
{
    partial class CervezaCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CervezaCalculator));
            this.richTextBox_numDrinks = new System.Windows.Forms.RichTextBox();
            this.label_numDrinks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_hours = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_minutes = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_cervezasDeath = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_bac = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox_weight = new System.Windows.Forms.RichTextBox();
            this.beer_gifs = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_currentGif = new System.Windows.Forms.PictureBox();
            this.linkLabel_alcHelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentGif)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_numDrinks
            // 
            this.richTextBox_numDrinks.Location = new System.Drawing.Point(111, 140);
            this.richTextBox_numDrinks.Name = "richTextBox_numDrinks";
            this.richTextBox_numDrinks.Size = new System.Drawing.Size(703, 176);
            this.richTextBox_numDrinks.TabIndex = 0;
            this.richTextBox_numDrinks.Text = "";
            // 
            // label_numDrinks
            // 
            this.label_numDrinks.AutoSize = true;
            this.label_numDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numDrinks.Location = new System.Drawing.Point(105, 78);
            this.label_numDrinks.Name = "label_numDrinks";
            this.label_numDrinks.Size = new System.Drawing.Size(599, 46);
            this.label_numDrinks.TabIndex = 1;
            this.label_numDrinks.Text = "Number of Cervezas Consumed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Elapsed Since First Drink:";
            // 
            // richTextBox_hours
            // 
            this.richTextBox_hours.Location = new System.Drawing.Point(113, 485);
            this.richTextBox_hours.Name = "richTextBox_hours";
            this.richTextBox_hours.Size = new System.Drawing.Size(361, 110);
            this.richTextBox_hours.TabIndex = 2;
            this.richTextBox_hours.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minutes:";
            // 
            // richTextBox_minutes
            // 
            this.richTextBox_minutes.Location = new System.Drawing.Point(480, 485);
            this.richTextBox_minutes.Name = "richTextBox_minutes";
            this.richTextBox_minutes.Size = new System.Drawing.Size(334, 110);
            this.richTextBox_minutes.TabIndex = 5;
            this.richTextBox_minutes.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 955);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(703, 260);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate BAC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(952, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(730, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cervezas Needed till Alcohol Poisoning:";
            // 
            // richTextBox_cervezasDeath
            // 
            this.richTextBox_cervezasDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_cervezasDeath.Location = new System.Drawing.Point(958, 676);
            this.richTextBox_cervezasDeath.Name = "richTextBox_cervezasDeath";
            this.richTextBox_cervezasDeath.Size = new System.Drawing.Size(712, 176);
            this.richTextBox_cervezasDeath.TabIndex = 8;
            this.richTextBox_cervezasDeath.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(952, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "BAC:";
            // 
            // richTextBox_bac
            // 
            this.richTextBox_bac.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_bac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_bac.Location = new System.Drawing.Point(958, 299);
            this.richTextBox_bac.Name = "richTextBox_bac";
            this.richTextBox_bac.Size = new System.Drawing.Size(712, 176);
            this.richTextBox_bac.TabIndex = 10;
            this.richTextBox_bac.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(482, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 39);
            this.label6.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(107, 677);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 46);
            this.label8.TabIndex = 13;
            this.label8.Text = "Weight in Lbs:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // richTextBox_weight
            // 
            this.richTextBox_weight.Location = new System.Drawing.Point(113, 742);
            this.richTextBox_weight.Name = "richTextBox_weight";
            this.richTextBox_weight.Size = new System.Drawing.Size(703, 110);
            this.richTextBox_weight.TabIndex = 12;
            this.richTextBox_weight.Text = "";
            // 
            // beer_gifs
            // 
            this.beer_gifs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("beer_gifs.ImageStream")));
            this.beer_gifs.TransparentColor = System.Drawing.Color.Transparent;
            this.beer_gifs.Images.SetKeyName(0, "1.gif");
            // 
            // pictureBox_currentGif
            // 
            this.pictureBox_currentGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_currentGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_currentGif.Image")));
            this.pictureBox_currentGif.Location = new System.Drawing.Point(1707, 253);
            this.pictureBox_currentGif.Name = "pictureBox_currentGif";
            this.pictureBox_currentGif.Size = new System.Drawing.Size(480, 367);
            this.pictureBox_currentGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_currentGif.TabIndex = 17;
            this.pictureBox_currentGif.TabStop = false;
            // 
            // linkLabel_alcHelp
            // 
            this.linkLabel_alcHelp.AutoSize = true;
            this.linkLabel_alcHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_alcHelp.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_alcHelp.Location = new System.Drawing.Point(1010, 1173);
            this.linkLabel_alcHelp.Name = "linkLabel_alcHelp";
            this.linkLabel_alcHelp.Size = new System.Drawing.Size(1105, 69);
            this.linkLabel_alcHelp.TabIndex = 18;
            this.linkLabel_alcHelp.TabStop = true;
            this.linkLabel_alcHelp.Text = "https://drugabuse.com/alcohol/hotlines/";
            this.linkLabel_alcHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_alcHelp_LinkClicked);
            // 
            // CervezaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2614, 1475);
            this.Controls.Add(this.linkLabel_alcHelp);
            this.Controls.Add(this.pictureBox_currentGif);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox_weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_bac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_cervezasDeath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_minutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_hours);
            this.Controls.Add(this.label_numDrinks);
            this.Controls.Add(this.richTextBox_numDrinks);
            this.Name = "CervezaCalculator";
            this.Text = "CervezaCalculator";
            this.Load += new System.EventHandler(this.CervezaCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_currentGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_numDrinks;
        private System.Windows.Forms.Label label_numDrinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_hours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_minutes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_cervezasDeath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_bac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox_weight;
        private System.Windows.Forms.ImageList beer_gifs;
        private System.Windows.Forms.PictureBox pictureBox_currentGif;
        private System.Windows.Forms.LinkLabel linkLabel_alcHelp;
    }
}