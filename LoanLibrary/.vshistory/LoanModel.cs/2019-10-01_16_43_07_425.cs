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

        public static int calculateMonths(LoanModel loan)
        {
            decimal total = loan.LoanAmount;
            decimal interest = (decimal)(1 + loan.Apr);
            decimal paymentAmount = loan.MinimumPayment;
            int months = 1;

            while (total > 0)
            {
                total = total * interest;
                total -= paymentAmount;
                ++months;
            }

            return months;
        }

        public static decimal calculateMinimumPayment(LoanModel loan)
        {
            decimal total = loan.LoanAmount;
            decimal interest = (decimal)(loan.Apr / 100);
            decimal paymentAmount = 0;
            int months = loan.Months;

            total = total * (interest + 1);
            paymentAmount = Math.Round((total / months), 2);

            return paymentAmount;
        }
    }
}
