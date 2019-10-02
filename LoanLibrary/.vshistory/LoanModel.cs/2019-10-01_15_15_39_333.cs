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

        public static int calculateMonths(decimal amount, float apr, decimal payment)
        {
            decimal total = amount;
            float interest = 1 + apr;
            int months = 1;

            while( total > 0)
            {
                total = total * interest;
                total -= payment;
                ++months;
            }

            return months;
        }
    }
}
