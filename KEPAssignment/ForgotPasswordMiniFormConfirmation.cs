using DataAccess;
using DataAccess.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class ForgotPasswordMiniFormConfirmation : Form
    {
        public ForgotPasswordMiniFormConfirmation()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Enabled = true;
        }

        private void ForgotPasswordMiniFormConfirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            KepEmployee kepEmployee = DataAccessOperations.GetKepEmployee(enterUsernameTextBox.Texts);

            if (kepEmployee.Username == null)
            {
                MessageBox.Show("There is not an account with the given username.",
                    "Account Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                enterUsernameTextBox.Texts = "";
                return;
            }

            ResetPasswordForm resetPasswordForm = new ResetPasswordForm(kepEmployee);
            Application.OpenForms[0].Hide();
            this.Hide();
            resetPasswordForm.Show();
        }

        private void enterUsernameTextBox_Enter(object sender, EventArgs e)
        {
            enterUsernameTextBox.BorderColor = Color.Black;
        }

        private void enterUsernameTextBox_Leave(object sender, EventArgs e)
        {
            enterUsernameTextBox.BorderColor = Color.RoyalBlue;
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
