using LoanLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanUI
{
    public partial class LoanListViewer : Form
    {
        // Container for profile data
        public PeopleModel profile;

        public LoanListViewer()
        {
            InitializeComponent();
        }

        public LoanListViewer(int id, string name, string fileName)
        {
            InitializeComponent();
            profile = new PeopleModel(id, name, fileName);
            InitializeLoans();
            WireUpForm();
            // LoadData(profile);
        }

        private void InitializeLoans()
        {
            CsvModel.OpenFromCsv(profile);
            LoadLoans();
        }

        private void LoadLoans()
        {
            loanListBox.Items.Clear();
            foreach(var loan in profile.Loans)
            {
                loanListBox.Items.Add("$" + $"{loan.LoanAmount}" + " @ " + $"{loan.Apr}" + "%");
            }
        }

        private void WireUpForm()
        {
            // Attach values to labels and listBox
            personNameLabel.Text = profile.Name;
        }

        private void Profile_LoanAddedEvent(object sender, string e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Open file stream to PeopleModel.fileName
            // Will overwrite current file
            // For every loan in list loan, write info to line
            // Close file
            CsvModel.SaveToCsv(profile);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // REMOVE LOAN FROM PersonModel.Loans = done
            if(profile.Loans.ElementAtOrDefault(loanListBox.SelectedIndex) != null)
            {
                profile.Loans.RemoveAt(loanListBox.SelectedIndex);
            }

            else
            {
                MessageBox.Show("No item selected");
                return;
            }

            // REMOVE ITEM FROM loanListBox = DONE
            try{ loanListBox.Items.RemoveAt(loanListBox.SelectedIndex); }
            catch { MessageBox.Show("No item selected"); };
        }

        private void addLoanButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                LoanModel tempLoan = new LoanModel(totalAmountValue.Text, aprValue.Text, monthsValue.Text);
                profile.Loans.Add(tempLoan);
                this.LoadLoans();
                totalAmountValue.Text = "";
                aprValue.Text = "";
                monthsValue.Text = "";
            }

            else
            {
                MessageBox.Show("This from has invalid information. Please check for valid input.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            decimal loanAmount = 0;
            bool loanAmountValidNumber = decimal.TryParse(totalAmountValue.Text, out loanAmount);

            if (!loanAmountValidNumber)
            {
                output = false;
            }

            decimal aprAmount = 0;
            bool aprAmountValidNumber = decimal.TryParse(aprValue.Text, out aprAmount);
            if (!aprAmountValidNumber)
            {
                output = false;
            }

            int monthsAmount = 0;
            bool monthsAmountValidNumber = int.TryParse(monthsValue.Text, out monthsAmount);
            if (!monthsAmountValidNumber)
            {
                output = false;
            }

            return output;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
