namespace LoanUI
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loanCalculatorLabel = new System.Windows.Forms.Label();
            this.totalAmountValue = new System.Windows.Forms.TextBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.calculationTypeSelector = new System.Windows.Forms.ComboBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loanCalculatorLabel
            // 
            this.loanCalculatorLabel.AutoSize = true;
            this.loanCalculatorLabel.Location = new System.Drawing.Point(15, 9);
            this.loanCalculatorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loanCalculatorLabel.Name = "loanCalculatorLabel";
            this.loanCalculatorLabel.Size = new System.Drawing.Size(157, 30);
            this.loanCalculatorLabel.TabIndex = 0;
            this.loanCalculatorLabel.Text = "Loan Calculator";
            this.loanCalculatorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalAmountValue
            // 
            this.totalAmountValue.Location = new System.Drawing.Point(167, 102);
            this.totalAmountValue.Name = "totalAmountValue";
            this.totalAmountValue.Size = new System.Drawing.Size(181, 35);
            this.totalAmountValue.TabIndex = 1;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(15, 102);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.totalAmountLabel.TabIndex = 2;
            this.totalAmountLabel.Text = "Total Amount:";
            // 
            // calculationTypeSelector
            // 
            this.calculationTypeSelector.FormattingEnabled = true;
            this.calculationTypeSelector.Items.AddRange(new object[] {
            "Term of Loan",
            "Monthly Payment"});
            this.calculationTypeSelector.Location = new System.Drawing.Point(20, 152);
            this.calculationTypeSelector.Name = "calculationTypeSelector";
            this.calculationTypeSelector.Size = new System.Drawing.Size(328, 38);
            this.calculationTypeSelector.TabIndex = 3;
            this.calculationTypeSelector.SelectedIndexChanged += new System.EventHandler(this.calculationTypeSelector_SelectedIndexChanged);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(55, 419);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(250, 52);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 486);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.calculationTypeSelector);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.totalAmountValue);
            this.Controls.Add(this.loanCalculatorLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "InputForm";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanCalculatorLabel;
        private System.Windows.Forms.TextBox totalAmountValue;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.ComboBox calculationTypeSelector;
        private System.Windows.Forms.Button generateReportButton;
    }
}

