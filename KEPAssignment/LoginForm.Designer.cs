
namespace KEPAssignment
{
    partial class LoginForm
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
            this.forgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.signUpLabel = new System.Windows.Forms.LinkLabel();
            this.notAMemberLabel = new System.Windows.Forms.Label();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.managerRadioButton = new KEPAssignment.CustomRadioButton();
            this.employeeRadioButton = new KEPAssignment.CustomRadioButton();
            this.loginButton = new KEPAssignment.CustomButton();
            this.passwordTextBox = new KEPAssignment.CustomTextBox();
            this.usernameTextBox = new KEPAssignment.CustomTextBox();
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
            this.topPanel.Size = new System.Drawing.Size(411, 110);
            this.topPanel.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::KEPAssignment.Properties.Resources.Gov_gr_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(144, 5);
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
            this.usernameLabel.Location = new System.Drawing.Point(50, 133);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 23);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(50, 229);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 23);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPasswordLabel.LinkColor = System.Drawing.Color.RoyalBlue;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(51, 400);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(141, 17);
            this.forgotPasswordLabel.TabIndex = 4;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Forgot Password?";
            this.forgotPasswordLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            this.forgotPasswordLabel.Enter += new System.EventHandler(this.forgotPasswordLabel_Enter);
            this.forgotPasswordLabel.Leave += new System.EventHandler(this.forgotPasswordLabel_Leave);
            this.forgotPasswordLabel.MouseEnter += new System.EventHandler(this.forgotPasswordLabel_MouseEnter);
            this.forgotPasswordLabel.MouseLeave += new System.EventHandler(this.forgotPasswordLabel_MouseLeave);
            // 
            // signUpLabel
            // 
            this.signUpLabel.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.signUpLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signUpLabel.LinkColor = System.Drawing.Color.RoyalBlue;
            this.signUpLabel.Location = new System.Drawing.Point(228, 505);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(60, 17);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.TabStop = true;
            this.signUpLabel.Text = "SignUp";
            this.signUpLabel.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.signUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLabel_LinkClicked);
            this.signUpLabel.Enter += new System.EventHandler(this.signUpLabel_Enter);
            this.signUpLabel.Leave += new System.EventHandler(this.signUpLabel_Leave);
            this.signUpLabel.MouseEnter += new System.EventHandler(this.signUpLabel_MouseEnter);
            this.signUpLabel.MouseLeave += new System.EventHandler(this.signUpLabel_MouseLeave);
            // 
            // notAMemberLabel
            // 
            this.notAMemberLabel.AutoSize = true;
            this.notAMemberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAMemberLabel.Location = new System.Drawing.Point(109, 505);
            this.notAMemberLabel.Name = "notAMemberLabel";
            this.notAMemberLabel.Size = new System.Drawing.Size(120, 17);
            this.notAMemberLabel.TabIndex = 18;
            this.notAMemberLabel.Text = "Not A Member?";
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.AutoSize = true;
            this.AccountTypeLabel.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeLabel.Location = new System.Drawing.Point(50, 324);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(114, 23);
            this.AccountTypeLabel.TabIndex = 19;
            this.AccountTypeLabel.Text = "Account Type";
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.CheckedColor = System.Drawing.Color.RoyalBlue;
            this.managerRadioButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRadioButton.Location = new System.Drawing.Point(211, 362);
            this.managerRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.managerRadioButton.Size = new System.Drawing.Size(100, 21);
            this.managerRadioButton.TabIndex = 3;
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
            this.employeeRadioButton.Location = new System.Drawing.Point(54, 362);
            this.employeeRadioButton.MinimumSize = new System.Drawing.Size(0, 20);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.employeeRadioButton.Size = new System.Drawing.Size(107, 21);
            this.employeeRadioButton.TabIndex = 3;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.UnCheckedColor = System.Drawing.Color.Gray;
            this.employeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.BorderRadius = 15;
            this.loginButton.BorderSize = 3;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(98, 445);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(213, 45);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.TextColor = System.Drawing.Color.Black;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.Enter += new System.EventHandler(this.loginButton_Enter);
            this.loginButton.Leave += new System.EventHandler(this.loginButton_Leave);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 4;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(54, 266);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.Size = new System.Drawing.Size(302, 29);
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
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderSize = 4;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.Location = new System.Drawing.Point(54, 171);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.Size = new System.Drawing.Size(302, 29);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
            this.usernameTextBox.Enter += new System.EventHandler(this.usernameTextBox_Enter);
            this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 551);
            this.Controls.Add(this.managerRadioButton);
            this.Controls.Add(this.employeeRadioButton);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.notAMemberLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.topPanel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.EnabledChanged += new System.EventHandler(this.LoginForm_EnabledChanged);
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
        private System.Windows.Forms.LinkLabel forgotPasswordLabel;
        private CustomButton loginButton;
        private System.Windows.Forms.LinkLabel signUpLabel;
        private System.Windows.Forms.Label notAMemberLabel;
        private System.Windows.Forms.Label AccountTypeLabel;
        private CustomRadioButton employeeRadioButton;
        private CustomRadioButton managerRadioButton;
    }
}