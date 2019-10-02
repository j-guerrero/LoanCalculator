using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanLibrary
{
    public class LoanLogic
    {

        /// <summary>
        /// Calculates number of months need to pay off loan. Uses object values and returns (int)months
        /// </summary>
        /// <param name="loan">Single Loan</param>
        /// <returns></returns>
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

        /// <summary>
        /// Calculates minimum payment based off total, APR, and months inputted.
        /// Returns calculated decimal)paymentAmount 
        /// </summary>
        /// <param name="loan">Single Loan</param>
        /// <returns></returns>
        public static decimal calculateMinimumPayment(LoanModel loan)
        {
            decimal total = loan.LoanAmount;
            decimal interest = (decimal)(loan.Apr / 100);
            decimal paymentAmount = 0;
            int months = loan.Months;

            paymentAmount = total * (1 + interest) / months;

            return paymentAmount;
        }

        // TODO -- Aggregated calculations based on List<Loans>
    }
}
