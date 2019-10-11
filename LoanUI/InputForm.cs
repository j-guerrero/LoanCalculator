using LoanLibrary;
using System;
using System.Configuration;
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
        [Flags]
        public enum formType { 
            monthTerm = 0, 
            minPay = 1
        };

        public InputForm()
        {
            InitializeComponent();
        }

        // TODO -- Load(<Person>) button


        private void generateReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPTION SELECTED = " + $"{(formType)calculationTypeSelector.SelectedIndex}");

            formType index = (formType)calculationTypeSelector.SelectedIndex;

            
            if (ValidateForm(index))
            {
                LoanModel loan = new LoanModel(
                    totalAmountValue.Text,
                    aprValue.Text,
                    calculationTypeValue.Text);

                // TODO --- Add loan to List<Loans> for <Person>

                decimal totalInterestPaid = (loan.LoanAmount * ((decimal)loan.Apr / 100));
                minimumMonthlyPaymentValue.Text = LoanLogic.calculateMinimumPayment(loan).ToString();
                totalInterestPaidValue.Text = totalInterestPaid.ToString() ;
                totalAmountPaidValue.Text = (loan.LoanAmount + totalInterestPaid).ToString();
                minimumMonthlyPaymentLabel.Text = "Minimum Monthly Payment:";

                MakeCalculationsVisible();

                // TODO -- MAKE TEST CONNECTION
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
            calculationTypeValue.Text = "";
            minimumMonthlyPaymentValue.Text = "";
            totalInterestPaidValue.Text = "";
            minimumMonthlyPaymentLabel.Hide();
            minimumMonthlyPaymentValue.Hide();
            totalInterestLabel.Hide();
            totalInterestPaidValue.Hide();
        }

        private void MakeCalculationsVisible()
        {
            minimumMonthlyPaymentLabel.Show();
            minimumMonthlyPaymentValue.Show();
            totalInterestLabel.Show();
            totalInterestPaidValue.Show();
            totalAmountPaidValue.Show();
            totalAmountPaidLabel.Show();
        }

        /// <summary>
        /// Validates form information in order to generate <Loan> object
        /// </summary>
        /// <returns> Boolean flag if validation is true </returns>
        private bool ValidateForm(formType index)
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

            if(index == formType.monthTerm)
            {
                int monthsAmount = 0;
                bool monthsAmountValidNumber = int.TryParse(calculationTypeValue.Text, out monthsAmount);
                if (!monthsAmountValidNumber)
                {
                    output = false;
                }
            }

            if(index == formType.minPay)
            {
                decimal minPayAmount = 0;
                bool minPayAmountValidNumber = decimal.TryParse(calculationTypeValue.Text, out minPayAmount);
                if (!minPayAmountValidNumber)
                {
                    output = false;
                }
            }

            return output;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string pathName = ConfigurationManager.AppSettings["filePath"] + "test.csv" ;
            // TextConnectionModel.SaveToCsv(pathName);

            // !!! -- DEBUGING --- SWITCH TO SAVE --- !!! 
            TextConnectionModel.OpenFromCsv(pathName);

        }
    }
}
