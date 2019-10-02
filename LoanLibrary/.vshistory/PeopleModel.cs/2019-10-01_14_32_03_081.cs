using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanLibrary
{
    public class PeopleModel
    {
        public int id { get; set; };

        public List<LoanModel> loans { get; set; };

    }
}
