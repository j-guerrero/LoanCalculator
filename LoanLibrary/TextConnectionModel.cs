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

        public static bool AddNewProfileToIndex(string filePath, string name)
        {
            bool saveSuccessful = true;
            int length;
            int id;

            List<string> lines = new List<string>();
            filePath += "index.csv";
            MessageBox.Show($"{filePath}");

            // Open File
            try
            { lines = File.ReadAllLines(filePath).ToList(); }
            catch
            {
                saveSuccessful = false;
                MessageBox.Show("Unable to open file");
                return saveSuccessful;
            }

            length = lines.Count() - 1;
            string[] entries = lines[length].Split(',');
            Int32.TryParse(entries[0], out id);

            MessageBox.Show("Last Index = " + $"{id}");

            string output = $"{(id+1).ToString()}" + "," + $"{name}" + "\n";

            try
            {
                File.AppendAllText(filePath, output);
            }
            catch
            {
                saveSuccessful = false;
                MessageBox.Show("Unable to save file " + filePath);
                return saveSuccessful;
            }

            return saveSuccessful;

        }

        public static List<List<string>> ImportProfileList(string filePath)
        {
            List < List<string> > data = new List<List<string>>();
            List<string> lines = new List<string>();

            filePath += "index.csv";

            try
            { lines = File.ReadAllLines(filePath).ToList(); }
            catch
            {
                MessageBox.Show("Unable to open file");
                return null;
            }

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                string id = entries[0];
                string profileName = entries[1];

                data.Add(new List<string> { id, profileName });

            }

            return data;
        }

        public static void OpenFromCsv(this string filePath)
        {
            PeopleModel profile = new PeopleModel();
            List<string> lines = new List<string>();
            bool header = true;

            try {
                lines = File.ReadAllLines(filePath).ToList();
            }
            catch {
                MessageBox.Show("Unable to open file");
            }

            foreach (var line in lines)
            { 
                string[] entries = line.Split(',');

                if(header)
                {
                    profile.Name = entries[0];
                    header = false;
                }

                else
                {
                    int id;
                    decimal total;
                    decimal apr;
                    int term;
                    decimal minPay;

                    Int32.TryParse(entries[0], out id);
                    Decimal.TryParse(entries[2], out total);
                    Decimal.TryParse(entries[3], out apr);
                    Int32.TryParse(entries[4], out term);
                    Decimal.TryParse(entries[5], out minPay);

                    LoanModel tempLoan = new LoanModel(id, total, apr, term, minPay);
                    // TODO -- LOAD SOMETHING INTO OBJECT

                    profile.AddToLoanList(tempLoan);
                }
            }

            profile = null;
            lines = null;
            
        }
    }

    

    

    // TO-DO --- Create function to open file and save to List<Loans>

    // Open file
    // Find max id
    // Set ID = (MAX ID + 1)
    // Take data from <Loan> object and input into file
    // Save file
}
