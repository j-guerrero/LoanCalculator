using LoanLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanUI
{
    public partial class CreateProfileForm : Form
    {
        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private bool ValidateName()
        {
            bool flag = true;

            if(nameValue.TextLength == 0)
            {
                flag = false;
                MessageBox.Show("Please enter a profile name.");
            }

            
            return flag;
        }

        private void CloseWindow()
        {
            this.Hide();
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string associatedFile = string.Format("{0}.csv", System.IO.Path.GetRandomFileName().Substring(0, 8));
            associatedFile = string.Concat("loans\\" + associatedFile);
            

            if (ValidateName())
            {
                if(CsvModel.AddNewProfileToIndex(
                    ConfigurationManager.AppSettings["filePath"],
                    nameValue.Text, associatedFile))
                {
                    CloseWindow();
                }
                // create empty file
            }  
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
    }
}
