using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Texts == "" && passwordTextBox.Texts == "")
            {
                MessageBox.Show("All fields must be filled. Please fill the username field and the password field and try again.",
                    "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    
            }
            else if(usernameTextBox.Texts == "")
            {
                MessageBox.Show("All fields must be filled. Please fill the username field and try again.",
                    "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (passwordTextBox.Texts == "")
            {
                MessageBox.Show("All fields must be filled. Please fill the password field and try again.",
                    "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KepEmployee kepEmployee = DataAccessOperations.GetKepEmployee(usernameTextBox.Texts);

            if (kepEmployee.Username == null)
            {
                MessageBox.Show("There is not an account with the given username.",
                    "Account Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Texts = "";
                passwordTextBox.Texts = "";
                employeeRadioButton.Checked = true;
                managerRadioButton.Checked = false;
                this.ActiveControl = usernameTextBox;
                usernameTextBox.Focus();
                return;
            }

            if((kepEmployee.AccountType == "Employee" && managerRadioButton.Checked) 
                || (kepEmployee.AccountType == "Manager" && employeeRadioButton.Checked))
            {
                MessageBox.Show("The password or/and the account type are incorrect. Please try again.",
                    "Invalid Credentionals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Texts = "";
                employeeRadioButton.Checked = true;
                managerRadioButton.Checked = false;
                this.ActiveControl = passwordTextBox;
                passwordTextBox.Focus();
                return;
            }

            if (kepEmployee.Password != passwordTextBox.Texts)
            {
                MessageBox.Show("The password or/and the account type are incorrect. Please try again.",
                    "Invalid Credentionals", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Texts = "";
                employeeRadioButton.Checked = true;
                managerRadioButton.Checked = false;
                this.ActiveControl = passwordTextBox;
                passwordTextBox.Focus();
                return;
            }

            ActiveUser.KepEmployee = kepEmployee;
            MenuForm menuForm = new MenuForm();
            Application.OpenForms[0].Hide();
            this.Enabled = false;
            menuForm.Show();
            
            //reset fields in case of possible log out
            usernameTextBox.Texts = "";
            passwordTextBox.Texts = "";
            employeeRadioButton.Checked = true;
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Black;
            loginButton.TextColor = Color.RoyalBlue;
            loginButton.BorderColor = Color.RoyalBlue;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.RoyalBlue;
            loginButton.TextColor = Color.Black;
            loginButton.BorderColor = Color.Black;
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            usernameTextBox.Texts = "";
            passwordTextBox.Texts = "";
            employeeRadioButton.Checked = true;
            managerRadioButton.Checked = false;
            this.ActiveControl = usernameTextBox;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.BorderColor = Color.Black;
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            usernameTextBox.BorderColor = Color.RoyalBlue;
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.BorderColor = Color.Black;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordTextBox.BorderColor = Color.RoyalBlue;
        }

        private void forgotPasswordLabel_MouseEnter(object sender, EventArgs e)
        {
            forgotPasswordLabel.LinkColor = Color.Black;
        }

        private void forgotPasswordLabel_MouseLeave(object sender, EventArgs e)
        {
            forgotPasswordLabel.LinkColor = Color.RoyalBlue;
        }

        private void forgotPasswordLabel_Enter(object sender, EventArgs e)
        {
            forgotPasswordLabel.LinkColor = Color.Black;
        }

        private void forgotPasswordLabel_Leave(object sender, EventArgs e)
        {
            forgotPasswordLabel.LinkColor = Color.RoyalBlue;
        }

        private void signUpLabel_MouseEnter(object sender, EventArgs e)
        {
            signUpLabel.LinkColor = Color.Black;
        }

        private void signUpLabel_MouseLeave(object sender, EventArgs e)
        {
            signUpLabel.LinkColor = Color.RoyalBlue;
        }

        private void signUpLabel_Enter(object sender, EventArgs e)
        {
            signUpLabel.LinkColor = Color.Black;
        }

        private void signUpLabel_Leave(object sender, EventArgs e)
        {
            signUpLabel.LinkColor = Color.RoyalBlue;
        }

        private void loginButton_Enter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Black;
            loginButton.TextColor = Color.RoyalBlue;
            loginButton.BorderColor = Color.RoyalBlue;
        }

        private void loginButton_Leave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.RoyalBlue;
            loginButton.TextColor = Color.Black;
            loginButton.BorderColor = Color.Black;
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ForgotPasswordMiniFormConfirmation forgotPasswordMiniFormConfirmation = new ForgotPasswordMiniFormConfirmation();
            forgotPasswordMiniFormConfirmation.Show();
        }

        private void LoginForm_EnabledChanged(object sender, EventArgs e)
        {
            this.ActiveControl = usernameTextBox;
        }
    }
}
