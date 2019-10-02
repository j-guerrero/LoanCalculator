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
                LoanModel loan = new LoanModel();

                loan.LoanAmount = (decimal)totalAmountValue.Text;

            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            decimal loanAmount = 0;
            bool loanAmountValidNumber = decimal.TryParse(totalAmountValue.Text, out loanAmount);

            if(!!loanAmountValidNumber)
            {
                output = false;
            }

            return output;
        }
    }
}
