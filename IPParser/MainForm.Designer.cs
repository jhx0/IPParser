using System.Collections.Generic;
using System.Reflection.Emit;

namespace IPParser
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnIPConvert = new System.Windows.Forms.Button();
            this.lblOctet1 = new System.Windows.Forms.Label();
            this.lblOctet2 = new System.Windows.Forms.Label();
            this.lblOctet3 = new System.Windows.Forms.Label();
            this.lblOctet4 = new System.Windows.Forms.Label();
            this.txtBoxOctet1 = new System.Windows.Forms.TextBox();
            this.txtBoxOctet2 = new System.Windows.Forms.TextBox();
            this.txtBoxOctet3 = new System.Windows.Forms.TextBox();
            this.txtBoxOctet4 = new System.Windows.Forms.TextBox();
            this.txtBoxBinOctet1 = new System.Windows.Forms.TextBox();
            this.txtBoxHexOctet1 = new System.Windows.Forms.TextBox();
            this.txtBoxBinOctet2 = new System.Windows.Forms.TextBox();
            this.txtBoxHexOctet2 = new System.Windows.Forms.TextBox();
            this.txtBoxBinOctet3 = new System.Windows.Forms.TextBox();
            this.txtBoxHexOctet3 = new System.Windows.Forms.TextBox();
            this.txtBoxBinOctet4 = new System.Windows.Forms.TextBox();
            this.txtBoxHexOctet4 = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Location = new System.Drawing.Point(93, 19);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(155, 20);
            this.txtBoxIP.TabIndex = 0;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.Location = new System.Drawing.Point(19, 22);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(68, 13);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address";
            // 
            // btnIPConvert
            // 
            this.btnIPConvert.Location = new System.Drawing.Point(22, 58);
            this.btnIPConvert.Name = "btnIPConvert";
            this.btnIPConvert.Size = new System.Drawing.Size(101, 29);
            this.btnIPConvert.TabIndex = 2;
            this.btnIPConvert.Text = "Convert";
            this.btnIPConvert.UseVisualStyleBackColor = true;
            this.btnIPConvert.Click += new System.EventHandler(this.btnIPConvert_Click);
            // 
            // lblOctet1
            // 
            this.lblOctet1.AutoSize = true;
            this.lblOctet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctet1.Location = new System.Drawing.Point(23, 111);
            this.lblOctet1.Name = "lblOctet1";
            this.lblOctet1.Size = new System.Drawing.Size(49, 13);
            this.lblOctet1.TabIndex = 3;
            this.lblOctet1.Text = "Octet 1";
            // 
            // lblOctet2
            // 
            this.lblOctet2.AutoSize = true;
            this.lblOctet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctet2.Location = new System.Drawing.Point(23, 137);
            this.lblOctet2.Name = "lblOctet2";
            this.lblOctet2.Size = new System.Drawing.Size(49, 13);
            this.lblOctet2.TabIndex = 4;
            this.lblOctet2.Text = "Octet 2";
            // 
            // lblOctet3
            // 
            this.lblOctet3.AutoSize = true;
            this.lblOctet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctet3.Location = new System.Drawing.Point(23, 162);
            this.lblOctet3.Name = "lblOctet3";
            this.lblOctet3.Size = new System.Drawing.Size(49, 13);
            this.lblOctet3.TabIndex = 5;
            this.lblOctet3.Text = "Octet 3";
            // 
            // lblOctet4
            // 
            this.lblOctet4.AutoSize = true;
            this.lblOctet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctet4.Location = new System.Drawing.Point(23, 188);
            this.lblOctet4.Name = "lblOctet4";
            this.lblOctet4.Size = new System.Drawing.Size(49, 13);
            this.lblOctet4.TabIndex = 6;
            this.lblOctet4.Text = "Octet 4";
            // 
            // txtBoxOctet1
            // 
            this.txtBoxOctet1.Location = new System.Drawing.Point(78, 108);
            this.txtBoxOctet1.Name = "txtBoxOctet1";
            this.txtBoxOctet1.ReadOnly = true;
            this.txtBoxOctet1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOctet1.TabIndex = 7;
            this.txtBoxOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxOctet2
            // 
            this.txtBoxOctet2.Location = new System.Drawing.Point(78, 134);
            this.txtBoxOctet2.Name = "txtBoxOctet2";
            this.txtBoxOctet2.ReadOnly = true;
            this.txtBoxOctet2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOctet2.TabIndex = 8;
            this.txtBoxOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxOctet3
            // 
            this.txtBoxOctet3.Location = new System.Drawing.Point(78, 159);
            this.txtBoxOctet3.Name = "txtBoxOctet3";
            this.txtBoxOctet3.ReadOnly = true;
            this.txtBoxOctet3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOctet3.TabIndex = 9;
            this.txtBoxOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxOctet4
            // 
            this.txtBoxOctet4.Location = new System.Drawing.Point(78, 185);
            this.txtBoxOctet4.Name = "txtBoxOctet4";
            this.txtBoxOctet4.ReadOnly = true;
            this.txtBoxOctet4.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOctet4.TabIndex = 10;
            this.txtBoxOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBinOctet1
            // 
            this.txtBoxBinOctet1.Location = new System.Drawing.Point(184, 108);
            this.txtBoxBinOctet1.Name = "txtBoxBinOctet1";
            this.txtBoxBinOctet1.ReadOnly = true;
            this.txtBoxBinOctet1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBinOctet1.TabIndex = 11;
            this.txtBoxBinOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxHexOctet1
            // 
            this.txtBoxHexOctet1.Location = new System.Drawing.Point(290, 108);
            this.txtBoxHexOctet1.Name = "txtBoxHexOctet1";
            this.txtBoxHexOctet1.ReadOnly = true;
            this.txtBoxHexOctet1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHexOctet1.TabIndex = 12;
            this.txtBoxHexOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBinOctet2
            // 
            this.txtBoxBinOctet2.Location = new System.Drawing.Point(184, 134);
            this.txtBoxBinOctet2.Name = "txtBoxBinOctet2";
            this.txtBoxBinOctet2.ReadOnly = true;
            this.txtBoxBinOctet2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBinOctet2.TabIndex = 13;
            this.txtBoxBinOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxHexOctet2
            // 
            this.txtBoxHexOctet2.Location = new System.Drawing.Point(290, 134);
            this.txtBoxHexOctet2.Name = "txtBoxHexOctet2";
            this.txtBoxHexOctet2.ReadOnly = true;
            this.txtBoxHexOctet2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHexOctet2.TabIndex = 14;
            this.txtBoxHexOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBinOctet3
            // 
            this.txtBoxBinOctet3.Location = new System.Drawing.Point(184, 159);
            this.txtBoxBinOctet3.Name = "txtBoxBinOctet3";
            this.txtBoxBinOctet3.ReadOnly = true;
            this.txtBoxBinOctet3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBinOctet3.TabIndex = 15;
            this.txtBoxBinOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxHexOctet3
            // 
            this.txtBoxHexOctet3.Location = new System.Drawing.Point(290, 159);
            this.txtBoxHexOctet3.Name = "txtBoxHexOctet3";
            this.txtBoxHexOctet3.ReadOnly = true;
            this.txtBoxHexOctet3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHexOctet3.TabIndex = 16;
            this.txtBoxHexOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBinOctet4
            // 
            this.txtBoxBinOctet4.Location = new System.Drawing.Point(184, 185);
            this.txtBoxBinOctet4.Name = "txtBoxBinOctet4";
            this.txtBoxBinOctet4.ReadOnly = true;
            this.txtBoxBinOctet4.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBinOctet4.TabIndex = 17;
            this.txtBoxBinOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxHexOctet4
            // 
            this.txtBoxHexOctet4.Location = new System.Drawing.Point(290, 185);
            this.txtBoxHexOctet4.Name = "txtBoxHexOctet4";
            this.txtBoxHexOctet4.ReadOnly = true;
            this.txtBoxHexOctet4.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHexOctet4.TabIndex = 18;
            this.txtBoxHexOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(327, 228);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 75);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainFrm
            // 
            this.AcceptButton = this.btnIPConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.txtBoxHexOctet4);
            this.Controls.Add(this.txtBoxBinOctet4);
            this.Controls.Add(this.txtBoxHexOctet3);
            this.Controls.Add(this.txtBoxBinOctet3);
            this.Controls.Add(this.txtBoxHexOctet2);
            this.Controls.Add(this.txtBoxBinOctet2);
            this.Controls.Add(this.txtBoxHexOctet1);
            this.Controls.Add(this.txtBoxBinOctet1);
            this.Controls.Add(this.txtBoxOctet4);
            this.Controls.Add(this.txtBoxOctet3);
            this.Controls.Add(this.txtBoxOctet2);
            this.Controls.Add(this.txtBoxOctet1);
            this.Controls.Add(this.lblOctet4);
            this.Controls.Add(this.lblOctet3);
            this.Controls.Add(this.lblOctet2);
            this.Controls.Add(this.lblOctet1);
            this.Controls.Add(this.btnIPConvert);
            this.Controls.Add(this.lblIPAddress);
            this.Controls.Add(this.txtBoxIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPParser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIP;

        private System.Windows.Forms.Label lblIPAddress;

        private System.Windows.Forms.Button btnIPConvert;

        private System.Windows.Forms.Label lblOctet1;
        private System.Windows.Forms.Label lblOctet2;
        private System.Windows.Forms.Label lblOctet3;
        private System.Windows.Forms.Label lblOctet4;

        private System.Windows.Forms.TextBox txtBoxOctet1;
        private System.Windows.Forms.TextBox txtBoxOctet2;
        private System.Windows.Forms.TextBox txtBoxOctet3;
        private System.Windows.Forms.TextBox txtBoxOctet4;

        private System.Windows.Forms.TextBox txtBoxBinOctet1;
        private System.Windows.Forms.TextBox txtBoxBinOctet2;
        private System.Windows.Forms.TextBox txtBoxBinOctet3;
        private System.Windows.Forms.TextBox txtBoxBinOctet4;

        private System.Windows.Forms.TextBox txtBoxHexOctet2;
        private System.Windows.Forms.TextBox txtBoxHexOctet1;
        private System.Windows.Forms.TextBox txtBoxHexOctet3;
        private System.Windows.Forms.TextBox txtBoxHexOctet4;

        private System.Windows.Forms.Button BtnClose;

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

