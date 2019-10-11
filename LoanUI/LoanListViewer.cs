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
        PeopleModel profile;

        public LoanListViewer()
        {
            InitializeComponent();
           // LoadData(profile);

        }

        private void LoadData(PeopleModel data)
        {
            // initialize constructor for profile
        }

        private void WireUpForm()
        {
            // Attach values to labels and listBox
            profile.LoanAddedEvent += Profile_LoanAddedEvent;
        }

        private void Profile_LoanAddedEvent(object sender, string e)
        {
            // reload data in loanListBox
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save to CSV file -- update info by ID row
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // remove selected item from loanListBox
        }

        private void addLoanButton_Click(object sender, EventArgs e)
        {
            // add loan object to List<LoanModel> connected to <Person>
            // Update the loanListBox
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // Return to main menu
        }
    }
}
