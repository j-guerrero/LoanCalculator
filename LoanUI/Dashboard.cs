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
    public partial class Dashboard : Form
    {
        public bool externalWindow = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void simpleCalculatorButton_Click(object sender, EventArgs e)
        {
                InputForm calculator = new InputForm();
                this.Hide();
                calculator.ShowDialog();
                this.Close();
        }

        private void loadProfileButton_Click(object sender, EventArgs e)
        {
            // load file from comboBox
            // --- TEST ---

            LoanListViewer loanListViewer = new LoanListViewer();
            this.Hide();
            loanListViewer.ShowDialog();
            this.Close();
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            CreateProfileForm createProfileForm = new CreateProfileForm();
            createProfileForm.ShowDialog();
        }
    }
}
