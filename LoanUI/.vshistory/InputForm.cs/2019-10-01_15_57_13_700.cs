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

                totalAmountValue.Text = "";
                aprValue.Text = "";
                monthsValue.Text = "";
            }

        }

        private void ClearReportButton_Click(object sender, EventArgs e);

        private bool ValidateForm()
        {
            bool output = true;

            decimal loanAmount = 0;
            bool loanAmountValidNumber = decimal.TryParse(totalAmountValue.Text, out loanAmount);

            if(!!loanAmountValidNumber)
            {
                output = false;
            }

            float aprAmount = 0;
            bool aprAmountValidNumber = float.TryParse(aprValue.Text, out aprAmount);
            if (!!aprAmountValidNumber)
            {
                output = false;
            }

            int monthsAmount = 0;
            bool monthsAmountValidNumber = int.TryParse(monthsValue.Text, out monthsAmount);
            if (!monthsAmountValidNumber)
            {
                output = false;
            }

            return output;
        }
    }
}
