using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class RegisterForm : Form
    {
        bool closedByX = true;
        public RegisterForm()
        {
            InitializeComponent();
            recoveryQuestionComboBox.SelectedIndex = 0;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            int count = 0;
            if(usernameTextBox.Texts == "")
            {
                emptyFields.Append(" the username field");
                count++;
            }
            if(passwordTextBox.Texts == "")
            {
                if(count == 0)
                {
                    emptyFields.Append(" the password field");
                }
                else
                {
                    emptyFields.Append(", the password field");
                }
                count++;
            }
            if(repeatPasswordTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the repeat password field");
                }
                else
                {
                    emptyFields.Append(", the repeat password field");
                }
                count++;
            }
            if(recoveryAnswerTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the recovery answer field");

                }
                else
                {
                    emptyFields.Append(" and the recovery answer field");
                }
                count++;
            }
            emptyFields.Append(" and try again.");

            if(count > 0)
            {
                MessageBox.Show(emptyFields.ToString(), "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(passwordTextBox.Texts != repeatPasswordTextBox.Texts)
            {
                MessageBox.Show("The password field and the repeat password field must match",
                    "Not Matching Password Fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
                passwordTextBox.Texts = "";
                repeatPasswordTextBox.Texts = "";
                return;
            }

            if (DataAccessOperations.GetKepEmployee(usernameTextBox.Texts).Username != null) {
                MessageBox.Show("There is another account with the same username, please try a different username",
                    "Duplicate Account", MessageBoxButtons.OK,MessageBoxIcon.Error);
                usernameTextBox.Texts = "";
                return;
            }

            KepEmployee kepEmployee = new KepEmployee();
            kepEmployee.Username = usernameTextBox.Texts;
            kepEmployee.Password = passwordTextBox.Texts;
            kepEmployee.RecoveryQuestion = recoveryQuestionComboBox.Texts;
            kepEmployee.RecoveryAnswer = recoveryAnswerTextBox.Texts;
            kepEmployee.AccountType = employeeRadioButton.Checked ? "Employee" : "Manager";

            DataAccessOperations.CreateKepEmployee(kepEmployee);
            MessageBox.Show("Your account was successfully created!", "Account Successfully Created",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

            closedByX = false;
            this.Close();
            Application.OpenForms[0].Show();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closedByX = false;
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByX)
            {
                Application.Exit();
            }
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

        private void repeatPasswordTextBox_Enter(object sender, EventArgs e)
        {
            repeatPasswordTextBox.BorderColor = Color.Black;
        }

        private void repeatPasswordTextBox_Leave(object sender, EventArgs e)
        {
            repeatPasswordTextBox.BorderColor = Color.RoyalBlue;
        }

        private void recoveryAnswerTextBox_Enter(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.Black;
        }

        private void recoveryAnswerTextBox_Leave(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.RoyalBlue;
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.Black;
            cancelButton.TextColor = Color.RoyalBlue;
            cancelButton.BorderColor = Color.RoyalBlue;
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.RoyalBlue;
            cancelButton.TextColor = Color.Black;
            cancelButton.BorderColor = Color.Black;
        }

        private void signUpButton_MouseEnter(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.Black;
            signUpButton.TextColor = Color.RoyalBlue;
            signUpButton.BorderColor = Color.RoyalBlue;
        }

        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.RoyalBlue;
            signUpButton.TextColor = Color.Black;
            signUpButton.BorderColor = Color.Black;
        }

        private void cancelButton_Enter(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.Black;
            cancelButton.TextColor = Color.RoyalBlue;
            cancelButton.BorderColor = Color.RoyalBlue;
        }

        private void cancelButton_Leave(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.RoyalBlue;
            cancelButton.TextColor = Color.Black;
            cancelButton.BorderColor = Color.Black;
        }

        private void signUpButton_Enter(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.Black;
            signUpButton.TextColor = Color.RoyalBlue;
            signUpButton.BorderColor = Color.RoyalBlue;
        }

        private void signUpButton_Leave(object sender, EventArgs e)
        {
            signUpButton.BackColor = Color.RoyalBlue;
            signUpButton.TextColor = Color.Black;
            signUpButton.BorderColor = Color.Black;
        }

        private void recoveryQuestionComboBox_Enter(object sender, EventArgs e)
        {
            recoveryQuestionComboBox.BorderColor = Color.Black;
            recoveryQuestionComboBox.IconColor = Color.Black;
        }

        private void recoveryQuestionComboBox_Leave(object sender, EventArgs e)
        {
            recoveryQuestionComboBox.BorderColor = Color.RoyalBlue;
            recoveryQuestionComboBox.IconColor = Color.RoyalBlue;
        }
    }
}
