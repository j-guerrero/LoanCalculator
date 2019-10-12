﻿using LoanLibrary;
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
    public partial class Dashboard : Form
    {
        public bool externalWindow = false;

        public List<List<string>> data = new List<List<string>>();

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
          
            if(ValidateProfile())
            {
                LoanListViewer loanListViewer = new LoanListViewer(Int32.Parse(data[loadProfileSelector.SelectedIndex][0]), data[loadProfileSelector.SelectedIndex][1], "temp");
                this.Hide();
                loanListViewer.ShowDialog();
                this.Close();
            }

        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            CreateProfileForm createProfileForm = new CreateProfileForm();
            createProfileForm.ShowDialog();
        }

        /// <summary>
        /// Imports list of names from index.csv to be used to select profile to load. 
        /// Data is saved in nested List in order to expot profile id, name, and filePath
        /// </summary>
        private void importDataButton_Click(object sender, EventArgs e)
        {
            loadProfileSelector.Items.Clear();
            data = null;
            data = TextConnectionModel.ImportProfileList(ConfigurationManager.AppSettings["filePath"]);

            foreach(var line in data)
            {
                string profileName = line[1];

                loadProfileSelector.Items.Add(profileName);
            }

            try { loadProfileSelector.SelectedIndex = loadProfileSelector.Items.Count-1; }
            catch { }
        }

        private bool ValidateProfile()
        {
            bool validated = true;
            int id;

            try
            {
                Int32.TryParse(data[loadProfileSelector.SelectedIndex][0], out id);
            }
            catch
            {
                MessageBox.Show("No input selected");
                validated = false;
            }

            return validated;
        }
    }
}
