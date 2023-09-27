
namespace KEPAssignment
{
    partial class RegisterForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.recoveryAnswerLabel = new System.Windows.Forms.Label();
            this.recoveryQuestionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new KEPAssignment.CustomButton();
            this.signUpButton = new KEPAssignment.CustomButton();
            this.recoveryAnswerTextBox = new KEPAssignment.CustomTextBox();
            this.repeatPasswordTextBox = new KEPAssignment.CustomTextBox();
            this.passwordTextBox = new KEPAssignment.CustomTextBox();
            this.usernameTextBox = new KEPAssignment.CustomTextBox();
            this.recoveryQuestionComboBox = new KEPAssignment.CustomComboBox();
            this.managerRadioButton = new KEPAssignment.CustomRadioButton();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.employeeRadioButton = new KEPAssignment.CustomRadioButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.logoPictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(439, 110);
            this.topPanel.TabIndex = 3;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::KEPAssignment.Properties.Resources.Gov_gr_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(158, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(120, 98);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(60, 130);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 23);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Enter Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(60, 230);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(132, 23);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Enter Password";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLabel.Location = new System.Drawing.Point(60, 330);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(147, 23);
            this.repeatPasswordLabel.TabIndex = 12;
            this.repeatPasswordLabel.Text = "Repeat Password";
            // 
            // recoveryAnswerLabel
            // 
            this.recoveryAnswerLabel.AutoSize = true;
            this.recoveryAnswerLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryAnswerLabel.Location = new System.Drawing.Point(60, 620);
            this.recoveryAnswerLabel.Name = "recoveryAnswerLabel";
            this.recoveryAnswerLabel.Size = new System.Drawing.Size(143, 23);
            this.recoveryAnswerLabel.TabIndex = 15;
            this.recoveryAnswerLabel.Text = "Recovery Answer";
            // 
            // recoveryQuestionLabel
            // 
            this.recoveryQuestionLabel.AutoSize = true;
            this.recoveryQuestionLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryQuestionLabel.Location = new System.Drawing.Point(60, 520);
            this.recoveryQuestionLabel.Name = "recoveryQuestionLabel";
            this.recoveryQuestionLabel.Size = new System.Drawing.Size(155, 23);
            this.recoveryQuestionLabel.TabIndex = 16;
            this.recoveryQuestionLabel.Text = "Recovery Question";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.BorderRadius = 15;
            this.cancelButton.BorderSize = 3;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(64, 715);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 45);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.Black;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.Enter += new System.EventHandler(this.cancelButton_Enter);
            this.cancelButton.Leave += new System.EventHandler(this.cancelButton_Leave);
            this.cancelButton.MouseEnter += new System.EventHandler(this.cancelButton_MouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelButton_MouseLeave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.signUpButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.signUpButton.BorderColor = System.Drawing.Color.Black;
            this.signUpButton.BorderRadius = 15;
            this.signUpButton.BorderSize = 3;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.Black;
            this.signUpButton.Location = new System.Drawing.Point(238, 715);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(135, 45);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.TextColor = System.Drawing.Color.Black;
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            this.signUpButton.Enter += new System.EventHandler(this.signUpButton_Enter);
            this.signUpButton.Leave += new System.EventHandler(this.signUpButton_Leave);
            this.signUpButton.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            this.signUpButton.MouseLeave += new System.EventHandler(this.signUpButton_MouseLeave);
            // 
            // recoveryAnswerTextBox
            // 
            this.recoveryAnswerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.recoveryAnswerTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.recoveryAnswerTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.recoveryAnswerTextBox.BorderSize = 4;
            this.recoveryAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryAnswerTextBox.ForeColor = System.Drawing.Color.Black;
            this.recoveryAnswerTextBox.Location = new System.Drawing.Point(64, 660);
            this.recoveryAnswerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.recoveryAnswerTextBox.Multiline = false;
            this.recoveryAnswerTextBox.Name = "recoveryAnswerTextBox";
            this.recoveryAnswerTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.recoveryAnswerTextBox.PasswordChar = false;
            this.recoveryAnswerTextBox.Size = new System.Drawing.Size(310, 29);
            this.recoveryAnswerTextBox.TabIndex = 6;
            this.recoveryAnswerTextBox.Texts = "";
            this.recoveryAnswerTextBox.UnderlinedStyle = true;
            this.recoveryAnswerTextBox.Enter += new System.EventHandler(this.recoveryAnswerTextBox_Enter);
            this.recoveryAnswerTextBox.Leave += new System.EventHandler(this.recoveryAnswerTextBox_Leave);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.repeatPasswordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.repeatPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.repeatPasswordTextBox.BorderSize = 4;
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(64, 370);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repeatPasswordTextBox.Multiline = false;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.repeatPasswordTextBox.PasswordChar = true;
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(310, 29);
            this.repeatPasswordTextBox.TabIndex = 3;
            this.repeatPasswordTextBox.Texts = "";
            this.repeatPasswordTextBox.UnderlinedStyle = true;
            this.repeatPasswordTextBox.Enter += new System.EventHandler(this.repeatPasswordTextBox_Enter);
            this.repeatPasswordTextBox.Leave += new System.EventHandler(this.repeatPasswordTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 4;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(64, 270);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.Size = new System.Drawing.Size(310, 29);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.usernameTextBox.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernameTextBox.BorderSize = 4;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.Location = new System.Drawing.Point(64, 170);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.Size = new System.Drawing.Size(311, 29);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // recoveryQuestionComboBox
            // 
            this.recoveryQuestionComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.recoveryQuestionComboBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionComboBox.BorderSize = 2;
            this.recoveryQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.recoveryQuestionComboBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryQuestionComboBox.ForeColor = System.Drawing.Color.Black;
            this.recoveryQuestionComboBox.IconColor = System.Drawing.Color.RoyalBlue;
            this.recoveryQuestionComboBox.Items.AddRange(new object[] {
            "Who is your best friend?",
            "What is your favourite food?",
            "What is your favourite sport?"});
            this.recoveryQuestionComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.recoveryQuestionComboBox.ListTextColor = System.Drawing.Color.Black;
            this.recoveryQuestionComboBox.Location = new System.Drawing.Point(64, 560);
            this.recoveryQuestionComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.recoveryQuestionComboBox.Name = "recoveryQuestionComboBox";
            this.recoveryQuestionComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.recoveryQuestionComboBox.Size = new System.Drawing.Size(309, 30);
            this.recoveryQuestionComboBox.TabIndex = 5;
            this.recoveryQuestionComboBox.Texts = "";
            this.recoveryQuestionComboBox.Enter += new System.EventHandler(this.recoveryQuestionComboBox_Enter);
            this.recoveryQuestionComboBox.Leave += new System.EventHandler(this.recoveryQuestionComboBox_Leave);
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.CheckedColor = System.Drawing.Color.RoyalBlue;
            this.managerRadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRadioButton.Location = new System.Drawing.Point(220, 470);
            this.managerRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.managerRadioButton.Size = new System.Drawing.Size(100, 21);
            this.managerRadioButton.TabIndex = 4;
            this.managerRadioButton.TabStop = true;
            this.managerRadioButton.Text = "Manager";
            this.managerRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLabel.Location = new System.Drawing.Point(60, 430);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(114, 23);
            this.AccountTypeLabel.TabIndex = 18;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Checked = true;
            this.employeeRadioButton.CheckedColor = System.Drawing.Color.RoyalBlue;
            this.employeeRadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRadioButton.Location = new System.Drawing.Point(64, 470);
            this.employeeRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employeeRadioButton.Size = new System.Drawing.Size(107, 21);
            this.employeeRadioButton.TabIndex = 4;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 780);
            this.Controls.Add(this.employeeRadioButton);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.managerRadioButton);
            this.Controls.Add(this.recoveryQuestionComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.recoveryQuestionLabel);
            this.Controls.Add(this.recoveryAnswerLabel);
            this.Controls.Add(this.recoveryAnswerTextBox);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.topPanel);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private CustomTextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private CustomTextBox passwordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private CustomTextBox repeatPasswordTextBox;
        private CustomTextBox recoveryAnswerTextBox;
        private System.Windows.Forms.Label recoveryAnswerLabel;
        private System.Windows.Forms.Label recoveryQuestionLabel;
        private CustomButton signUpButton;
        private CustomButton cancelButton;
        private CustomComboBox recoveryQuestionComboBox;
        private CustomRadioButton managerRadioButton;
        private System.Windows.Forms.Label AccountTypeLabel;
        private CustomRadioButton employeeRadioButton;
    }
}