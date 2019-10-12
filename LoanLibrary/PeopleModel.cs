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
        public int Id { get; set; }

        public string Name { get; set; }

        public List<LoanModel> Loans { get; set; }

        public string FileName { get; set; }

        public PeopleModel()
        {
          Name = "Empty";
          Loans = new List<LoanModel>();
          FileName = $"{Name}" + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
        }

        public PeopleModel(string name)
        {
            Loans = new List<LoanModel>();
            FileName = $"{name}" + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
        }

        public PeopleModel(int id, string name, string fileName)
        {
            Loans = new List<LoanModel>();
            Id = id;
            Name = name;
            FileName = $"{name}" + "_" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
        }

        public event EventHandler<string> LoanAddedEvent;

        public void AddToLoanList(LoanModel loan)
        {
            Loans.Add(loan);
            LoanAddedEvent?.Invoke(this, "Loan Added"); // use to update loanListBox in LoanListViewer
        }

        public void DisplayLoansInList()
        {
            foreach(var loan in Loans)
            {
                loan.DisplayInfo();
            }
        }
    }

    
}
