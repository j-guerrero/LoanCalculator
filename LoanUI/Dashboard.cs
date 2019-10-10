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

    }
}
