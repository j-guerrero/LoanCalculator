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

        public static int calculateMonths(LoanModel loan)
        {
            decimal total = loan.LoanAmount;
            decimal interest = (decimal)(1 + loan.Apr);
            decimal paymentAmount = loan.MinimumPayment;
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
