namespace Prog3
{
    partial class Prog3Form
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.filingBox = new System.Windows.Forms.GroupBox();
            this.headOfHouseRdoBtn = new System.Windows.Forms.RadioButton();
            this.jointlyRdoBtn = new System.Windows.Forms.RadioButton();
            this.separatelyRdoBtn = new System.Windows.Forms.RadioButton();
            this.singleRdoBtn = new System.Windows.Forms.RadioButton();
            this.calcTaxBtn = new System.Windows.Forms.Button();
            this.marginalRateLbl = new System.Windows.Forms.Label();
            this.marginalRateOutLbl = new System.Windows.Forms.Label();
            this.taxOutLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.filingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(40, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(171, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "2019 Marginal Tax Rate Caclulator";
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Location = new System.Drawing.Point(15, 36);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(114, 13);
            this.incomeLbl.TabIndex = 1;
            this.incomeLbl.Text = "Enter Taxable Income:";
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(135, 33);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(100, 20);
            this.incomeTxt.TabIndex = 2;
            // 
            // filingBox
            // 
            this.filingBox.Controls.Add(this.headOfHouseRdoBtn);
            this.filingBox.Controls.Add(this.jointlyRdoBtn);
            this.filingBox.Controls.Add(this.separatelyRdoBtn);
            this.filingBox.Controls.Add(this.singleRdoBtn);
            this.filingBox.Location = new System.Drawing.Point(18, 65);
            this.filingBox.Name = "filingBox";
            this.filingBox.Size = new System.Drawing.Size(217, 124);
            this.filingBox.TabIndex = 3;
            this.filingBox.TabStop = false;
            this.filingBox.Text = "Filing Status";
            // 
            // headOfHouseRdoBtn
            // 
            this.headOfHouseRdoBtn.AutoSize = true;
            this.headOfHouseRdoBtn.Location = new System.Drawing.Point(6, 89);
            this.headOfHouseRdoBtn.Name = "headOfHouseRdoBtn";
            this.headOfHouseRdoBtn.Size = new System.Drawing.Size(117, 17);
            this.headOfHouseRdoBtn.TabIndex = 4;
            this.headOfHouseRdoBtn.Text = "Head of Household";
            this.headOfHouseRdoBtn.UseVisualStyleBackColor = true;
            this.headOfHouseRdoBtn.CheckedChanged += new System.EventHandler(this.headOfHouseRdoBtn_CheckedChanged);
            // 
            // jointlyRdoBtn
            // 
            this.jointlyRdoBtn.AutoSize = true;
            this.jointlyRdoBtn.Location = new System.Drawing.Point(6, 66);
            this.jointlyRdoBtn.Name = "jointlyRdoBtn";
            this.jointlyRdoBtn.Size = new System.Drawing.Size(119, 17);
            this.jointlyRdoBtn.TabIndex = 2;
            this.jointlyRdoBtn.Text = "Married Filing Jointly";
            this.jointlyRdoBtn.UseVisualStyleBackColor = true;
            this.jointlyRdoBtn.CheckedChanged += new System.EventHandler(this.jointlyRdoBtn_CheckedChanged);
            // 
            // separatelyRdoBtn
            // 
            this.separatelyRdoBtn.AutoSize = true;
            this.separatelyRdoBtn.Location = new System.Drawing.Point(7, 43);
            this.separatelyRdoBtn.Name = "separatelyRdoBtn";
            this.separatelyRdoBtn.Size = new System.Drawing.Size(140, 17);
            this.separatelyRdoBtn.TabIndex = 1;
            this.separatelyRdoBtn.Text = "Married Filing Separately";
            this.separatelyRdoBtn.UseVisualStyleBackColor = true;
            this.separatelyRdoBtn.CheckedChanged += new System.EventHandler(this.separatelyRdoBtn_CheckedChanged);
            // 
            // singleRdoBtn
            // 
            this.singleRdoBtn.AutoSize = true;
            this.singleRdoBtn.Location = new System.Drawing.Point(7, 20);
            this.singleRdoBtn.Name = "singleRdoBtn";
            this.singleRdoBtn.Size = new System.Drawing.Size(54, 17);
            this.singleRdoBtn.TabIndex = 0;
            this.singleRdoBtn.Text = "Single";
            this.singleRdoBtn.UseVisualStyleBackColor = true;
            this.singleRdoBtn.CheckedChanged += new System.EventHandler(this.singleRdoBtn_CheckedChanged);
            // 
            // calcTaxBtn
            // 
            this.calcTaxBtn.Location = new System.Drawing.Point(84, 206);
            this.calcTaxBtn.Name = "calcTaxBtn";
            this.calcTaxBtn.Size = new System.Drawing.Size(83, 23);
            this.calcTaxBtn.TabIndex = 4;
            this.calcTaxBtn.Text = "Calculate Tax";
            this.calcTaxBtn.UseVisualStyleBackColor = true;
            this.calcTaxBtn.Click += new System.EventHandler(this.calcTaxBtn_Click);
            // 
            // marginalRateLbl
            // 
            this.marginalRateLbl.AutoSize = true;
            this.marginalRateLbl.Location = new System.Drawing.Point(32, 243);
            this.marginalRateLbl.Name = "marginalRateLbl";
            this.marginalRateLbl.Size = new System.Drawing.Size(97, 13);
            this.marginalRateLbl.TabIndex = 5;
            this.marginalRateLbl.Text = "Marginal Tax Rate:";
            // 
            // marginalRateOutLbl
            // 
            this.marginalRateOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginalRateOutLbl.Location = new System.Drawing.Point(135, 242);
            this.marginalRateOutLbl.Name = "marginalRateOutLbl";
            this.marginalRateOutLbl.Size = new System.Drawing.Size(100, 20);
            this.marginalRateOutLbl.TabIndex = 6;
            // 
            // taxOutLbl
            // 
            this.taxOutLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutLbl.Location = new System.Drawing.Point(135, 273);
            this.taxOutLbl.Name = "taxOutLbl";
            this.taxOutLbl.Size = new System.Drawing.Size(100, 20);
            this.taxOutLbl.TabIndex = 8;
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(63, 274);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(66, 13);
            this.taxLbl.TabIndex = 7;
            this.taxLbl.Text = "Income Tax:";
            // 
            // Prog3Form
            // 
            this.AcceptButton = this.calcTaxBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 306);
            this.Controls.Add(this.taxOutLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.marginalRateOutLbl);
            this.Controls.Add(this.marginalRateLbl);
            this.Controls.Add(this.calcTaxBtn);
            this.Controls.Add(this.filingBox);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Prog3Form";
            this.Text = "Program 3";
            this.Load += new System.EventHandler(this.Prog2Form_Load);
            this.filingBox.ResumeLayout(false);
            this.filingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.GroupBox filingBox;
        private System.Windows.Forms.RadioButton headOfHouseRdoBtn;
        private System.Windows.Forms.RadioButton jointlyRdoBtn;
        private System.Windows.Forms.RadioButton separatelyRdoBtn;
        private System.Windows.Forms.RadioButton singleRdoBtn;
        private System.Windows.Forms.Button calcTaxBtn;
        private System.Windows.Forms.Label marginalRateLbl;
        private System.Windows.Forms.Label marginalRateOutLbl;
        private System.Windows.Forms.Label taxOutLbl;
        private System.Windows.Forms.Label taxLbl;
    }
}

