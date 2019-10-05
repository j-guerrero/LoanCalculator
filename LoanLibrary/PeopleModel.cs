using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoanLibrary
{
    public class PeopleModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public List<LoanModel> loans { get; set; }

        public string fileName { get; set; }

        public PeopleModel()
        {
          fileName = $"{name}" + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
        }

        public PeopleModel(string name)
        {
            fileName = $"{name}" + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
        }
    }

    
}
