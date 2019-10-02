using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanLibrary
{
    public class LoanModel
    {
        public int id { get; set; }

        public decimal LoanAmount { get; set; }

        public float Apr { get; set; }

        public decimal MinimumPayment { get; set; }

        public int Months { get; set; }

        public LoanModel()
        {

        }

        /// <summary>
        /// Sets values recieved by form. Values checked for validation in form before given to constructor.
        /// </summary>
        /// <param name="loanAmount">Total amount of loan</param>
        /// <param name="apr">Annual Percentage Rate</param>
        /// <param name="months">Term in months</param>
        // TO-DO --- add enum type to handle "months vs payment" option from drop-down list in form
        public LoanModel(string loanAmount, string apr, string months)
        {
            decimal loanAmountValue = 0;
            decimal.TryParse(loanAmount, out loanAmountValue);
            LoanAmount = loanAmountValue;

            float aprValue = 0;
            float.TryParse(apr, out aprValue);
            Apr = aprValue;

            //decimal minimumPaymentValue = 0;
            //decimal.TryParse(minimumPayment, out minimumPaymentValue);
            //MinimumPayment = minimumPaymentValue;

            int monthsValue = 0;
            int.TryParse(months, out monthsValue);
            Months = monthsValue;
        }

    }
}
