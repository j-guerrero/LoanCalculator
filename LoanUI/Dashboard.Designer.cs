namespace LoanUI
{
    partial class Dashboard
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
            this.loadProfileSelector = new System.Windows.Forms.ComboBox();
            this.loadProfileButton = new System.Windows.Forms.Button();
            this.simpleCalculatorButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.importDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadProfileSelector
            // 
            this.loadProfileSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadProfileSelector.FormattingEnabled = true;
            this.loadProfileSelector.Location = new System.Drawing.Point(143, 118);
            this.loadProfileSelector.Name = "loadProfileSelector";
            this.loadProfileSelector.Size = new System.Drawing.Size(279, 38);
            this.loadProfileSelector.TabIndex = 0;
            // 
            // loadProfileButton
            // 
            this.loadProfileButton.Location = new System.Drawing.Point(143, 162);
            this.loadProfileButton.Name = "loadProfileButton";
            this.loadProfileButton.Size = new System.Drawing.Size(278, 37);
            this.loadProfileButton.TabIndex = 1;
            this.loadProfileButton.Text = "Load Profile";
            this.loadProfileButton.UseVisualStyleBackColor = true;
            this.loadProfileButton.Click += new System.EventHandler(this.loadProfileButton_Click);
            // 
            // simpleCalculatorButton
            // 
            this.simpleCalculatorButton.Location = new System.Drawing.Point(143, 283);
            this.simpleCalculatorButton.Name = "simpleCalculatorButton";
            this.simpleCalculatorButton.Size = new System.Drawing.Size(278, 49);
            this.simpleCalculatorButton.TabIndex = 2;
            this.simpleCalculatorButton.Text = "Simple Calculator";
            this.simpleCalculatorButton.UseVisualStyleBackColor = true;
            this.simpleCalculatorButton.Click += new System.EventHandler(this.simpleCalculatorButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Teal;
            this.welcomeLabel.Location = new System.Drawing.Point(33, 39);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(496, 65);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Loan Tracking Utility";
            // 
            // createProfileButton
            // 
            this.createProfileButton.Location = new System.Drawing.Point(143, 205);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(278, 37);
            this.createProfileButton.TabIndex = 4;
            this.createProfileButton.Text = "CreateProfile";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // importDataButton
            // 
            this.importDataButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importDataButton.Location = new System.Drawing.Point(69, 118);
            this.importDataButton.Name = "importDataButton";
            this.importDataButton.Size = new System.Drawing.Size(68, 38);
            this.importDataButton.TabIndex = 5;
            this.importDataButton.Text = "Import Data";
            this.importDataButton.UseVisualStyleBackColor = true;
            this.importDataButton.Click += new System.EventHandler(this.importDataButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 370);
            this.Controls.Add(this.importDataButton);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.simpleCalculatorButton);
            this.Controls.Add(this.loadProfileButton);
            this.Controls.Add(this.loadProfileSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox loadProfileSelector;
        private System.Windows.Forms.Button loadProfileButton;
        private System.Windows.Forms.Button simpleCalculatorButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.Button importDataButton;
    }
}