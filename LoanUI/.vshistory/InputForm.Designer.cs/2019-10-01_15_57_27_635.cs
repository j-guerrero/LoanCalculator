﻿namespace LoanUI
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
            this.generateReportButton = new System.Windows.Forms.Button();
            this.aprValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthsValue = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.minimumMonthlyPaymentLabel = new System.Windows.Forms.Label();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.minimumMonthlyPaymentValue = new System.Windows.Forms.TextBox();
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
            this.totalAmountLabel.Location = new System.Drawing.Point(15, 105);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.totalAmountLabel.TabIndex = 2;
            this.totalAmountLabel.Text = "Total Amount:";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(57, 360);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(250, 52);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // aprValue
            // 
            this.aprValue.AutoSize = true;
            this.aprValue.Location = new System.Drawing.Point(15, 151);
            this.aprValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aprValue.Name = "aprValue";
            this.aprValue.Size = new System.Drawing.Size(57, 30);
            this.aprValue.TabIndex = 6;
            this.aprValue.Text = "APR:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 35);
            this.textBox1.TabIndex = 5;
            // 
            // monthsValue
            // 
            this.monthsValue.AutoSize = true;
            this.monthsValue.Location = new System.Drawing.Point(15, 197);
            this.monthsValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthsValue.Name = "monthsValue";
            this.monthsValue.Size = new System.Drawing.Size(89, 30);
            this.monthsValue.TabIndex = 8;
            this.monthsValue.Text = "Months:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 35);
            this.textBox2.TabIndex = 7;
            // 
            // minimumMonthlyPaymentLabel
            // 
            this.minimumMonthlyPaymentLabel.AutoSize = true;
            this.minimumMonthlyPaymentLabel.Location = new System.Drawing.Point(15, 256);
            this.minimumMonthlyPaymentLabel.Name = "minimumMonthlyPaymentLabel";
            this.minimumMonthlyPaymentLabel.Size = new System.Drawing.Size(108, 90);
            this.minimumMonthlyPaymentLabel.TabIndex = 9;
            this.minimumMonthlyPaymentLabel.Text = "Minimum \r\nMonthly\r\nPayment";
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(57, 418);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(250, 52);
            this.clearFormButton.TabIndex = 4;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // minimumMonthlyPaymentValue
            // 
            this.minimumMonthlyPaymentValue.BackColor = System.Drawing.Color.PaleGreen;
            this.minimumMonthlyPaymentValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minimumMonthlyPaymentValue.Location = new System.Drawing.Point(167, 281);
            this.minimumMonthlyPaymentValue.Name = "minimumMonthlyPaymentValue";
            this.minimumMonthlyPaymentValue.ReadOnly = true;
            this.minimumMonthlyPaymentValue.Size = new System.Drawing.Size(181, 28);
            this.minimumMonthlyPaymentValue.TabIndex = 10;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 486);
            this.Controls.Add(this.minimumMonthlyPaymentValue);
            this.Controls.Add(this.minimumMonthlyPaymentLabel);
            this.Controls.Add(this.monthsValue);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.aprValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.generateReportButton);
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
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label aprValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label monthsValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label minimumMonthlyPaymentLabel;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.TextBox minimumMonthlyPaymentValue;
    }
}

