namespace _1121421_許志文_房貸計算器
{
    partial class frmLoan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentRatio = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanTerm = new System.Windows.Forms.TextBox();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.lblHousePrice = new System.Windows.Forms.Label();
            this.lblDownPaymentRatio = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.lblGracePeriod = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblTotalRepayment = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblMoneyPerMonth = new System.Windows.Forms.Label();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.txtTotalRepayment = new System.Windows.Forms.TextBox();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.txtFirstInterest = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtTotalLoan = new System.Windows.Forms.TextBox();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.txtFirstPrincipal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHousePrice.Location = new System.Drawing.Point(178, 119);
            this.txtHousePrice.Multiline = true;
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(168, 35);
            this.txtHousePrice.TabIndex = 0;
            this.txtHousePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDownPaymentRatio
            // 
            this.txtDownPaymentRatio.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPaymentRatio.Location = new System.Drawing.Point(178, 186);
            this.txtDownPaymentRatio.Multiline = true;
            this.txtDownPaymentRatio.Name = "txtDownPaymentRatio";
            this.txtDownPaymentRatio.Size = new System.Drawing.Size(168, 35);
            this.txtDownPaymentRatio.TabIndex = 1;
            this.txtDownPaymentRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(178, 249);
            this.txtInterestRate.Multiline = true;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(168, 35);
            this.txtInterestRate.TabIndex = 2;
            this.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoanTerm
            // 
            this.txtLoanTerm.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanTerm.Location = new System.Drawing.Point(178, 317);
            this.txtLoanTerm.Multiline = true;
            this.txtLoanTerm.Name = "txtLoanTerm";
            this.txtLoanTerm.Size = new System.Drawing.Size(168, 35);
            this.txtLoanTerm.TabIndex = 3;
            this.txtLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGracePeriod.Location = new System.Drawing.Point(178, 386);
            this.txtGracePeriod.Multiline = true;
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(168, 35);
            this.txtGracePeriod.TabIndex = 4;
            this.txtGracePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHousePrice
            // 
            this.lblHousePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHousePrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHousePrice.Location = new System.Drawing.Point(17, 119);
            this.lblHousePrice.Name = "lblHousePrice";
            this.lblHousePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHousePrice.Size = new System.Drawing.Size(142, 35);
            this.lblHousePrice.TabIndex = 5;
            this.lblHousePrice.Text = "房屋總價（元）";
            this.lblHousePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHousePrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDownPaymentRatio
            // 
            this.lblDownPaymentRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownPaymentRatio.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDownPaymentRatio.Location = new System.Drawing.Point(17, 186);
            this.lblDownPaymentRatio.Name = "lblDownPaymentRatio";
            this.lblDownPaymentRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDownPaymentRatio.Size = new System.Drawing.Size(142, 35);
            this.lblDownPaymentRatio.TabIndex = 6;
            this.lblDownPaymentRatio.Text = "自備款比例 （%）";
            this.lblDownPaymentRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterestRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblInterestRate.Location = new System.Drawing.Point(17, 249);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInterestRate.Size = new System.Drawing.Size(142, 35);
            this.lblInterestRate.TabIndex = 7;
            this.lblInterestRate.Text = "貸款利率（%）";
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoanTerm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLoanTerm.Location = new System.Drawing.Point(17, 317);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoanTerm.Size = new System.Drawing.Size(142, 35);
            this.lblLoanTerm.TabIndex = 8;
            this.lblLoanTerm.Text = "貸款年限（年）";
            this.lblLoanTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoanTerm.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblGracePeriod
            // 
            this.lblGracePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGracePeriod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGracePeriod.Location = new System.Drawing.Point(17, 386);
            this.lblGracePeriod.Name = "lblGracePeriod";
            this.lblGracePeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGracePeriod.Size = new System.Drawing.Size(142, 35);
            this.lblGracePeriod.TabIndex = 9;
            this.lblGracePeriod.Text = "寬限期（年）";
            this.lblGracePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReminder
            // 
            this.lblReminder.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReminder.Location = new System.Drawing.Point(12, 65);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReminder.Size = new System.Drawing.Size(276, 35);
            this.lblReminder.TabIndex = 10;
            this.lblReminder.Text = "請輸入以下資訊以供計算：";
            this.lblReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReminder.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblTotalRepayment
            // 
            this.lblTotalRepayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalRepayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalRepayment.Location = new System.Drawing.Point(477, 403);
            this.lblTotalRepayment.Name = "lblTotalRepayment";
            this.lblTotalRepayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalRepayment.Size = new System.Drawing.Size(129, 35);
            this.lblTotalRepayment.TabIndex = 20;
            this.lblTotalRepayment.Text = "總還款金額";
            this.lblTotalRepayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterest.Location = new System.Drawing.Point(477, 340);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalInterest.Size = new System.Drawing.Size(129, 35);
            this.lblTotalInterest.TabIndex = 19;
            this.lblTotalInterest.Text = "總利息支出";
            this.lblTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstInterest.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInterest.Location = new System.Drawing.Point(477, 214);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstInterest.Size = new System.Drawing.Size(129, 35);
            this.lblFirstInterest.TabIndex = 18;
            this.lblFirstInterest.Text = "首期利息";
            this.lblFirstInterest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstInterest.Click += new System.EventHandler(this.lblFirstPayment_Click);
            // 
            // lblMoneyPerMonth
            // 
            this.lblMoneyPerMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoneyPerMonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMoneyPerMonth.Location = new System.Drawing.Point(477, 144);
            this.lblMoneyPerMonth.Name = "lblMoneyPerMonth";
            this.lblMoneyPerMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMoneyPerMonth.Size = new System.Drawing.Size(129, 45);
            this.lblMoneyPerMonth.TabIndex = 17;
            this.lblMoneyPerMonth.Text = "每月應繳金額  （本+息）";
            this.lblMoneyPerMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoneyPerMonth.Click += new System.EventHandler(this.lblMoneyPerMonth_Click);
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalLoan.Location = new System.Drawing.Point(477, 82);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalLoan.Size = new System.Drawing.Size(129, 35);
            this.lblTotalLoan.TabIndex = 16;
            this.lblTotalLoan.Text = "貸款總金額";
            this.lblTotalLoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalLoan.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTotalRepayment
            // 
            this.txtTotalRepayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalRepayment.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalRepayment.Location = new System.Drawing.Point(612, 403);
            this.txtTotalRepayment.Multiline = true;
            this.txtTotalRepayment.Name = "txtTotalRepayment";
            this.txtTotalRepayment.ReadOnly = true;
            this.txtTotalRepayment.Size = new System.Drawing.Size(168, 35);
            this.txtTotalRepayment.TabIndex = 15;
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalInterest.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalInterest.Location = new System.Drawing.Point(612, 340);
            this.txtTotalInterest.Multiline = true;
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(168, 35);
            this.txtTotalInterest.TabIndex = 14;
            this.txtTotalInterest.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFirstInterest
            // 
            this.txtFirstInterest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFirstInterest.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstInterest.Location = new System.Drawing.Point(612, 214);
            this.txtFirstInterest.Multiline = true;
            this.txtFirstInterest.Name = "txtFirstInterest";
            this.txtFirstInterest.ReadOnly = true;
            this.txtFirstInterest.Size = new System.Drawing.Size(168, 35);
            this.txtFirstInterest.TabIndex = 13;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMonthlyPayment.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMonthlyPayment.Location = new System.Drawing.Point(612, 147);
            this.txtMonthlyPayment.Multiline = true;
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(168, 35);
            this.txtMonthlyPayment.TabIndex = 12;
            // 
            // txtTotalLoan
            // 
            this.txtTotalLoan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalLoan.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalLoan.Location = new System.Drawing.Point(612, 82);
            this.txtTotalLoan.Multiline = true;
            this.txtTotalLoan.Name = "txtTotalLoan";
            this.txtTotalLoan.ReadOnly = true;
            this.txtTotalLoan.Size = new System.Drawing.Size(168, 35);
            this.txtTotalLoan.TabIndex = 11;
            this.txtTotalLoan.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstPrincipal.Location = new System.Drawing.Point(477, 276);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstPrincipal.Size = new System.Drawing.Size(129, 35);
            this.lblFirstPrincipal.TabIndex = 22;
            this.lblFirstPrincipal.Text = "首期本金";
            this.lblFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstPrincipal
            // 
            this.txtFirstPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFirstPrincipal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstPrincipal.Location = new System.Drawing.Point(612, 276);
            this.txtFirstPrincipal.Multiline = true;
            this.txtFirstPrincipal.Name = "txtFirstPrincipal";
            this.txtFirstPrincipal.ReadOnly = true;
            this.txtFirstPrincipal.Size = new System.Drawing.Size(168, 35);
            this.txtFirstPrincipal.TabIndex = 21;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(352, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 121);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(352, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 65);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(276, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "房貸計算器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFirstPrincipal);
            this.Controls.Add(this.txtFirstPrincipal);
            this.Controls.Add(this.lblTotalRepayment);
            this.Controls.Add(this.lblTotalInterest);
            this.Controls.Add(this.lblFirstInterest);
            this.Controls.Add(this.lblMoneyPerMonth);
            this.Controls.Add(this.lblTotalLoan);
            this.Controls.Add(this.txtTotalRepayment);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.txtFirstInterest);
            this.Controls.Add(this.txtMonthlyPayment);
            this.Controls.Add(this.txtTotalLoan);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblGracePeriod);
            this.Controls.Add(this.lblLoanTerm);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblDownPaymentRatio);
            this.Controls.Add(this.lblHousePrice);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.txtLoanTerm);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtDownPaymentRatio);
            this.Controls.Add(this.txtHousePrice);
            this.Name = "frmLoan";
            this.Text = "房貸計算器";
            this.Load += new System.EventHandler(this.frmLoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.TextBox txtDownPaymentRatio;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtLoanTerm;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label lblHousePrice;
        private System.Windows.Forms.Label lblDownPaymentRatio;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label lblGracePeriod;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblTotalRepayment;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblMoneyPerMonth;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.TextBox txtTotalRepayment;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.TextBox txtFirstInterest;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtTotalLoan;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.TextBox txtFirstPrincipal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

