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

        public float APR { get; set; }

        public decimal minimumPayment { get; set; }

        public int months { get; set; }
    }
}
