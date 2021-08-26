
namespace Gold
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gold = new System.Windows.Forms.RadioButton();
            this.silver = new System.Windows.Forms.RadioButton();
            this.live = new System.Windows.Forms.RadioButton();
            this.historic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.goldlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.grams = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pricetograms = new System.Windows.Forms.RadioButton();
            this.gramstoprice = new System.Windows.Forms.RadioButton();
            this.pricelabel = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Checked = true;
            this.gold.Location = new System.Drawing.Point(3, 3);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(50, 19);
            this.gold.TabIndex = 0;
            this.gold.TabStop = true;
            this.gold.Text = "Gold";
            this.gold.UseVisualStyleBackColor = true;
            // 
            // silver
            // 
            this.silver.AutoSize = true;
            this.silver.Location = new System.Drawing.Point(3, 28);
            this.silver.Name = "silver";
            this.silver.Size = new System.Drawing.Size(53, 19);
            this.silver.TabIndex = 1;
            this.silver.Text = "Silver";
            this.silver.UseVisualStyleBackColor = true;
            this.silver.CheckedChanged += new System.EventHandler(this.silver_CheckedChanged);
            // 
            // live
            // 
            this.live.AutoSize = true;
            this.live.Checked = true;
            this.live.Location = new System.Drawing.Point(3, 3);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(46, 19);
            this.live.TabIndex = 2;
            this.live.TabStop = true;
            this.live.Text = "Live";
            this.live.UseVisualStyleBackColor = true;
            // 
            // historic
            // 
            this.historic.AutoSize = true;
            this.historic.Location = new System.Drawing.Point(3, 28);
            this.historic.Name = "historic";
            this.historic.Size = new System.Drawing.Size(75, 19);
            this.historic.TabIndex = 3;
            this.historic.Text = "Historical";
            this.historic.UseVisualStyleBackColor = true;
            this.historic.CheckedChanged += new System.EventHandler(this.historic_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gold);
            this.panel1.Controls.Add(this.silver);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 51);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.live);
            this.panel2.Controls.Add(this.historic);
            this.panel2.Location = new System.Drawing.Point(4, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 50);
            this.panel2.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(4, 122);
            this.monthCalendar1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goldlabel
            // 
            this.goldlabel.AutoSize = true;
            this.goldlabel.Location = new System.Drawing.Point(144, 6);
            this.goldlabel.Name = "goldlabel";
            this.goldlabel.Size = new System.Drawing.Size(83, 15);
            this.goldlabel.TabIndex = 8;
            this.goldlabel.Text = "Grams of Gold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(74, 24);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(71, 23);
            this.price.TabIndex = 10;
            // 
            // grams
            // 
            this.grams.Location = new System.Drawing.Point(149, 24);
            this.grams.Name = "grams";
            this.grams.Size = new System.Drawing.Size(71, 23);
            this.grams.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pricetograms);
            this.panel3.Controls.Add(this.gramstoprice);
            this.panel3.Location = new System.Drawing.Point(88, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 50);
            this.panel3.TabIndex = 7;
            // 
            // pricetograms
            // 
            this.pricetograms.AutoSize = true;
            this.pricetograms.Checked = true;
            this.pricetograms.Location = new System.Drawing.Point(3, 3);
            this.pricetograms.Name = "pricetograms";
            this.pricetograms.Size = new System.Drawing.Size(99, 19);
            this.pricetograms.TabIndex = 2;
            this.pricetograms.TabStop = true;
            this.pricetograms.Text = "Price > Grams";
            this.pricetograms.UseVisualStyleBackColor = true;
            // 
            // gramstoprice
            // 
            this.gramstoprice.AutoSize = true;
            this.gramstoprice.Location = new System.Drawing.Point(3, 28);
            this.gramstoprice.Name = "gramstoprice";
            this.gramstoprice.Size = new System.Drawing.Size(99, 19);
            this.gramstoprice.TabIndex = 3;
            this.gramstoprice.Text = "Grams > Price";
            this.gramstoprice.UseVisualStyleBackColor = true;
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(67, 48);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(119, 15);
            this.pricelabel.TabIndex = 12;
            this.pricelabel.Text = "Price per g: unknown";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(208, 68);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(12, 15);
            this.info.TabIndex = 13;
            this.info.Text = "?";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 119);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grams);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goldlabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Gold-Calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton gold;
        private System.Windows.Forms.RadioButton silver;
        private System.Windows.Forms.RadioButton live;
        private System.Windows.Forms.RadioButton historic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label goldlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox grams;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton pricetograms;
        private System.Windows.Forms.RadioButton gramstoprice;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label info;
    }
}

