namespace LoanUI
{
    partial class CreateProfileForm
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
            this.createProfileLabel = new System.Windows.Forms.Label();
            this.nameProfile = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createProfileLabel
            // 
            this.createProfileLabel.AutoSize = true;
            this.createProfileLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfileLabel.Location = new System.Drawing.Point(152, 25);
            this.createProfileLabel.Name = "createProfileLabel";
            this.createProfileLabel.Size = new System.Drawing.Size(212, 45);
            this.createProfileLabel.TabIndex = 0;
            this.createProfileLabel.Text = "Create Profile";
            // 
            // nameProfile
            // 
            this.nameProfile.AutoSize = true;
            this.nameProfile.Location = new System.Drawing.Point(11, 109);
            this.nameProfile.Name = "nameProfile";
            this.nameProfile.Size = new System.Drawing.Size(74, 30);
            this.nameProfile.TabIndex = 1;
            this.nameProfile.Text = "Name:";
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(16, 142);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(484, 35);
            this.nameValue.TabIndex = 2;
            this.nameValue.MaxLength = 20;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(30, 194);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(218, 79);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create ";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(268, 194);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(218, 79);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 294);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.nameProfile);
            this.Controls.Add(this.createProfileLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateProfileForm";
            this.Text = "CreateProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createProfileLabel;
        private System.Windows.Forms.Label nameProfile;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
    }
}