using System;
using System.Drawing;
using System.Windows.Forms;

namespace KEPAssignment
{
    public partial class MenuForm : Form
    {
        bool menuExpanded = true;
        bool closedByX = true;
        HomeForm homeForm;
        ViewCitizensForm viewCitizensForm;
        AddCitizenForm addCitizenForm;
        ViewPetitionsForm viewPetitionsForm;
        AddPetitionForm addPetitionForm;
        AccountForm accountForm;
        CitizenDetailsForm citizenDetailsForm;
        PetitionDetailsForm petitionDetailsForm;
        Form currentForm;
        public MenuForm()
        {
            InitializeComponent();
            homeMenuButton.FlatAppearance.BorderSize = 0;
            citizenMenuButton.FlatAppearance.BorderSize = 0;
            petitionMenuButton.FlatAppearance.BorderSize = 0;
            accountMenuButton.FlatAppearance.BorderSize = 0;
            logOutMenuButton.FlatAppearance.BorderSize = 0;

            homeForm = new HomeForm();
            currentForm = homeForm;
            currentForm.TopLevel = false;
            menuPlaceholderPanel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            if (checkForUnsavedChanges())
                return;
            if (typeof(HomeForm) != currentForm.GetType())
            {
                menuPlaceholderPanel.Controls.Remove(currentForm);
                homeForm.RefreshHomeForm();
                currentForm = homeForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();
            }

        }

