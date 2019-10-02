using LoanLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanUI
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                LoanModel loan = new LoanModel(
                    totalAmountValue.Text,
                    aprValue.Text,
                    monthsValue.Text);

                minimumMonthlyPaymentValue.Text = LoanModel.calculateMinimumPayment(loan).ToString();
            }

            else
            {
                MessageBox.Show("This from has invalid information. Please check for valid input.");
            }
        }

        private void clearReportButton_Click(object sender, EventArgs e)
        {
            totalAmountValue.Text = "";
            aprValue.Text = "";
            monthsValue.Text = "";
        }

        private bool ValidateForm()
        {
            bool output = true;

            decimal loanAmount = 0;
            bool loanAmountValidNumber = decimal.TryParse(totalAmountValue.Text, out loanAmount);

            if (!loanAmountValidNumber)
            {
                output = false;
            }

            float aprAmount = 0;
            bool aprAmountValidNumber = float.TryParse(aprValue.Text, out aprAmount);
            if (!aprAmountValidNumber)
            {
                output = false;
            }

            int monthsAmount = 0;
            bool monthsAmountValidNumber = int.TryParse(monthsValue.Text, out monthsAmount);
            if (!monthsAmountValidNumber)
            {
                output = false;
            }

            MessageBox.Show("loanAmountValidNumber =" + $"{ loanAmountValidNumber }" + "\n aprValidNumber=" +$"{aprAmountValidNumber}" + "\n monthsAmountValidNumber = " + $"{monthsAmountValidNumber}" + "\n\n Output = " + $"{output}");

            return output;
        }
    }
}
