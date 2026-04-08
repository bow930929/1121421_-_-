using System;
using System.Windows.Forms;

namespace _1121421_許志文_房貸計算器
{
    public partial class frmLoan : Form
    {
        public frmLoan()
        {
            InitializeComponent();
            // 在這裡綁定，不依賴 Designer
            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TryParseInputs(
                out double housePrice,
                out double downPaymentRatio,
                out double annualRate,
                out int loanYears,
                out int graceYears))
                return;

            double loan = housePrice * (1.0 - downPaymentRatio / 100.0);
            double r = annualRate / 100.0 / 12.0;
            int n = loanYears * 12;
            int g = graceYears * 12;

            double firstInterest = loan * r;
            double monthlyPayment;
            double totalRepayment;

            if (r == 0)
            {
                monthlyPayment = loan / Math.Max(n - g, 1);
                totalRepayment = loan;
            }
            else
            {
                int remain = n - g;
                double factor = Math.Pow(1 + r, remain);
                monthlyPayment = loan * r * factor / (factor - 1);
                totalRepayment = firstInterest * g + monthlyPayment * remain;
            }

            double firstPrincipal = (g > 0) ? 0 : (monthlyPayment - firstInterest);
            double totalInterest = totalRepayment - loan;

            txtTotalLoan.Text = loan.ToString("N2");
            txtMonthlyPayment.Text = monthlyPayment.ToString("N2");
            txtFirstInterest.Text = firstInterest.ToString("N2");
            txtFirstPrincipal.Text = firstPrincipal.ToString("N2");
            txtTotalInterest.Text = totalInterest.ToString("N2");
            txtTotalRepayment.Text = totalRepayment.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHousePrice.Text = "";
            txtDownPaymentRatio.Text = "";
            txtInterestRate.Text = "";
            txtLoanTerm.Text = "";
            txtGracePeriod.Text = "";

            txtTotalLoan.Text = "";
            txtMonthlyPayment.Text = "";
            txtFirstInterest.Text = "";
            txtFirstPrincipal.Text = "";
            txtTotalInterest.Text = "";
            txtTotalRepayment.Text = "";
        }

        private bool TryParseInputs(
            out double housePrice,
            out double downPaymentRatio,
            out double annualRate,
            out int loanYears,
            out int graceYears)
        {
            housePrice = downPaymentRatio = annualRate = 0;
            loanYears = graceYears = 0;

            if (!double.TryParse(txtHousePrice.Text.Trim(), out housePrice) || housePrice <= 0)
            { MessageBox.Show("房屋總價必須為正數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (!double.TryParse(txtDownPaymentRatio.Text.Trim(), out downPaymentRatio) || downPaymentRatio < 0 || downPaymentRatio >= 100)
            { MessageBox.Show("自備款比例須介於 0 ~ 99（%）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (!double.TryParse(txtInterestRate.Text.Trim(), out annualRate) || annualRate < 0)
            { MessageBox.Show("貸款利率須為非負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (!int.TryParse(txtLoanTerm.Text.Trim(), out loanYears) || loanYears <= 0)
            { MessageBox.Show("貸款年限必須為正整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            string g = txtGracePeriod.Text.Trim();
            if (string.IsNullOrEmpty(g)) { graceYears = 0; return true; }
            if (!int.TryParse(g, out graceYears) || graceYears < 0 || graceYears >= loanYears)
            { MessageBox.Show($"寬限期須介於 0 ~ {loanYears - 1} 年。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            return true;
        }

        // 保留原本空的 handler
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void lblMoneyPerMonth_Click(object sender, EventArgs e) { }
        private void lblFirstPayment_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void frmLoan_Load(object sender, EventArgs e) { }
    }
}