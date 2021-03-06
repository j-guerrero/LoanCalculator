﻿namespace LoanUI
{
    partial class SimpleCalculator
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
            this.generateReportButton = new System.Windows.Forms.Button();
            this.aprLabel = new System.Windows.Forms.Label();
            this.aprValue = new System.Windows.Forms.TextBox();
            this.calculationTypeValue = new System.Windows.Forms.TextBox();
            this.minimumMonthlyPaymentLabel = new System.Windows.Forms.Label();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.totalInterestPaidValue = new System.Windows.Forms.TextBox();
            this.totalInterestLabel = new System.Windows.Forms.Label();
            this.calculationTypeSelector = new System.Windows.Forms.ComboBox();
            this.calculationsBox = new System.Windows.Forms.GroupBox();
            this.totalAmountPaidValue = new System.Windows.Forms.TextBox();
            this.totalAmountPaidLabel = new System.Windows.Forms.Label();
            this.minimumMonthlyPaymentValue = new System.Windows.Forms.TextBox();
            this.calculationsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanCalculatorLabel
            // 
            this.loanCalculatorLabel.AutoSize = true;
            this.loanCalculatorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanCalculatorLabel.ForeColor = System.Drawing.Color.Black;
            this.loanCalculatorLabel.Location = new System.Drawing.Point(139, 31);
            this.loanCalculatorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loanCalculatorLabel.Name = "loanCalculatorLabel";
            this.loanCalculatorLabel.Size = new System.Drawing.Size(208, 37);
            this.loanCalculatorLabel.TabIndex = 0;
            this.loanCalculatorLabel.Text = "Loan Calculator";
            // 
            // totalAmountValue
            // 
            this.totalAmountValue.Location = new System.Drawing.Point(220, 102);
            this.totalAmountValue.Name = "totalAmountValue";
            this.totalAmountValue.Size = new System.Drawing.Size(181, 35);
            this.totalAmountValue.TabIndex = 1;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(68, 105);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.totalAmountLabel.TabIndex = 2;
            this.totalAmountLabel.Text = "Total Amount:";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(47, 464);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(191, 110);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.Location = new System.Drawing.Point(68, 151);
            this.aprLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(92, 30);
            this.aprLabel.TabIndex = 6;
            this.aprLabel.Text = "APR (%):";
            // 
            // aprValue
            // 
            this.aprValue.Location = new System.Drawing.Point(220, 148);
            this.aprValue.Name = "aprValue";
            this.aprValue.Size = new System.Drawing.Size(181, 35);
            this.aprValue.TabIndex = 5;
            // 
            // calculationTypeValue
            // 
            this.calculationTypeValue.Location = new System.Drawing.Point(220, 195);
            this.calculationTypeValue.Name = "calculationTypeValue";
            this.calculationTypeValue.Size = new System.Drawing.Size(181, 35);
            this.calculationTypeValue.TabIndex = 7;
            // 
            // minimumMonthlyPaymentLabel
            // 
            this.minimumMonthlyPaymentLabel.AutoSize = true;
            this.minimumMonthlyPaymentLabel.Location = new System.Drawing.Point(80, 53);
            this.minimumMonthlyPaymentLabel.Name = "minimumMonthlyPaymentLabel";
            this.minimumMonthlyPaymentLabel.Size = new System.Drawing.Size(276, 30);
            this.minimumMonthlyPaymentLabel.TabIndex = 9;
            this.minimumMonthlyPaymentLabel.Text = "Minimum Monthly Payment:\r\n";
            this.minimumMonthlyPaymentLabel.Visible = false;
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(241, 464);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(191, 110);
            this.clearFormButton.TabIndex = 4;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearReportButton_Click);
            // 
            // totalInterestPaidValue
            // 
            this.totalInterestPaidValue.BackColor = System.Drawing.Color.IndianRed;
            this.totalInterestPaidValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalInterestPaidValue.Location = new System.Drawing.Point(221, 174);
            this.totalInterestPaidValue.Name = "totalInterestPaidValue";
            this.totalInterestPaidValue.ReadOnly = true;
            this.totalInterestPaidValue.Size = new System.Drawing.Size(181, 28);
            this.totalInterestPaidValue.TabIndex = 12;
            this.totalInterestPaidValue.Visible = false;
            // 
            // totalInterestLabel
            // 
            this.totalInterestLabel.AutoSize = true;
            this.totalInterestLabel.Location = new System.Drawing.Point(245, 141);
            this.totalInterestLabel.Name = "totalInterestLabel";
            this.totalInterestLabel.Size = new System.Drawing.Size(133, 30);
            this.totalInterestLabel.TabIndex = 11;
            this.totalInterestLabel.Text = "Interest Paid:\r\n";
            this.totalInterestLabel.Visible = false;
            // 
            // calculationTypeSelector
            // 
            this.calculationTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculationTypeSelector.FormattingEnabled = true;
            this.calculationTypeSelector.Items.AddRange(new object[] {
            "Months",
            "Min Pay"});
            this.calculationTypeSelector.Location = new System.Drawing.Point(73, 192);
            this.calculationTypeSelector.Name = "calculationTypeSelector";
            this.calculationTypeSelector.Size = new System.Drawing.Size(138, 38);
            this.calculationTypeSelector.TabIndex = 13;
            // 
            // calculationsBox
            // 
            this.calculationsBox.Controls.Add(this.totalAmountPaidValue);
            this.calculationsBox.Controls.Add(this.totalAmountPaidLabel);
            this.calculationsBox.Controls.Add(this.minimumMonthlyPaymentLabel);
            this.calculationsBox.Controls.Add(this.totalInterestPaidValue);
            this.calculationsBox.Controls.Add(this.minimumMonthlyPaymentValue);
            this.calculationsBox.Controls.Add(this.totalInterestLabel);
            this.calculationsBox.Location = new System.Drawing.Point(20, 236);
            this.calculationsBox.Name = "calculationsBox";
            this.calculationsBox.Size = new System.Drawing.Size(437, 222);
            this.calculationsBox.TabIndex = 14;
            this.calculationsBox.TabStop = false;
            this.calculationsBox.Text = "Calculations";
            // 
            // totalAmountPaidValue
            // 
            this.totalAmountPaidValue.BackColor = System.Drawing.Color.IndianRed;
            this.totalAmountPaidValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalAmountPaidValue.Location = new System.Drawing.Point(37, 174);
            this.totalAmountPaidValue.Name = "totalAmountPaidValue";
            this.totalAmountPaidValue.ReadOnly = true;
            this.totalAmountPaidValue.Size = new System.Drawing.Size(181, 28);
            this.totalAmountPaidValue.TabIndex = 14;
            this.totalAmountPaidValue.Visible = false;
            // 
            // totalAmountPaidLabel
            // 
            this.totalAmountPaidLabel.AutoSize = true;
            this.totalAmountPaidLabel.Location = new System.Drawing.Point(33, 141);
            this.totalAmountPaidLabel.Name = "totalAmountPaidLabel";
            this.totalAmountPaidLabel.Size = new System.Drawing.Size(188, 30);
            this.totalAmountPaidLabel.TabIndex = 13;
            this.totalAmountPaidLabel.Text = "Total Amount Paid:\r\n";
            this.totalAmountPaidLabel.Visible = false;
            // 
            // minimumMonthlyPaymentValue
            // 
            this.minimumMonthlyPaymentValue.BackColor = System.Drawing.Color.PaleGreen;
            this.minimumMonthlyPaymentValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minimumMonthlyPaymentValue.Location = new System.Drawing.Point(128, 97);
            this.minimumMonthlyPaymentValue.Name = "minimumMonthlyPaymentValue";
            this.minimumMonthlyPaymentValue.ReadOnly = true;
            this.minimumMonthlyPaymentValue.Size = new System.Drawing.Size(181, 28);
            this.minimumMonthlyPaymentValue.TabIndex = 10;
            this.minimumMonthlyPaymentValue.Visible = false;
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 591);
            this.Controls.Add(this.calculationTypeSelector);
            this.Controls.Add(this.calculationTypeValue);
            this.Controls.Add(this.aprLabel);
            this.Controls.Add(this.aprValue);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.totalAmountValue);
            this.Controls.Add(this.loanCalculatorLabel);
            this.Controls.Add(this.calculationsBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Calculator";
            this.calculationsBox.ResumeLayout(false);
            this.calculationsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loanCalculatorLabel;
        private System.Windows.Forms.TextBox totalAmountValue;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.TextBox aprValue;
        private System.Windows.Forms.TextBox calculationTypeValue;
        private System.Windows.Forms.Label minimumMonthlyPaymentLabel;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.TextBox totalInterestPaidValue;
        private System.Windows.Forms.Label totalInterestLabel;
        private System.Windows.Forms.ComboBox calculationTypeSelector;
        private System.Windows.Forms.GroupBox calculationsBox;
        private System.Windows.Forms.TextBox minimumMonthlyPaymentValue;
        private System.Windows.Forms.TextBox totalAmountPaidValue;
        private System.Windows.Forms.Label totalAmountPaidLabel;
    }
}

