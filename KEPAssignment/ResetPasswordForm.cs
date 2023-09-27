using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class ResetPasswordForm : Form
    {
        KepEmployee KepEmployee;
        bool closedByX = true;
        public ResetPasswordForm(KepEmployee kepEmployee)
        {
            InitializeComponent();
            KepEmployee = kepEmployee;
            usernameTextBox.BackColor = Color.LightGray;
            usernameTextBox.Texts = KepEmployee.Username;
            recoveryQuestionLabel.Text = KepEmployee.RecoveryQuestion; 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closedByX = false;
            Application.OpenForms[1].Close();
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void ResetPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByX)
            {
                Application.OpenForms[1].Close();
                Application.OpenForms[0].Close();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            int count = 0;
            if (recoveryAnswerTextBox.Texts == "")
            {
                emptyFields.Append(" the recovery answer field");
                count++;
            }
            if (newPasswordTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the new password field");
                }
                else
                {
                    emptyFields.Append(", the new password field");
                }
                count++;
            }
            if (repeatNewPasswordTextBox.Texts == "")
            {
                if (count == 0)
                {
                    emptyFields.Append(" the repeat new password field");
                }
                else
                {
                    emptyFields.Append(" and the repeat new password field");
                }
                count++;
            }

            emptyFields.Append(" and try again.");

            if (count > 0)
            {
                MessageBox.Show(emptyFields.ToString(), "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPasswordTextBox.Texts != repeatNewPasswordTextBox.Texts)
            {
                MessageBox.Show("The new password field and the repeat new password field must match.",
                    "Not Matching Password Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newPasswordTextBox.Texts = "";
                repeatNewPasswordTextBox.Texts = "";
                return;
            }

            if (KepEmployee.RecoveryAnswer != recoveryAnswerTextBox.Texts)
            {
                MessageBox.Show("The given recovery answer does not match the recovery answer of the account."
                    , "Invalid Recovery Answer",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                recoveryAnswerTextBox.Texts = "";
                return;
            }

            KepEmployee.Password = newPasswordTextBox.Texts;
            DataAccessOperations.UpdateKepEmployee(KepEmployee);

            MessageBox.Show("The password of the account was successfully changed."
                    , "Account Password Successfully Changed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            closedByX = false;
            Application.OpenForms[1].Close();
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void recoveryAnswerTextBox_Enter(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.Black;
        }

        private void recoveryAnswerTextBox_Leave(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.RoyalBlue;
        }

        private void newPasswordTextBox_Enter(object sender, EventArgs e)
        {
            newPasswordTextBox.BorderColor = Color.Black;
        }

        private void newPasswordTextBox_Leave(object sender, EventArgs e)
        {
            newPasswordTextBox.BorderColor = Color.RoyalBlue;
        }

        private void repeatNewPasswordTextBox_Enter(object sender, EventArgs e)
        {
            repeatNewPasswordTextBox.BorderColor = Color.Black;
        }

        private void repeatNewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            repeatNewPasswordTextBox.BorderColor = Color.RoyalBlue;
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

        private void confirmButton_Enter(object sender, EventArgs e)
        {
            confirmButton.BackColor = Color.Black;
            confirmButton.TextColor = Color.RoyalBlue;
            confirmButton.BorderColor = Color.RoyalBlue;
        }

        private void confirmButton_Leave(object sender, EventArgs e)
        {
            confirmButton.BackColor = Color.RoyalBlue;
            confirmButton.TextColor = Color.Black;
            confirmButton.BorderColor = Color.Black;
        }

        private void confirmButton_MouseEnter(object sender, EventArgs e)
        {
            confirmButton.BackColor = Color.Black;
            confirmButton.TextColor = Color.RoyalBlue;
            confirmButton.BorderColor = Color.RoyalBlue;
        }

        private void confirmButton_MouseLeave(object sender, EventArgs e)
        {
            confirmButton.BackColor = Color.RoyalBlue;
            confirmButton.TextColor = Color.Black;
            confirmButton.BorderColor = Color.Black;
        }

    }
}
