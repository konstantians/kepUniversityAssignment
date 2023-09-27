
namespace KEPAssignment
{
    partial class AccountForm
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
            this.accountFormLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.accountRegisteredCitizensLabel = new System.Windows.Forms.Label();
            this.recoveryAnswerLabel = new System.Windows.Forms.Label();
            this.recoveryQuestionLabel = new System.Windows.Forms.Label();
            this.recoveryAnswerEditButton = new KEPAssignment.CustomButton();
            this.recoveryQuestionEditButton = new KEPAssignment.CustomButton();
            this.passwordEditButton = new KEPAssignment.CustomButton();
            this.saveChangesButton = new KEPAssignment.CustomButton();
            this.managerRadioButton = new KEPAssignment.CustomRadioButton();
            this.employeeRadioButton = new KEPAssignment.CustomRadioButton();
            this.accountRegisteredCitizensTextBox = new KEPAssignment.CustomComboBox();
            this.recoveryQuestionComboBox = new KEPAssignment.CustomComboBox();
            this.usernameEditButton = new KEPAssignment.CustomButton();
            this.recoveryAnswerTextBox = new KEPAssignment.CustomTextBox();
            this.passwordTextBox = new KEPAssignment.CustomTextBox();
            this.usernameTextBox = new KEPAssignment.CustomTextBox();
            this.SuspendLayout();
            // 
            // accountFormLabel
            // 
            this.accountFormLabel.AutoSize = true;
            this.accountFormLabel.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountFormLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accountFormLabel.Location = new System.Drawing.Point(290, 11);
            this.accountFormLabel.Name = "accountFormLabel";
            this.accountFormLabel.Size = new System.Drawing.Size(127, 26);
            this.accountFormLabel.TabIndex = 16;
            this.accountFormLabel.Text = "Account Form";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(34, 60);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(157, 23);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Account Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(34, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(154, 23);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Account Password";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(34, 260);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(114, 23);
            this.accountTypeLabel.TabIndex = 35;
            this.accountTypeLabel.Text = "Account Type";
            // 
            // accountRegisteredCitizensLabel
            // 
            this.accountRegisteredCitizensLabel.AutoSize = true;
            this.accountRegisteredCitizensLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountRegisteredCitizensLabel.Location = new System.Drawing.Point(378, 260);
            this.accountRegisteredCitizensLabel.Name = "accountRegisteredCitizensLabel";
            this.accountRegisteredCitizensLabel.Size = new System.Drawing.Size(242, 23);
            this.accountRegisteredCitizensLabel.TabIndex = 43;
            this.accountRegisteredCitizensLabel.Text = "Account\'s Registered Citizens";
            // 
            // recoveryAnswerLabel
            // 
            this.recoveryAnswerLabel.AutoSize = true;
            this.recoveryAnswerLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryAnswerLabel.Location = new System.Drawing.Point(378, 160);
            this.recoveryAnswerLabel.Name = "recoveryAnswerLabel";
            this.recoveryAnswerLabel.Size = new System.Drawing.Size(143, 23);
            this.recoveryAnswerLabel.TabIndex = 44;
            this.recoveryAnswerLabel.Text = "Recovery Answer";
            // 
            // recoveryQuestionLabel
            // 
            this.recoveryQuestionLabel.AutoSize = true;
            this.recoveryQuestionLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryQuestionLabel.Location = new System.Drawing.Point(378, 60);
            this.recoveryQuestionLabel.Name = "recoveryQuestionLabel";
            this.recoveryQuestionLabel.Size = new System.Drawing.Size(155, 23);
            this.recoveryQuestionLabel.TabIndex = 45;
            this.recoveryQuestionLabel.Text = "Recovery Question";
            // 
            // recoveryAnswerEditButton
            // 
            this.recoveryAnswerEditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.recoveryAnswerEditButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.recoveryAnswerEditButton.BackgroundImage = global::KEPAssignment.Properties.Resources.editIcon;
            this.recoveryAnswerEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recoveryAnswerEditButton.BorderColor = System.Drawing.Color.Black;
            this.recoveryAnswerEditButton.BorderRadius = 0;
            this.recoveryAnswerEditButton.BorderSize = 3;
            this.recoveryAnswerEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryAnswerEditButton.FlatAppearance.BorderSize = 0;
            this.recoveryAnswerEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoveryAnswerEditButton.ForeColor = System.Drawing.Color.Black;
            this.recoveryAnswerEditButton.Location = new System.Drawing.Point(638, 200);
            this.recoveryAnswerEditButton.Name = "recoveryAnswerEditButton";
            this.recoveryAnswerEditButton.Size = new System.Drawing.Size(38, 29);
            this.recoveryAnswerEditButton.TabIndex = 48;
            this.recoveryAnswerEditButton.TextColor = System.Drawing.Color.Black;
            this.recoveryAnswerEditButton.UseVisualStyleBackColor = false;
            this.recoveryAnswerEditButton.Click += new System.EventHandler(this.recoveryAnswerEditButton_Click);
            this.recoveryAnswerEditButton.MouseEnter += new System.EventHandler(this.recoveryAnswerEditButton_MouseEnter);
            this.recoveryAnswerEditButton.MouseLeave += new System.EventHandler(this.recoveryAnswerEditButton_MouseLeave);
            // 
            // recoveryQuestionEditButton
            // 
            this.recoveryQuestionEditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionEditButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionEditButton.BackgroundImage = global::KEPAssignment.Properties.Resources.editIcon;
            this.recoveryQuestionEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recoveryQuestionEditButton.BorderColor = System.Drawing.Color.Black;
            this.recoveryQuestionEditButton.BorderRadius = 0;
            this.recoveryQuestionEditButton.BorderSize = 3;
            this.recoveryQuestionEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryQuestionEditButton.FlatAppearance.BorderSize = 0;
            this.recoveryQuestionEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recoveryQuestionEditButton.ForeColor = System.Drawing.Color.Black;
            this.recoveryQuestionEditButton.Location = new System.Drawing.Point(638, 99);
            this.recoveryQuestionEditButton.Name = "recoveryQuestionEditButton";
            this.recoveryQuestionEditButton.Size = new System.Drawing.Size(38, 30);
            this.recoveryQuestionEditButton.TabIndex = 47;
            this.recoveryQuestionEditButton.TextColor = System.Drawing.Color.Black;
            this.recoveryQuestionEditButton.UseVisualStyleBackColor = false;
            this.recoveryQuestionEditButton.Click += new System.EventHandler(this.recoveryQuestionEditButton_Click);
            this.recoveryQuestionEditButton.MouseEnter += new System.EventHandler(this.recoveryQuestionEditButton_MouseEnter);
            this.recoveryQuestionEditButton.MouseLeave += new System.EventHandler(this.recoveryQuestionEditButton_MouseLeave);
            // 
            // passwordEditButton
            // 
            this.passwordEditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.passwordEditButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.passwordEditButton.BackgroundImage = global::KEPAssignment.Properties.Resources.editIcon;
            this.passwordEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.passwordEditButton.BorderColor = System.Drawing.Color.Black;
            this.passwordEditButton.BorderRadius = 0;
            this.passwordEditButton.BorderSize = 3;
            this.passwordEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordEditButton.FlatAppearance.BorderSize = 0;
            this.passwordEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordEditButton.ForeColor = System.Drawing.Color.Black;
            this.passwordEditButton.Location = new System.Drawing.Point(294, 200);
            this.passwordEditButton.Name = "passwordEditButton";
            this.passwordEditButton.Size = new System.Drawing.Size(38, 30);
            this.passwordEditButton.TabIndex = 46;
            this.passwordEditButton.TextColor = System.Drawing.Color.Black;
            this.passwordEditButton.UseVisualStyleBackColor = false;
            this.passwordEditButton.Click += new System.EventHandler(this.passwordEditButton_Click);
            this.passwordEditButton.MouseEnter += new System.EventHandler(this.passwordEditButton_MouseEnter);
            this.passwordEditButton.MouseLeave += new System.EventHandler(this.passwordEditButton_MouseLeave);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveChangesButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.saveChangesButton.BorderColor = System.Drawing.Color.Black;
            this.saveChangesButton.BorderRadius = 15;
            this.saveChangesButton.BorderSize = 3;
            this.saveChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChangesButton.FlatAppearance.BorderSize = 0;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.Color.Black;
            this.saveChangesButton.Location = new System.Drawing.Point(250, 457);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(213, 45);
            this.saveChangesButton.TabIndex = 40;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.TextColor = System.Drawing.Color.Black;
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            this.saveChangesButton.Enter += new System.EventHandler(this.saveChangesButton_Enter);
            this.saveChangesButton.Leave += new System.EventHandler(this.saveChangesButton_Leave);
            this.saveChangesButton.MouseEnter += new System.EventHandler(this.saveChangesButton_MouseEnter);
            this.saveChangesButton.MouseLeave += new System.EventHandler(this.saveChangesButton_MouseLeave);
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.CheckedColor = System.Drawing.Color.RoyalBlue;
            this.managerRadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRadioButton.Location = new System.Drawing.Point(193, 300);
            this.managerRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.managerRadioButton.Size = new System.Drawing.Size(100, 21);
            this.managerRadioButton.TabIndex = 37;
            this.managerRadioButton.TabStop = true;
            this.managerRadioButton.Text = "Manager";
            this.managerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Checked = true;
            this.employeeRadioButton.CheckedColor = System.Drawing.Color.RoyalBlue;
            this.employeeRadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRadioButton.Location = new System.Drawing.Point(41, 301);
            this.employeeRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employeeRadioButton.Size = new System.Drawing.Size(107, 21);
            this.employeeRadioButton.TabIndex = 36;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // accountRegisteredCitizensTextBox
            // 
            this.accountRegisteredCitizensTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.accountRegisteredCitizensTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.accountRegisteredCitizensTextBox.BorderSize = 2;
            this.accountRegisteredCitizensTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.accountRegisteredCitizensTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountRegisteredCitizensTextBox.ForeColor = System.Drawing.Color.Black;
            this.accountRegisteredCitizensTextBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.accountRegisteredCitizensTextBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.accountRegisteredCitizensTextBox.ListTextColor = System.Drawing.Color.Black;
            this.accountRegisteredCitizensTextBox.Location = new System.Drawing.Point(382, 300);
            this.accountRegisteredCitizensTextBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.accountRegisteredCitizensTextBox.Name = "accountRegisteredCitizensTextBox";
            this.accountRegisteredCitizensTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.accountRegisteredCitizensTextBox.Size = new System.Drawing.Size(255, 30);
            this.accountRegisteredCitizensTextBox.TabIndex = 33;
            this.accountRegisteredCitizensTextBox.Texts = "";
            // 
            // recoveryQuestionComboBox
            // 
            this.recoveryQuestionComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.recoveryQuestionComboBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionComboBox.BorderSize = 2;
            this.recoveryQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.recoveryQuestionComboBox.Enabled = false;
            this.recoveryQuestionComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryQuestionComboBox.ForeColor = System.Drawing.Color.Black;
            this.recoveryQuestionComboBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionComboBox.Items.AddRange(new object[] {
            "Who is your best friend?",
            "What is your favourite food?",
            "What is your favourite sport?"});
            this.recoveryQuestionComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.recoveryQuestionComboBox.ListTextColor = System.Drawing.Color.Black;
            this.recoveryQuestionComboBox.Location = new System.Drawing.Point(382, 99);
            this.recoveryQuestionComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.recoveryQuestionComboBox.Name = "recoveryQuestionComboBox";
            this.recoveryQuestionComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.recoveryQuestionComboBox.Size = new System.Drawing.Size(255, 30);
            this.recoveryQuestionComboBox.TabIndex = 32;
            this.recoveryQuestionComboBox.Texts = "";
            this.recoveryQuestionComboBox.Enter += new System.EventHandler(this.recoveryQuestionComboBox_Enter);
            this.recoveryQuestionComboBox.Leave += new System.EventHandler(this.recoveryQuestionComboBox_Leave);
            // 
            // usernameEditButton
            // 
            this.usernameEditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.usernameEditButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.usernameEditButton.BackgroundImage = global::KEPAssignment.Properties.Resources.editIcon;
            this.usernameEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.usernameEditButton.BorderColor = System.Drawing.Color.Black;
            this.usernameEditButton.BorderRadius = 0;
            this.usernameEditButton.BorderSize = 3;
            this.usernameEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameEditButton.FlatAppearance.BorderSize = 0;
            this.usernameEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameEditButton.ForeColor = System.Drawing.Color.Black;
            this.usernameEditButton.Location = new System.Drawing.Point(294, 99);
            this.usernameEditButton.Name = "usernameEditButton";
            this.usernameEditButton.Size = new System.Drawing.Size(38, 30);
            this.usernameEditButton.TabIndex = 28;
            this.usernameEditButton.TextColor = System.Drawing.Color.Black;
            this.usernameEditButton.UseVisualStyleBackColor = false;
            this.usernameEditButton.Click += new System.EventHandler(this.usernameEditButton_Click);
            this.usernameEditButton.MouseEnter += new System.EventHandler(this.usernameEditButton_MouseEnter);
            this.usernameEditButton.MouseLeave += new System.EventHandler(this.usernameEditButton_MouseLeave);
            // 
            // recoveryAnswerTextBox
            // 
            this.recoveryAnswerTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.recoveryAnswerTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.recoveryAnswerTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.recoveryAnswerTextBox.BorderSize = 4;
            this.recoveryAnswerTextBox.Enabled = false;
            this.recoveryAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryAnswerTextBox.ForeColor = System.Drawing.Color.Black;
            this.recoveryAnswerTextBox.Location = new System.Drawing.Point(382, 200);
            this.recoveryAnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.recoveryAnswerTextBox.Multiline = false;
            this.recoveryAnswerTextBox.Name = "recoveryAnswerTextBox";
            this.recoveryAnswerTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.recoveryAnswerTextBox.PasswordChar = false;
            this.recoveryAnswerTextBox.Size = new System.Drawing.Size(255, 29);
            this.recoveryAnswerTextBox.TabIndex = 27;
            this.recoveryAnswerTextBox.Texts = "";
            this.recoveryAnswerTextBox.UnderlinedStyle = true;
            this.recoveryAnswerTextBox.Enter += new System.EventHandler(this.recoveryAnswerTextBox_Enter);
            this.recoveryAnswerTextBox.Leave += new System.EventHandler(this.recoveryAnswerTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 4;
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(38, 200);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.Size = new System.Drawing.Size(255, 29);
            this.passwordTextBox.TabIndex = 26;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.usernameTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderSize = 4;
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.Location = new System.Drawing.Point(38, 100);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.Size = new System.Drawing.Size(255, 29);
            this.usernameTextBox.TabIndex = 18;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 516);
            this.Controls.Add(this.recoveryAnswerEditButton);
            this.Controls.Add(this.recoveryQuestionEditButton);
            this.Controls.Add(this.passwordEditButton);
            this.Controls.Add(this.recoveryQuestionLabel);
            this.Controls.Add(this.recoveryAnswerLabel);
            this.Controls.Add(this.accountRegisteredCitizensLabel);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.managerRadioButton);
            this.Controls.Add(this.employeeRadioButton);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountRegisteredCitizensTextBox);
            this.Controls.Add(this.recoveryQuestionComboBox);
            this.Controls.Add(this.usernameEditButton);
            this.Controls.Add(this.recoveryAnswerTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.accountFormLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountFormLabel;
        private System.Windows.Forms.Label usernameLabel;
        private CustomTextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private CustomTextBox passwordTextBox;
        private CustomTextBox recoveryAnswerTextBox;
        private CustomButton usernameEditButton;
        private CustomComboBox recoveryQuestionComboBox;
        private CustomComboBox accountRegisteredCitizensTextBox;
        private System.Windows.Forms.Label accountTypeLabel;
        private CustomRadioButton employeeRadioButton;
        private CustomRadioButton managerRadioButton;
        private CustomButton saveChangesButton;
        private System.Windows.Forms.Label accountRegisteredCitizensLabel;
        private System.Windows.Forms.Label recoveryAnswerLabel;
        private System.Windows.Forms.Label recoveryQuestionLabel;
        private CustomButton passwordEditButton;
        private CustomButton recoveryQuestionEditButton;
        private CustomButton recoveryAnswerEditButton;
    }
}