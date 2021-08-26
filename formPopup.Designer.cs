
namespace money_calc
{
    partial class formPopup
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
            this.dennethnl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.api = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dennethnl
            // 
            this.dennethnl.AutoSize = true;
            this.dennethnl.Location = new System.Drawing.Point(256, 38);
            this.dennethnl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dennethnl.Name = "dennethnl";
            this.dennethnl.Size = new System.Drawing.Size(65, 15);
            this.dennethnl.TabIndex = 0;
            this.dennethnl.TabStop = true;
            this.dennethnl.Text = "Denneth.nl";
            this.dennethnl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dennethnl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made by Denneth Ahles in C# using Visual Studio 2019";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gold price from:";
            // 
            // api
            // 
            this.api.AutoSize = true;
            this.api.Location = new System.Drawing.Point(104, 38);
            this.api.Name = "api";
            this.api.Size = new System.Drawing.Size(86, 15);
            this.api.TabIndex = 3;
            this.api.TabStop = true;
            this.api.Text = "goldpriceapi.io";
            this.api.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.api_LinkClicked);
            // 
            // formPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 67);
            this.Controls.Add(this.api);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dennethnl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formPopup";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel dennethnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel api;
    }
}