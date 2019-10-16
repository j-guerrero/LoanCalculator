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

        /// <summary>
        /// Function for adding new profile to CSV index file. Increments from last index placed in file
        /// Takes in directory path from App.Config and adds "index.csv" to end
        /// Returns a boolean flag to indicate success
        /// </summary>
        /// <param name="filePath"> File path where index.csv is saved</param>
        /// <param name="name"> Name of profile to be associated with new ID</param>
        /// <returns></returns>
        public static bool AddNewProfileToIndex(string filePath, string name, string associatedFile)
        {
            bool saveSuccessful = true;
            int selectedLine;
            int id;

            string associatedFilePath = string.Concat(filePath, associatedFile);
            List<string> lines = new List<string>();
            filePath =string.Concat(filePath, "index.csv");

            // Create new file with name @ index 0 IF file doesn't exist already
            if (!File.Exists(filePath))
            {
                using (var sw = File.CreateText(filePath))
                {
                    sw.WriteLine("0," + $"{name}" + "," + $"{associatedFile}");
                    sw.Close();
                }
            }

            else
            {
                // File will not be able to be read if open in other application such
                // as Notepad or Excel
                try
                { lines = File.ReadAllLines(filePath).ToList(); }
                catch
                {
                    saveSuccessful = false;
                    MessageBox.Show("Unable to open file");
                    return saveSuccessful;
                }

                selectedLine = lines.Count() - 1;
                string[] entries = lines[selectedLine].Split(',');
                Int32.TryParse(entries[0], out id);

                // -- DEBUG MESSAGE -- 
                MessageBox.Show("Last Index = " + $"{id}");

                string output = $"{(id+1).ToString()}" + "," + $"{name}" + "," + $"{associatedFile}" + "\n";

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

            }

            if (!File.Exists(associatedFilePath))
            {
                using (var sw = File.CreateText(associatedFilePath))
                {
                    string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                    sw.WriteLine($"{name}"+ "," + $"{date}" + "\n");
                    sw.Close();
                }
            }

            else
            {
                saveSuccessful = false;
                MessageBox.Show("Unable to create profile");

                // remove last entry
                var tempLines = File.ReadAllLines(filePath);
                File.WriteAllLines(filePath, tempLines.Take(tempLines.Length - 1));

                return saveSuccessful;
            }

            return saveSuccessful;

        }

        public static List<List<string>> ImportProfileList(string filePath)
        {
            List < List<string> > data = new List<List<string>>();
            List<string> lines = new List<string>();

            filePath = string.Concat(filePath, "index.csv");

            if(!File.Exists(filePath))
            {
                MessageBox.Show("No index file exists");
                return data;
            }

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
                string associatedFileName = entries[2];

                data.Add(new List<string> { id, profileName, associatedFileName });

            }

            return data;
        }

        // TODO -- Create function that references this file from index.csv
        public static void OpenFromCsv(PeopleModel profile)
        {
            List<string> lines = new List<string>();

            try {
                lines = File.ReadAllLines(profile.FileName).ToList();
            }
            catch {
                MessageBox.Show("Unable to open file");
                return;
            }

            if (lines.Count() > 1 && lines[1] != "")
            {
                foreach (var line in lines.Skip(1))
                {
                    string[] entries = line.Split(',');

                    int id;
                    decimal total;
                    decimal apr;
                    int term;

                    Int32.TryParse(entries[0], out id);
                    Decimal.TryParse(entries[1], out total);
                    Decimal.TryParse(entries[2], out apr);
                    Int32.TryParse(entries[3], out term);

                    LoanModel tempLoan = new LoanModel(id, total, apr, term);

                    profile.AddToLoanList(tempLoan);

                }
            }
            

            lines = null;
            
        }

        public static void SaveToCsv(PeopleModel profile)
        {
            List<string> lines = new List<string>();
            List<LoanModel> loans = profile.Loans;

            string output = "";
            string header = "";

            try
            {
                header = File.ReadAllLines(profile.FileName).First() + "\n";
            }
            catch
            {
                MessageBox.Show("Unable to access file");
                return;
            }

            foreach (var loan in loans)
            {
                string loanOutput = $"{loan.Id}" + ","
                    + $"{loan.LoanAmount}" + ","
                    + $"{loan.MinimumPayment}" + ","
                    + $"{loan.Months}" + "\n";
                output = string.Concat(output, loanOutput);
            }

            output = string.Concat(header, output);

            try
            {
                File.WriteAllText(profile.FileName, output);
            }
            catch
            {
                MessageBox.Show("Unable to save to file:" + $"{profile.FileName}");
                return;
            }

            MessageBox.Show("Saved to file:" + $"{profile.FileName}");

        }

    }

    

    

    // TO-DO --- Create function to open file and save to List<Loans>

    // Open file
    // Find max id
    // Set ID = (MAX ID + 1)
    // Take data from <Loan> object and input into file
    // Save file
}
