using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanLibrary
{
    public static class TextConnectionModel
    {

        public static int Id { get; set; }

        public static string Name { get; set; }

        // TO-DO --- Create function to save to file

        // Open file
        // Find max id
        // Set ID = (MAX ID + 1)
        // Take data from <Loan> object and input into file
        // Save file

        public static void SaveToCsv(this string filePath)
        {
            MessageBox.Show("File Path: " + $"{ filePath }");
        }

        public static void OpenFromCsv(this string filePath)
        {

            List<string> lines = new List<string>();

            try {
                lines = File.ReadAllLines(filePath).ToList();
            }
            catch {
                MessageBox.Show("Unable to open file");
            }


            foreach (var line in lines)
            { 
                string[] entries = line.Split(',');

                int id;
                string name;
                decimal total;
                decimal apr;
                int term;
                decimal minPay;

                Int32.TryParse(entries[0], out id);
                name = entries[1].ToString();
                Decimal.TryParse(entries[2], out total);
                Decimal.TryParse(entries[3], out apr);
                Int32.TryParse(entries[4], out term);
                Decimal.TryParse(entries[5], out minPay);

                LoanModel tempLoan = new LoanModel(id, total, apr, term, minPay);
                // TODO -- LOAD SOMETHING INTO OBJECT

                tempLoan.DisplayInfo();


            }


        }
    }

    

    // TO-DO --- Create function to open file and save to List<Loans>

    // Open file
    // Find max id
    // Set ID = (MAX ID + 1)
    // Take data from <Loan> object and input into file
    // Save file
}