        private void citizenMenuButton_Click(object sender, EventArgs e)
        {
            if (checkForUnsavedChanges())
                return;
            if (typeof(ViewCitizensForm) != currentForm.GetType())
            {
                viewCitizensForm = new ViewCitizensForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = viewCitizensForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
        }

        private void petitionMenuButton_Click(object sender, EventArgs e)
        {
            if (checkForUnsavedChanges())
                return;
            if (typeof(ViewPetitionsForm) != currentForm.GetType())
            {
                viewPetitionsForm = new ViewPetitionsForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = viewPetitionsForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();
            }
        }

        private void accountMenuButton_Click(object sender, EventArgs e)
        {
            if (checkForUnsavedChanges())
                return;
            if (typeof(AccountForm) != currentForm.GetType())
            {
                if (accountForm == null)
                    accountForm = new AccountForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                accountForm.RefreshOrInitializeAccountForm();
                currentForm = accountForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();
            }

        }

        private void staticDataTimer_Tick(object sender, EventArgs e)
        {
            
            if (StaticData.OpenAddCitizenForm)
            {
                if (addCitizenForm == null)
                    addCitizenForm = new AddCitizenForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                addCitizenForm.RefreshAddCitizenForm();
                currentForm = addCitizenForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenAddCitizenForm = false;
            }
            else if (StaticData.OpenAddPetitionForm)
            {
                if (addPetitionForm == null)
                    addPetitionForm = new AddPetitionForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                addPetitionForm.RefreshAddPetitionForm();
                currentForm = addPetitionForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenAddPetitionForm = false;
            }
            else if (StaticData.OpenViewCitizenForm)
            {
                StaticData.ClearAllCitizensFilters();
                viewCitizensForm = new ViewCitizensForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = viewCitizensForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenViewCitizenForm = false;
            }
            else if (StaticData.OpenViewPetitionForm)
            {
                StaticData.ClearAllPetitionFilters();
                viewPetitionsForm = new ViewPetitionsForm();
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = viewPetitionsForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenViewPetitionForm = false;
            }

            else if (StaticData.OpenHomeForm)
            {
                menuPlaceholderPanel.Controls.Remove(currentForm);
                homeForm.RefreshHomeForm();
                currentForm = homeForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenHomeForm = false;
            }
            else if (StaticData.OpenCitizenDetailsForm)
            {
                citizenDetailsForm = new CitizenDetailsForm(StaticData.CitizenDetailsFormAfmValue);
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = citizenDetailsForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenCitizenDetailsForm = false;
                StaticData.CitizenDetailsFormAfmValue = "";
            }
            else if (StaticData.OpenPetitionDetailsForm)
            {
                petitionDetailsForm = new PetitionDetailsForm(StaticData.PetitionIdValue);
                menuPlaceholderPanel.Controls.Remove(currentForm);
                currentForm = petitionDetailsForm;
                currentForm.TopLevel = false;
                menuPlaceholderPanel.Controls.Add(currentForm);
                currentForm.Show();

                StaticData.OpenPetitionDetailsForm = false;
                StaticData.PetitionIdValue = -1;
            }
        }

        private bool checkForUnsavedChanges()
        {
            if (StaticData.UnsavedChanges)
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes in the form, are you sure " +
                    "that you want to continue?", "Unsaved Changes", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    return true;
                }
            }
            StaticData.UnsavedChanges = false;
            return false;
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpanded)
            {
                menuControlLabel.Visible = false;
                menuPanel.Width = 170;
                menuControlLabel.Visible = true;
                this.Width += 140;
                menuTimer.Stop();
            }
            else
            {
                menuPanel.Width = 35;
                this.Width -= 140;
                menuTimer.Stop();
            }
        }

        private void controlMenuButton_Click(object sender, EventArgs e)
        {
            if (menuExpanded)
                menuExpanded = false;
            else
                menuExpanded = true;
            menuTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (menuExpanded)
                menuExpanded = false;
            else
                menuExpanded = true;
            menuTimer.Start();
        }

        private void menuControlLabel_Click(object sender, EventArgs e)
        {
            if (menuExpanded)
                menuExpanded = false;
            else
                menuExpanded = true;
            menuTimer.Start();
        }

        private void controlMenuPanel_Click(object sender, EventArgs e)
        {
            if (menuExpanded)
                menuExpanded = false;
            else
                menuExpanded = true;
            menuTimer.Start();
        }

        private void logOutMenuButton_Click(object sender, EventArgs e)
        {
            closedByX = false;
            this.Close();
            Application.OpenForms[0].Enabled = true;
            Application.OpenForms[0].Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closedByX)
            {
                Application.Exit();
            }
        }

        ////////////////////////////////////////////// Styling //////////////////////////////////////////////

        private void homeMenuButton_MouseEnter(object sender, EventArgs e)
        {
            homeMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void homeMenuButton_MouseLeave(object sender, EventArgs e)
        {
            homeMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void homeMenuButton_Enter(object sender, EventArgs e)
        {
            homeMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void homeMenuButton_Leave(object sender, EventArgs e)
        {
            homeMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void citizenMenuButton_MouseEnter(object sender, EventArgs e)
        {
            citizenMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void citizenMenuButton_MouseLeave(object sender, EventArgs e)
        {
            citizenMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void citizenMenuButton_Enter(object sender, EventArgs e)
        {
            citizenMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void citizenMenuButton_Leave(object sender, EventArgs e)
        {
            citizenMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void petitionMenuButton_MouseEnter(object sender, EventArgs e)
        {
            petitionMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void petitionMenuButton_MouseLeave(object sender, EventArgs e)
        {
            petitionMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void petitionMenuButton_Enter(object sender, EventArgs e)
        {
            petitionMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void petitionMenuButton_Leave(object sender, EventArgs e)
        {
            petitionMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void accountMenuButton_MouseEnter(object sender, EventArgs e)
        {
            accountMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void accountMenuButton_MouseLeave(object sender, EventArgs e)
        {
            accountMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void accountMenuButton_Enter(object sender, EventArgs e)
        {
            accountMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void accountMenuButton_Leave(object sender, EventArgs e)
        {
            accountMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void logOutMenuButton_MouseEnter(object sender, EventArgs e)
        {
            logOutMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void logOutMenuButton_MouseLeave(object sender, EventArgs e)
        {
            logOutMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void logOutMenuButton_Enter(object sender, EventArgs e)
        {
            logOutMenuButton.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void logOutMenuButton_Leave(object sender, EventArgs e)
        {
            logOutMenuButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void controlMenuPanel_MouseEnter(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void controlMenuPanel_MouseLeave(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void controlMenuPanel_Enter(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void controlMenuPanel_Leave(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void controlMenuPicturebox_MouseEnter(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(55, 55, 55);
        }

        private void menuControlLabel_MouseEnter(object sender, EventArgs e)
        {
            controlMenuPanel.BackColor = Color.FromArgb(55, 55, 55);
        }
    }
}
