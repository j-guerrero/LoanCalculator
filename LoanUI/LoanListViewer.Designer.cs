namespace LoanUI
{
    partial class LoanListViewer
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
            this.loanListBox = new System.Windows.Forms.ListBox();
            this.loanListBoxLabel = new System.Windows.Forms.Label();
            this.calculationTypeValue = new System.Windows.Forms.TextBox();
            this.aprLabel = new System.Windows.Forms.Label();
            this.aprValue = new System.Windows.Forms.TextBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.totalAmountValue = new System.Windows.Forms.TextBox();
            this.termLabel = new System.Windows.Forms.Label();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addLoanButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loanListBox
            // 
            this.loanListBox.FormattingEnabled = true;
            this.loanListBox.ItemHeight = 30;
            this.loanListBox.Location = new System.Drawing.Point(14, 80);
            this.loanListBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loanListBox.Name = "loanListBox";
            this.loanListBox.Size = new System.Drawing.Size(293, 454);
            this.loanListBox.TabIndex = 0;
            // 
            // loanListBoxLabel
            // 
            this.loanListBoxLabel.AutoSize = true;
            this.loanListBoxLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanListBoxLabel.Location = new System.Drawing.Point(3, 8);
            this.loanListBoxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loanListBoxLabel.Name = "loanListBoxLabel";
            this.loanListBoxLabel.Size = new System.Drawing.Size(158, 65);
            this.loanListBoxLabel.TabIndex = 1;
            this.loanListBoxLabel.Text = "Loans";
            // 
            // calculationTypeValue
            // 
            this.calculationTypeValue.Location = new System.Drawing.Point(491, 263);
            this.calculationTypeValue.Name = "calculationTypeValue";
            this.calculationTypeValue.Size = new System.Drawing.Size(181, 35);
            this.calculationTypeValue.TabIndex = 18;
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.Location = new System.Drawing.Point(329, 219);
            this.aprLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(57, 30);
            this.aprLabel.TabIndex = 17;
            this.aprLabel.Text = "APR:";
            // 
            // aprValue
            // 
            this.aprValue.Location = new System.Drawing.Point(491, 216);
            this.aprValue.Name = "aprValue";
            this.aprValue.Size = new System.Drawing.Size(181, 35);
            this.aprValue.TabIndex = 16;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Location = new System.Drawing.Point(329, 173);
            this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(143, 30);
            this.totalAmountLabel.TabIndex = 15;
            this.totalAmountLabel.Text = "Total Amount:";
            // 
            // totalAmountValue
            // 
            this.totalAmountValue.Location = new System.Drawing.Point(491, 170);
            this.totalAmountValue.Name = "totalAmountValue";
            this.totalAmountValue.Size = new System.Drawing.Size(181, 35);
            this.totalAmountValue.TabIndex = 14;
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(329, 263);
            this.termLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(151, 30);
            this.termLabel.TabIndex = 19;
            this.termLabel.Text = "Term (months):";
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameLabel.Location = new System.Drawing.Point(422, 91);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(145, 45);
            this.personNameLabel.TabIndex = 20;
            this.personNameLabel.Text = "<name>";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(211, 44);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 29);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addLoanButton
            // 
            this.addLoanButton.Location = new System.Drawing.Point(336, 307);
            this.addLoanButton.Name = "addLoanButton";
            this.addLoanButton.Size = new System.Drawing.Size(335, 39);
            this.addLoanButton.TabIndex = 22;
            this.addLoanButton.Text = "Add Loan";
            this.addLoanButton.UseVisualStyleBackColor = true;
            this.addLoanButton.Click += new System.EventHandler(this.addLoanButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(336, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(335, 39);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(336, 452);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(335, 39);
            this.returnButton.TabIndex = 24;
            this.returnButton.Text = "Return to Main Menu";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.Location = new System.Drawing.Point(434, 46);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(121, 45);
            this.profileLabel.TabIndex = 25;
            this.profileLabel.Text = "Profile:";
            // 
            // LoanListViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 583);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addLoanButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.personNameLabel);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.calculationTypeValue);
            this.Controls.Add(this.aprLabel);
            this.Controls.Add(this.aprValue);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.totalAmountValue);
            this.Controls.Add(this.loanListBoxLabel);
            this.Controls.Add(this.loanListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoanListViewer";
            this.Text = "Loan Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox loanListBox;
        private System.Windows.Forms.Label loanListBoxLabel;
        private System.Windows.Forms.TextBox calculationTypeValue;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.TextBox aprValue;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.TextBox totalAmountValue;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addLoanButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label profileLabel;
    }
}