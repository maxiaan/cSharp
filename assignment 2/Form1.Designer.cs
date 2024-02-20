using System;

namespace assignment_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTrade = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkGps = new System.Windows.Forms.CheckBox();
            this.chkLeather = new System.Windows.Forms.CheckBox();
            this.chkStereo = new System.Windows.Forms.CheckBox();
            this.grpExterior = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbPearl = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTrade = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.grpAccessories.SuspendLayout();
            this.grpExterior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MotorMates";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(514, 81);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Sale Price:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(472, 107);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(100, 13);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Accessories & Finish:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(523, 158);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(492, 186);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(80, 13);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Sales Tax (8%):";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(538, 251);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(470, 275);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(102, 13);
            this.lblTrade.TabIndex = 6;
            this.lblTrade.Text = "Trade-In Allowance:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(506, 351);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 13);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount Due";
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkGps);
            this.grpAccessories.Controls.Add(this.chkLeather);
            this.grpAccessories.Controls.Add(this.chkStereo);
            this.grpAccessories.Location = new System.Drawing.Point(34, 81);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(200, 100);
            this.grpAccessories.TabIndex = 8;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkGps
            // 
            this.chkGps.AutoSize = true;
            this.chkGps.Location = new System.Drawing.Point(20, 66);
            this.chkGps.Name = "chkGps";
            this.chkGps.Size = new System.Drawing.Size(102, 17);
            this.chkGps.TabIndex = 2;
            this.chkGps.Tag = "1,741.23";
            this.chkGps.Text = "GPS Navigation";
            this.chkGps.UseVisualStyleBackColor = true;
            // 
            // chkLeather
            // 
            this.chkLeather.AutoSize = true;
            this.chkLeather.Location = new System.Drawing.Point(20, 43);
            this.chkLeather.Name = "chkLeather";
            this.chkLeather.Size = new System.Drawing.Size(97, 17);
            this.chkLeather.TabIndex = 1;
            this.chkLeather.Tag = "987.41";
            this.chkLeather.Text = "Leather Interior";
            this.chkLeather.UseVisualStyleBackColor = true;
            // 
            // chkStereo
            // 
            this.chkStereo.AutoSize = true;
            this.chkStereo.Location = new System.Drawing.Point(20, 20);
            this.chkStereo.Name = "chkStereo";
            this.chkStereo.Size = new System.Drawing.Size(94, 17);
            this.chkStereo.TabIndex = 0;
            this.chkStereo.Tag = "425.76";
            this.chkStereo.Text = "Stereo System";
            this.chkStereo.UseVisualStyleBackColor = true;
            // 
            // grpExterior
            // 
            this.grpExterior.Controls.Add(this.rbCustom);
            this.grpExterior.Controls.Add(this.rbPearl);
            this.grpExterior.Controls.Add(this.rbStandard);
            this.grpExterior.Location = new System.Drawing.Point(34, 264);
            this.grpExterior.Name = "grpExterior";
            this.grpExterior.Size = new System.Drawing.Size(200, 100);
            this.grpExterior.TabIndex = 9;
            this.grpExterior.TabStop = false;
            this.grpExterior.Text = "Exterior Finish";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(20, 67);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(123, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.TabStop = true;
            this.rbCustom.Tag = "599.99";
            this.rbCustom.Text = "Customized Detailing";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbPearl
            // 
            this.rbPearl.AutoSize = true;
            this.rbPearl.Location = new System.Drawing.Point(20, 44);
            this.rbPearl.Name = "rbPearl";
            this.rbPearl.Size = new System.Drawing.Size(49, 17);
            this.rbPearl.TabIndex = 1;
            this.rbPearl.TabStop = true;
            this.rbPearl.Tag = "345.72";
            this.rbPearl.Text = "Pearl";
            this.rbPearl.UseVisualStyleBackColor = true;
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(20, 20);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Tag = "0";
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // txtFinish
            // 
            this.txtFinish.Location = new System.Drawing.Point(579, 108);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.ReadOnly = true;
            this.txtFinish.Size = new System.Drawing.Size(100, 20);
            this.txtFinish.TabIndex = 11;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(579, 158);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(578, 186);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(579, 251);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // txtTrade
            // 
            this.txtTrade.Location = new System.Drawing.Point(578, 278);
            this.txtTrade.Name = "txtTrade";
            this.txtTrade.Size = new System.Drawing.Size(100, 20);
            this.txtTrade.TabIndex = 15;
            this.txtTrade.TextChanged += new System.EventHandler(this.txtTrade_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(578, 351);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 16;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(473, 404);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(579, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(677, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(34, 425);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(89, 13);
            this.lblTodaysDate.TabIndex = 20;
            this.lblTodaysDate.Text = "[Calculated Date]";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(34, 404);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(126, 13);
            this.lblCompanyName.TabIndex = 21;
            this.lblCompanyName.Text = "Shale\'s Super Auto Sales";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(579, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtTrade);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.grpExterior);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Shale\'s Super Auto Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExterior.ResumeLayout(false);
            this.grpExterior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.GroupBox grpExterior;
        private System.Windows.Forms.CheckBox chkGps;
        private System.Windows.Forms.CheckBox chkLeather;
        private System.Windows.Forms.CheckBox chkStereo;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbPearl;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTrade;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

