using DataAccess;
using DataAccess.Models;
using KEPAssignment.Properties;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            RefreshOrInitializeAccountForm();
        }

        private void checkForChanges()
        {
            bool accountTypeChanged = false;
            if ((ActiveUser.KepEmployee.AccountType == "Employee" && !employeeRadioButton.Checked) ||
                (ActiveUser.KepEmployee.AccountType == "Manager" && !managerRadioButton.Checked))
                accountTypeChanged = true;

            if (ActiveUser.KepEmployee.Username != usernameTextBox.Texts ||
                ActiveUser.KepEmployee.Password != passwordTextBox.Texts ||
                accountTypeChanged || ActiveUser.KepEmployee.RecoveryQuestion != recoveryQuestionComboBox.Texts ||
                ActiveUser.KepEmployee.RecoveryAnswer != recoveryAnswerTextBox.Texts)
            {
                StaticData.UnsavedChanges = true;
            }
            else
            {
                StaticData.UnsavedChanges = false;
            }
        }

        public void RefreshOrInitializeAccountForm()
        {
            usernameTextBox.Texts = ActiveUser.KepEmployee.Username;
            passwordTextBox.Texts = ActiveUser.KepEmployee.Password;
            if (ActiveUser.KepEmployee.AccountType == "Employee")
                employeeRadioButton.Checked = true;
            else
                employeeRadioButton.Checked = false;

            if (ActiveUser.KepEmployee.RecoveryQuestion == "Who is your best friend?")
                recoveryQuestionComboBox.SelectedIndex = 0;
            else if (ActiveUser.KepEmployee.RecoveryQuestion == "What is your favourite food")
                recoveryQuestionComboBox.SelectedIndex = 1;
            else if (ActiveUser.KepEmployee.RecoveryQuestion == "What is your favourite sport?")
                recoveryQuestionComboBox.SelectedIndex = 2;

            recoveryAnswerTextBox.Texts = ActiveUser.KepEmployee.RecoveryAnswer;

            disableUsernameButtonSettings();
            disablePasswordButtonSettings();
            disableRecoveryQuestionButtonSettings();
            disableRecoveryAnswerButtonSettings();
            accountRegisteredCitizensTextBox.Items.Clear();

            if (ActiveUser.KepEmployee.RegisteredCitizens == null)
            {
                accountRegisteredCitizensTextBox.Items.Add($"You have not registered any citizens");
                accountRegisteredCitizensTextBox.SelectedIndex = 0;
                return;
            }

            //otherwise ..
            foreach (Citizen item in ActiveUser.KepEmployee.RegisteredCitizens)
            {
                accountRegisteredCitizensTextBox.Items.Add($"AFM: {item.AFM}");
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            int count = 0;
            if (usernameTextBox.Texts == "")
            {
                emptyFields.Append(" the username field");
                count++;
            }
            if (passwordTextBox.Texts == "")
            {
                if (count == 0)
                    emptyFields.Append(" the password field");
                else
                    emptyFields.Append(", the password field");
                count++;
            }
            if (recoveryAnswerTextBox.Texts == "")
            {
                if (count == 0)
                    emptyFields.Append(" the recovery answer field");
                else
                    emptyFields.Append(" and the recovery answer field");
                count++;
            }
            emptyFields.Append(" and try again.");

            if (count > 0)
            {
                MessageBox.Show(emptyFields.ToString(), "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usernameTextBox.Texts != ActiveUser.KepEmployee.Username && DataAccessOperations.GetKepEmployee(usernameTextBox.Texts).Username != null)
            {
                MessageBox.Show("There is another account with the same username, please try a different username",
                    "Duplicate Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTextBox.Texts = "";
                return;
            }

            KepEmployee kepEmployee = new KepEmployee();
            kepEmployee.Username = ActiveUser.KepEmployee.Username;
            kepEmployee.Password = passwordTextBox.Texts;
            kepEmployee.RecoveryQuestion = recoveryQuestionComboBox.Texts;
            kepEmployee.RecoveryAnswer = recoveryAnswerTextBox.Texts;
            kepEmployee.AccountType = employeeRadioButton.Checked ? "Employee" : "Manager";

            DataAccessOperations.UpdateKepEmployeeAndUsername(kepEmployee, usernameTextBox.Texts);
            ActiveUser.KepEmployee = kepEmployee;
            ActiveUser.KepEmployee.Username = usernameTextBox.Texts;
            ActiveUser.KepEmployee.RegisteredCitizens = DataAccessOperations.ReturnCitizensOfEmployee(usernameTextBox.Texts);
            MessageBox.Show("Your account was successfully updated!", "Account Successfully Updated",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshOrInitializeAccountForm();
            StaticData.UnsavedChanges = false;

            //go back to the home form
            StaticData.OpenHomeForm = true;
        }

        private void saveChangesButton_Enter(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.Black;
            saveChangesButton.TextColor = Color.RoyalBlue;
            saveChangesButton.BorderColor = Color.RoyalBlue;
        }

        private void saveChangesButton_Leave(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.RoyalBlue;
            saveChangesButton.TextColor = Color.Black;
            saveChangesButton.BorderColor = Color.Black;
        }

        private void saveChangesButton_MouseEnter(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.Black;
            saveChangesButton.TextColor = Color.RoyalBlue;
            saveChangesButton.BorderColor = Color.RoyalBlue;
        }

        private void saveChangesButton_MouseLeave(object sender, EventArgs e)
        {
            saveChangesButton.BackColor = Color.RoyalBlue;
            saveChangesButton.TextColor = Color.Black;
            saveChangesButton.BorderColor = Color.Black;
        }

        private void usernameEditButton_Click(object sender, EventArgs e)
        {
            if (!usernameTextBox.Enabled)
            {
                usernameTextBox.Enabled = true;
                usernameTextBox.BackColor = Color.White;
                usernameEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            disableUsernameButtonSettings();
        }

        private void disableUsernameButtonSettings()
        {
            usernameTextBox.Enabled = false;
            usernameTextBox.BackColor = SystemColors.Control;
            usernameEditButton.BackgroundImage = Resources.editIcon;
        }

        private void passwordEditButton_Click(object sender, EventArgs e)
        {
            if (!passwordTextBox.Enabled)
            {
                passwordTextBox.Enabled = true;
                passwordTextBox.BackColor = Color.White;
                passwordEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            disablePasswordButtonSettings();
        }

        private void disablePasswordButtonSettings()
        {
            passwordTextBox.Enabled = false;
            passwordTextBox.BackColor = SystemColors.Control;
            passwordEditButton.BackgroundImage = Resources.editIcon;
        }

        private void recoveryQuestionEditButton_Click(object sender, EventArgs e)
        {
            if (!recoveryQuestionComboBox.Enabled)
            {
                recoveryQuestionComboBox.Enabled = true;
                recoveryQuestionComboBox.BackColor = Color.White;
                recoveryQuestionEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            disableRecoveryQuestionButtonSettings();
        }

        private void disableRecoveryQuestionButtonSettings()
        {
            recoveryQuestionComboBox.Enabled = false;
            recoveryQuestionComboBox.BackColor = SystemColors.Control;
            recoveryQuestionEditButton.BackgroundImage = Resources.editIcon;
        }

        private void recoveryAnswerEditButton_Click(object sender, EventArgs e)
        {
            if (!recoveryAnswerTextBox.Enabled)
            {
                recoveryAnswerTextBox.Enabled = true;
                recoveryAnswerTextBox.BackColor = Color.White;
                recoveryAnswerEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            disableRecoveryAnswerButtonSettings();
        }

        private void disableRecoveryAnswerButtonSettings()
        {
            recoveryAnswerTextBox.Enabled = false;
            recoveryAnswerTextBox.BackColor = SystemColors.Control;
            recoveryAnswerEditButton.BackgroundImage = Resources.editIcon;
        }

        private void usernameEditButton_MouseEnter(object sender, EventArgs e)
        {
            usernameEditButton.BackColor = Color.White;
        }

        private void usernameEditButton_MouseLeave(object sender, EventArgs e)
        {
            usernameEditButton.BackColor = Color.RoyalBlue;
        }

        private void passwordEditButton_MouseEnter(object sender, EventArgs e)
        {
            passwordEditButton.BackColor = Color.White;
        }

        private void passwordEditButton_MouseLeave(object sender, EventArgs e)
        {
            passwordEditButton.BackColor = Color.RoyalBlue;
        }

        private void recoveryQuestionEditButton_MouseEnter(object sender, EventArgs e)
        {
            recoveryQuestionEditButton.BackColor = Color.White;
        }

        private void recoveryQuestionEditButton_MouseLeave(object sender, EventArgs e)
        {
            recoveryQuestionEditButton.BackColor = Color.RoyalBlue;
        }

        private void recoveryAnswerEditButton_MouseEnter(object sender, EventArgs e)
        {
            recoveryAnswerEditButton.BackColor = Color.White;
        }

        private void recoveryAnswerEditButton_MouseLeave(object sender, EventArgs e)
        {
            recoveryAnswerEditButton.BackColor = Color.RoyalBlue;
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.BorderColor = Color.Black;
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            usernameTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            passwordTextBox.BorderColor = Color.Black;
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            passwordTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void recoveryQuestionComboBox_Enter(object sender, EventArgs e)
        {
            recoveryQuestionComboBox.BorderColor = Color.Black;
        }

        private void recoveryQuestionComboBox_Leave(object sender, EventArgs e)
        {
            recoveryQuestionComboBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void recoveryAnswerTextBox_Enter(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.Black;
        }

        private void recoveryAnswerTextBox_Leave(object sender, EventArgs e)
        {
            recoveryAnswerTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }
    }
}
