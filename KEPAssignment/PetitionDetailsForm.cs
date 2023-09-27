using DataAccess.Models;
using DataAccess;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KEPAssignment.Properties;

namespace KEPAssignment
{
    public partial class PetitionDetailsForm : Form
    {
        public Petition CurrentPetition { get; set; }
        public PetitionDetailsForm(int petitionId)
        {
            InitializeComponent();
            CurrentPetition = DataAccessOperations.GetPetition(petitionId);
            petitionAliasTextBox.Texts = CurrentPetition.PetitionAlias;
            citizenAFMTextBox.Texts = CurrentPetition.CitizenAfmOfPetition;
            petitionTypeComboBox.Texts = CurrentPetition.PetitionType;
            petitionStatusComboBox.Texts = CurrentPetition.PetitionStatus;
            petitionDescriptionTextBox.Texts = CurrentPetition.PetitionDescription;
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            StringBuilder emptyFields = new StringBuilder();
            emptyFields.Append("All fields must be filled. Please fill");

            if (citizenAFMTextBox.Texts == "")
            {
                MessageBox.Show("All fields must be filled. Please fill the citizen's AFM field and try again.", "Empty Fields",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (petitionAliasTextBox.Texts.Length > 20)
            {
                MessageBox.Show("The petition alias must be less or equal to 20 characters long",
                    "Invalid Petition Alias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionTypeComboBox;
                petitionTypeComboBox.Focus();
                return;
            }

            if (petitionTypeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please pick one of the available petition types and try again",
                    "Invalid ComboBox Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionTypeComboBox;
                petitionTypeComboBox.Focus();
                return;
            }

            long x;
            if (!Int64.TryParse(citizenAFMTextBox.Texts, out x))
            {
                MessageBox.Show("The citizen's AFM must contain only digits.",
                    "Invalid AFM Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            if (citizenAFMTextBox.Texts.Length != 9)
            {
                MessageBox.Show("The citizen's AFM must be 9 digits long.",
                    "Invalid AFM Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            if (petitionDescriptionTextBox.Texts.Length > 250)
            {

                MessageBox.Show("The description length must not exceed the 250 characters limit.",
                    "Invalid Description Length", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = petitionDescriptionTextBox;
                petitionDescriptionTextBox.Focus();
                return;
            }

            if (DataAccessOperations.GetCitizen(citizenAFMTextBox.Texts).AFM == null)
            {
                MessageBox.Show("There is no registered user with the given afm",
                    "Invalid AFM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citizenAFMTextBox.Texts = "";
                this.ActiveControl = citizenAFMTextBox;
                citizenAFMTextBox.Focus();
                return;
            }

            Petition petition = new Petition();
            petition.PetitionId = CurrentPetition.PetitionId;
            petition.PetitionAlias = petitionAliasTextBox.Texts;
            petition.CitizenAfmOfPetition = citizenAFMTextBox.Texts;
            petition.PetitionType = petitionTypeComboBox.Texts;
            petition.PetitionDescription = petitionDescriptionTextBox.Texts;
            petition.PetitionDate = $"{DateTime.Now.Day},{DateTime.Now.Month},{DateTime.Now.Year}";
            petition.PetitionStatus = petitionStatusComboBox.Texts;

            DataAccessOperations.UpdatePetition(petition);

            MessageBox.Show("The petition was successfully updated!",
                    "Petition Sucessfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StaticData.UnsavedChanges = false;

            //go back to the home form
            StaticData.OpenViewPetitionForm = true;
        }

        private void deletePetitionButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this petition?", "Petition Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataAccessOperations.DeletePetition(CurrentPetition.PetitionId);
                MessageBox.Show("Petition deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StaticData.UnsavedChanges = false;

                //go back to the view citizens form
                StaticData.OpenViewPetitionForm = true;
            }
        }

        

        private void textBoxFocusEnter(object sender, EventArgs e)
        {
            CustomTextBox customTextBox = (CustomTextBox)sender;
            customTextBox.BorderColor = Color.Black;
        }

        private void textBoxFocusLeave(object sender, EventArgs e)
        {
            CustomTextBox customTextBox = (CustomTextBox)sender;
            customTextBox.BorderColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void comboBoxFocusEnter(object sender, EventArgs e)
        {
            CustomComboBox customTextBox = (CustomComboBox)sender;
            customTextBox.BorderColor = Color.Black;
            customTextBox.IconColor = Color.Black;
        }

        private void comboBoxFocusLeave(object sender, EventArgs e)
        {
            CustomComboBox customTextBox = (CustomComboBox)sender;
            customTextBox.BorderColor = Color.RoyalBlue;
            customTextBox.IconColor = Color.RoyalBlue;
            checkForChanges();
        }

        private void checkForChanges()
        {
            if (CurrentPetition.PetitionAlias != petitionAliasTextBox.Texts || CurrentPetition.CitizenAfmOfPetition != citizenAFMTextBox.Texts ||
                CurrentPetition.PetitionType != petitionTypeComboBox.Texts || CurrentPetition.PetitionStatus != petitionStatusComboBox.Texts ||
                CurrentPetition.PetitionDescription != petitionDescriptionTextBox.Texts)
            {
                StaticData.UnsavedChanges = true;
            }
            else
            {
                StaticData.UnsavedChanges = false;
            }
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

        private void deletePetitionButton_MouseEnter(object sender, EventArgs e)
        {
            deletePetitionButton.BackColor = Color.RoyalBlue;
            deletePetitionButton.TextColor = Color.Black;
            deletePetitionButton.BorderColor = Color.Black;
        }

        private void deletePetitionButton_MouseLeave(object sender, EventArgs e)
        {
            deletePetitionButton.BackColor = Color.Black;
            deletePetitionButton.TextColor = Color.RoyalBlue;
            deletePetitionButton.BorderColor = Color.RoyalBlue;
        }

        private void petitionAliasEditButton_Click(object sender, EventArgs e)
        {
            if (!petitionAliasTextBox.Enabled)
            {
                petitionAliasTextBox.Enabled = true;
                petitionAliasTextBox.BackColor = Color.White;
                petitionAliasEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            petitionAliasTextBox.Enabled = false;
            petitionAliasTextBox.BackColor = SystemColors.Control;
            petitionAliasEditButton.BackgroundImage = Resources.editIcon;
        }

        private void citizenAfmEditButton_Click(object sender, EventArgs e)
        {
            if (!citizenAFMTextBox.Enabled)
            {
                citizenAFMTextBox.Enabled = true;
                citizenAFMTextBox.BackColor = Color.White;
                citizenAfmEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            citizenAFMTextBox.Enabled = false;
            citizenAFMTextBox.BackColor = SystemColors.Control;
            citizenAfmEditButton.BackgroundImage = Resources.editIcon;
        }

        private void petitionTypeEditButton_Click(object sender, EventArgs e)
        {
            if (!petitionTypeComboBox.Enabled)
            {
                petitionTypeComboBox.Enabled = true;
                petitionTypeComboBox.BackColor = Color.WhiteSmoke;
                petitionTypeEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            petitionTypeComboBox.Enabled = false;
            petitionTypeComboBox.BackColor = SystemColors.Control;
            petitionTypeEditButton.BackgroundImage = Resources.editIcon;
        }

        private void petitionStatusEditButton_Click(object sender, EventArgs e)
        {
            if (!petitionStatusComboBox.Enabled)
            {
                petitionStatusComboBox.Enabled = true;
                petitionStatusComboBox.BackColor = Color.WhiteSmoke;
                petitionStatusEditButton.BackgroundImage = Resources.checkIcon;
                return;
            }
            petitionStatusComboBox.Enabled = false;
            petitionStatusComboBox.BackColor = SystemColors.Control;
            petitionStatusEditButton.BackgroundImage = Resources.editIcon;
        }

        private void editButtonMouseEnter(object sender, EventArgs e)
        {
            CustomButton customButton = (CustomButton)sender;
            customButton.BackColor = Color.White;
        }

        private void editButtonMouseLeave(object sender, EventArgs e)
        {
            CustomButton customButton = (CustomButton)sender;
            customButton.BackColor = Color.RoyalBlue;
        }
    }
}
