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

        public decimal loanAmount { get; set; }

        public float apr { get; set; }

        public decimal minimumPayment { get; set; }

        public int months { get; set; }

        public static int calculateMonths(LoanModel loan)
        {
            decimal total = loan.loanAmount;
            decimal interest = (decimal)(1 + loan.apr);
            decimal paymentAmount = loan.minimumPayment;
            int months = 0;

            while (total > 0)
            {
                total = total * interest;
                total -= paymentAmount;
                ++months;
            }

            return months;
        }
    }
}
